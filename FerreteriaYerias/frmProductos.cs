using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaYerias
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        private bool FormularioValido()
        {
            bool valido = false;

            string nomproducto = txtNombreProducto.Text.Trim();
            string precioventa = txtPrecioVenta.Text.Trim();
            string stock = txtStockProducto.Text.Trim();

            if (nomproducto.Length > 0 && precioventa.Length > 0 && stock.Length > 0)
                valido = true;
            return valido;
        }
        public void Limpiar()
        {
            cbEstado.SelectedIndex = 0;

            //PRODUCTO
            txtCodigoProducto.Text = "";       
            txtNombreProducto.Text = "";
            txtPrecioVenta.Text = "";
            txtStockProducto.Text = "";
            txtNombreProducto.Focus();

        }
        public void obtenerProductos() {

            using (FerreteriaEntities1 bd = new FerreteriaEntities1())
            {
                var consulta = (from
                                p in bd.PRODUCTO
                                select new
                                {
                                    p.CodProd,
                                    p.NomProd,
                                    p.StockProd,
                                    p.PrecioVenta,
                                    p.Estado

                                });
                dgvProductos.DataSource = consulta.ToList();
                dgvProductos.Columns[0].HeaderText = "Código";
                dgvProductos.Columns[1].HeaderText = "Nombre";
                dgvProductos.Columns[2].HeaderText = "Stock";
                dgvProductos.Columns[3].HeaderText = "Precio Venta";
                dgvProductos.Columns[4].HeaderText = "Estado";
            }
        }
        public void guardar()
        {
            if (FormularioValido())
             {
                using (FerreteriaEntities1 bd2 = new FerreteriaEntities1())

                {
                    PRODUCTO stru = new PRODUCTO();
                    stru.NomProd = txtNombreProducto.Text;
                    stru.StockProd = Convert.ToInt32(txtStockProducto.Text);
                    stru.Estado = cbEstado.Text;
                    stru.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    bd2.PRODUCTO.Add(stru);
                    bd2.SaveChanges();

                }
                obtenerProductos();

            }
            else
                MessageBox.Show("INGRESE TODOS LOS DATOS DEL PRODUCTO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void modificar()
        {
            if (FormularioValido())
            {
                using (FerreteriaEntities1 trabajo = new FerreteriaEntities1())
                {
                    PRODUCTO stru = new PRODUCTO();
                    stru.CodProd = Convert.ToInt32(txtCodigoProducto.Text);
                    stru.NomProd = txtNombreProducto.Text;
                    stru.StockProd = Convert.ToInt32(txtStockProducto.Text);
                    stru.Estado = cbEstado.Text;
                    stru.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);

                    trabajo.Entry(stru).State = System.Data.Entity.EntityState.Modified;
                    trabajo.SaveChanges();
                }
                obtenerProductos();
            }
            else
                MessageBox.Show("NINGUN PRODUCTO SELECCIONADO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            obtenerProductos();
            dgvProductos.MultiSelect = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProductos.CurrentRow.Selected = true;
                txtCodigoProducto.Text = dgvProductos.Rows[e.RowIndex].Cells["CodProd"].FormattedValue.ToString();
                txtNombreProducto.Text = dgvProductos.Rows[e.RowIndex].Cells["NomProd"].FormattedValue.ToString();
                txtStockProducto.Text = dgvProductos.Rows[e.RowIndex].Cells["StockProd"].FormattedValue.ToString();
                txtPrecioVenta.Text = dgvProductos.Rows[e.RowIndex].Cells["PrecioVenta"].FormattedValue.ToString();
                cbEstado.Text = dgvProductos.Rows[e.RowIndex].Cells["Estado"].FormattedValue.ToString();             
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtStockProducto.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 126))
            {
                MessageBox.Show("SOLO SE PERMITEN LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVenta.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVenta.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
