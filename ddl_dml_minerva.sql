-- DDL
--CREATE DATABASE Minerva;

USE master
GO
CREATE LOGIN usrminerva WITH PASSWORD=N'123456',
	DEFAULT_DATABASE=Minerva,
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=ON
GO
USE Minerva
GO
CREATE USER usrminerva FOR LOGIN usrminerva
GO
ALTER ROLE db_owner ADD MEMBER usrminerva
GO

DROP TABLE CompraDetalle;
DROP TABLE Compra;
DROP TABLE Usuario;
DROP TABLE Empleado;
DROP TABLE Proveedor;
DROP TABLE Producto;

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(10) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  unidadMedida VARCHAR(20) NOT NULL,
  saldo DECIMAL NOT NULL DEFAULT 0,
  precioVenta DECIMAL NOT NULL CHECK(precioVenta > 0)
);
CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL,
  direccion VARCHAR(250) NULL,
  telefono VARCHAR(30) NOT NULL,
  representante VARCHAR(100) NOT NULL
);
CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(15) NOT NULL,
  nombres VARCHAR(20) NOT NULL,
  primerApellido VARCHAR(20) NULL,
  segudoApellido VARCHAR(20) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(30) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(12) NOT NULL,
  clave VARCHAR(100) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProveedor INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);
CREATE TABLE CompraDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK(cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY(idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE	Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

CREATE PROC paProductoListar @parametro VARCHAR(50)
AS
  SELECT id,codigo,descripcion,unidadMedida,saldo,precioVenta,usuarioRegistro,fechaRegistro,estado 
  FROM Producto
  WHERE estado<>-1 AND descripcion LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paProductoListar 'bond oficio';

-- DML
INSERT INTO Producto(codigo,descripcion,unidadMedida,saldo,precioVenta)
VALUES ('KJ001', 'Hojas bond tamaño oficio', 'Paquete', 0, 28.0);

INSERT INTO Producto(codigo,descripcion,unidadMedida,saldo,precioVenta)
VALUES ('BL001', 'Bolígrafo Pilot', 'Unidad', 0, 5);

UPDATE Producto SET codigo='BG001',precioVenta=7 WHERE id=2;
UPDATE Producto SET estado=-1 WHERE id=2; -- Eliminación lógica
UPDATE Producto SET estado=0 WHERE id=2;  -- Establecer registro como inactivo
-- DELETE FROM Producto WHERE id=2;

SET IDENTITY_INSERT [dbo].[Empleado] ON
INSERT INTO [dbo].[Empleado] ([id], [cedulaIdentidad], [nombres], [primerApellido], [segudoApellido], [direccion], [celular], [cargo], [usuarioRegistro], [fechaRegistro], [estado]) VALUES (1, N'123456', N'Juan', N'Perez', N'Lopez', N'Calle Loa N° 5', 76767676, N'Administrador', N'sis457', N'2023-10-21 10:23:17', 1)
INSERT INTO [dbo].[Empleado] ([id], [cedulaIdentidad], [nombres], [primerApellido], [segudoApellido], [direccion], [celular], [cargo], [usuarioRegistro], [fechaRegistro], [estado]) VALUES (2, N'987654', N'Maria', N'Suárez', N'Bae', N'Av. Jaime Mendoza S/N', 76767678, N'Cajero', N'sis457', N'2023-10-21 10:24:52', 1)
SET IDENTITY_INSERT [dbo].[Empleado] OFF

SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT INTO [dbo].[Usuario] ([id], [idEmpleado], [usuario], [clave], [usuarioRegistro], [fechaRegistro], [estado]) VALUES (1, 1, N'jperez', N'sNHlIWhFGGMvPk5ii1nVUw==', N'sis457', N'2023-10-21 10:29:49', 1)
INSERT INTO [dbo].[Usuario] ([id], [idEmpleado], [usuario], [clave], [usuarioRegistro], [fechaRegistro], [estado]) VALUES (2, 2, N'maria', N'sNHlIWhFGGMvPk5ii1nVUw==', N'sis457', N'2023-10-23 20:36:56', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF


SELECT * FROM Producto WHERE estado=1;
