using CadMinerva;
using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmProducto : Form
    {
        bool esNuevo = false;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var productos = ProductoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = productos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["saldo"].HeaderText = "Saldo";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEditar.Enabled = productos.Count > 0;
            btnEliminar.Enabled = productos.Count > 0;
            if (productos.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(830, 347);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(830, 462);
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(830, 462);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var producto = ProductoCln.get(id);
            txtCodigo.Text = producto.codigo;
            txtDescripcion.Text = producto.descripcion;
            cbxUnidadMedida.Text = producto.unidadMedida;
            nudSaldo.Value = producto.saldo;
            nudPrecioVenta.Value = producto.precioVenta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(830, 347);
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpUnidadMedida.SetError(cbxUnidadMedida, "");
            erpSaldo.SetError(nudSaldo, "");
            erpPrecioVenta.SetError(nudPrecioVenta, "");
            if (string.IsNullOrEmpty(txtCodigo.Text)) 
            { 
                esValido = false;
                erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxUnidadMedida.Text))
            {
                esValido = false;
                erpUnidadMedida.SetError(cbxUnidadMedida, "El campo Unidad de Medida es obligatorio");
            }
            if (string.IsNullOrEmpty(nudSaldo.Text))
            {
                esValido = false;
                erpSaldo.SetError(nudSaldo, "El campo Saldo es obligatorio");
            }
            if (nudSaldo.Value < 0)
            {
                esValido = false;
                erpSaldo.SetError(nudSaldo, "El campo Saldo debe ser mayor o igual a 0");
            }
            if (string.IsNullOrEmpty(nudPrecioVenta.Text))
            {
                esValido = false;
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var producto = new Producto();
                producto.codigo = txtCodigo.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.unidadMedida = cbxUnidadMedida.Text;
                producto.saldo = nudSaldo.Value;
                producto.precioVenta = nudPrecioVenta.Value;
                producto.usuarioRegistro = "SIS257";

                if (esNuevo)
                {
                    producto.fechaRegistro = DateTime.Now;
                    producto.estado = 1;
                    ProductoCln.insertar(producto);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    producto.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ProductoCln.actualizar(producto);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Producto guardado correctamente", "::: Minerva - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cbxUnidadMedida.SelectedIndex = -1;
            nudSaldo.Value = 0;
            nudPrecioVenta.Value = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el producto {codigo}?",
                "::: Minerva - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ProductoCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: Minerva - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
