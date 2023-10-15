using System;
using System.Collections.Generic;

namespace WebMinervaMVC.Models;

public partial class Compra
{
    public int Id { get; set; }

    public int IdProveedor { get; set; }

    public int Transaccion { get; set; }

    public DateTime Fecha { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<CompraDetalle> CompraDetalles { get; set; } = new List<CompraDetalle>();

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
