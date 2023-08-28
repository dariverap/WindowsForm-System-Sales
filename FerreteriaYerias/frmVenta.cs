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
    public partial class frmVenta : Form
    {
        public static int IdUsuario2;
        public static object oObjecto;
        public static object oObjecto2;
        float SubTotal = 0;
        float IGV = 0;
        float Total = 0;
        public frmVenta(int pIdusuario)
        {
            IdUsuario2 = pIdusuario;
            InitializeComponent();
        }
        public void guardarCliente()
        {
            if (FormularioValido())
            {

                using (FerreteriaEntities1 bd = new FerreteriaEntities1())
                {

                    CLIENTE estru = new CLIENTE();
                    estru.NomCliente = txtNombreCliente.Text;
                    estru.TipoDoc = cboTipoDocumentoCliente.Text;
                    estru.ApeCliente = txtApellidoCliente.Text;
                    estru.NumDoc = Int32.Parse(txtDocumentoCliente.Text);
                    bd.CLIENTE.Add(estru);
                    bd.SaveChanges();
                }
            }
            else
                MessageBox.Show("INGRESE TODOS LOS DATOS DEL CLIENTE", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void modificarCliente()
        {

            if (FormularioValido())
            {
                using (FerreteriaEntities1 bd = new FerreteriaEntities1())
                {
                    CLIENTE estru = new CLIENTE();
                    estru.NomCliente = txtNombreCliente.Text;
                    estru.TipoDoc = cboTipoDocumentoCliente.Text;
                    estru.ApeCliente = txtApellidoCliente.Text;
                    estru.NumDoc = Int32.Parse(txtDocumentoCliente.Text);
                    bd.Entry(estru).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
            }
            else
                MessageBox.Show("INGRESE TODOS LOS DATOS DEL CLIENTE", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void datosFerreteria()
        {
            txtFechaVenta.Text = DateTime.Today.ToShortDateString();
            txtFerreteria.Text = "FERRETERIA YERIAS SAC";
            txtRUC.Text = "20601574862 ";
            txtFerreteriaDireccion.Text = "AV LOS OLIVARES 123";

            using (FerreteriaEntities1 bd = new FerreteriaEntities1())
            {

                var lst = from u in bd.USUARIO
                          where
                          u.IdUsuario == IdUsuario2
                          select u;

                foreach (USUARIO u in lst)
                {
                    txtEmpleadoID.Text = u.IdUsuario.ToString();
                    txtEmpleadoNombre.Text = u.NombreEmpleado;
                }

            }
        }
        public void cargarDGV()
        {
            DataGridViewButtonColumn BotonElimar = new DataGridViewButtonColumn();

            BotonElimar.HeaderText = "Eliminar";
            BotonElimar.Width = 10;
            BotonElimar.Text = "Eliminar";
            BotonElimar.Name = "btnEliminar";
            BotonElimar.FlatStyle = FlatStyle.Flat;
            BotonElimar.UseColumnTextForButtonValue = true;
            BotonElimar.CellTemplate.Style.BackColor = Color.MistyRose;
            BotonElimar.CellTemplate.Style.ForeColor = Color.Black;
            BotonElimar.CellTemplate.Style.SelectionBackColor = Color.MistyRose;
            BotonElimar.CellTemplate.Style.SelectionForeColor = Color.Black;

            dgvVenta.Columns.Add(BotonElimar);

            dgvVenta.Columns.Add("IdProducto", "IdProducto");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("Producto", "Producto");

            dgvVenta.Columns.Add("PrecioUnidad", "Precio Unidad");
            dgvVenta.Columns.Add("Precio Unidad", "Precio Unidad");

            dgvVenta.Columns.Add("ImporteTotal", "Importe Total");
            dgvVenta.Columns.Add("Importe Total", "Importe Total");


            dgvVenta.Columns["IdProducto"].Visible = false;
            dgvVenta.Columns["PrecioUnidad"].Visible = false;
            dgvVenta.Columns["ImporteTotal"].Visible = false;



            dgvVenta.MultiSelect = false;
            dgvVenta.ReadOnly = true;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.AllowUserToAddRows = false;

        }
        private void CalcularTotal()
        {
            Total = 0;
            SubTotal = 0;
            IGV = 0;
            foreach (DataGridViewRow r in dgvVenta.Rows)
            {
                Total += float.Parse(r.Cells["ImporteTotal"].Value.ToString());
            }

            IGV = float.Parse((Total * 0.18).ToString());
            SubTotal = Total - IGV;

            lblSubTotal.Text = SubTotal.ToString("0.00");
            lblIGV.Text = IGV.ToString("0.00");
            lblTotal.Text = Total.ToString("0.00");
            lblTotalProductos.Text = dgvVenta.Rows.Count.ToString();
        }
        public void actualizarStock()
        {

            using (FerreteriaEntities1 bdP = new FerreteriaEntities1())
            {
                PRODUCTO estruP = new PRODUCTO();
                estruP.CodProd = Convert.ToInt32(txtProductoCodigo.Text);
                estruP.StockProd = Convert.ToInt32(txtStock.Text) - Convert.ToInt32(txtCantidad.Text);
                estruP.NomProd = txtProductoNombre.Text;
                estruP.PrecioVenta = Convert.ToDecimal(txtPrecioUnidad.Text);
                estruP.Estado = "ACTIVO";
                bdP.Entry(estruP).State = System.Data.Entity.EntityState.Modified;
                bdP.SaveChanges();
            }
        }
        public void limpiarDgv()
        {
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                int cod = Convert.ToInt32(fila.Cells["IdProducto"].Value.ToString().Trim());
                int stock = 0;
                using (FerreteriaEntities1 bdP = new FerreteriaEntities1())
                {
                    var lst = from p in bdP.PRODUCTO
                              where
                              p.CodProd == cod
                              select p;
                    foreach (PRODUCTO u in lst)
                    {
                        stock = Convert.ToInt32(u.StockProd);
                    }

                }
                using (FerreteriaEntities1 bdP2 = new FerreteriaEntities1())
                {

                    PRODUCTO estruP = new PRODUCTO();
                    estruP.CodProd = cod;
                    estruP.StockProd = Convert.ToInt32(fila.Cells["Cantidad"].Value.ToString()) + stock;
                    estruP.NomProd = fila.Cells["Producto"].Value.ToString();
                    estruP.PrecioVenta = Convert.ToDecimal(fila.Cells["PrecioUnidad"].Value.ToString());
                    estruP.Estado = "ACTIVO";
                    bdP2.Entry(estruP).State = System.Data.Entity.EntityState.Modified;
                    bdP2.SaveChanges();
                }
            }
            dgvVenta.Rows.Clear();
        }
        private void limpiarDatos()
        {
            cboTipoDocumentoVenta.SelectedIndex = 0;

            //PRODUCTO

            txtProductoCodigo.Text = "";
            txtProductoNombre.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCantidad.Value = 1;
            btnAgregarProducto.Focus();

            //IMPORTES
            Total = 0;
            SubTotal = 0;
            IGV = 0;
            lblSubTotal.Text = "0";
            lblIGV.Text = "0";
            lblTotal.Text = "0";
            lblTotalProductos.Text = "0";


            //CLIENTE
            cboTipoDocumentoCliente.SelectedIndex = 0;
            txtDocumentoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";

        }
        public void cargarProductos()
        {

            if (txtProductoCodigo.Text.Trim() == "0" || txtCantidad.Value < 1 || txtProductoNombre.Text.Trim() == "")
            {
                MessageBox.Show("SELECCIONE UN PRODUCTO PRIMERO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool productoexiste = false;

            foreach (DataGridViewRow r in dgvVenta.Rows)
            {
                if (r.Cells["IdProducto"].Value.ToString().Equals(txtProductoCodigo.Text.Trim()))
                {
                    productoexiste = true;
                    break;
                }
            }
            if (!productoexiste)
            {
                actualizarStock();
                int rowId = dgvVenta.Rows.Add();
                DataGridViewRow row = dgvVenta.Rows[rowId];
                row.Cells["IdProducto"].Value = txtProductoCodigo.Text.Trim();
                row.Cells["Cantidad"].Value = txtCantidad.Value.ToString();
                row.Cells["Producto"].Value = txtProductoNombre.Text.ToString();
                row.Cells["PrecioUnidad"].Value = float.Parse(txtPrecioUnidad.Text.Trim());
                row.Cells["Precio Unidad"].Value = string.Format("S/.{0}", txtPrecioUnidad.Text.Trim());
                row.Cells["ImporteTotal"].Value = float.Parse(txtCantidad.Value.ToString()) * float.Parse(txtPrecioUnidad.Text.Trim());
                row.Cells["Importe Total"].Value = string.Format("S/.{0}", float.Parse(txtCantidad.Value.ToString()) * float.Parse(txtPrecioUnidad.Text.Trim()));


                txtProductoCodigo.Text = "";
                txtProductoNombre.Text = "";
                txtProductoNombre.Text = "";
                txtStock.Text = "";
                txtPrecioUnidad.Text = "";
                txtCantidad.Value = 1;
                btnAgregarProducto.Focus();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("EL PRODUCTO YA FUE AGREGADO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private bool existeCliente()
        {
            bool valido = false;
            string ID;
            using (FerreteriaEntities1 bd = new FerreteriaEntities1())
            {
                var lst = from u in bd.CLIENTE
                          where
                          u.NumDoc.ToString() == txtDocumentoCliente.Text
                          &&
                          u.ApeCliente == txtApellidoCliente.Text
                          &&
                          u.NomCliente == txtNombreCliente.Text
                          select u;

                foreach (CLIENTE u in lst)
                {
                    ID = u.NumDoc.ToString();
                }
                if (lst.Count() > 0)

                    valido = true;

                return valido;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            cargarProductos();
        }



        private void frmVenta_Load(object sender, EventArgs e)
        {

            datosFerreteria();
            cargarDGV();

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            txtDocumentoCliente.Enabled = true;
            int dni = Convert.ToInt32(txtDocumentoCliente.Text);
            using (FerreteriaEntities1 bd = new FerreteriaEntities1())
            {
                var lst = (from p in bd.CLIENTE
                           where
                           p.NumDoc == dni
                           select p).ToList();
                if (lst.Count == 0)
                {
                    guardarCliente();

                }
                if (lst.Count > 0)
                {

                    modificarCliente();
                }
            }

        }
        private bool FormularioValido()
        {
            bool valido = false;

            string idcliente = txtDocumentoCliente.Text.Trim();
            string nomcliente = txtNombreCliente.Text.Trim();
            string apecliente = txtApellidoCliente.Text.Trim();


            if (idcliente.Length == 8 && nomcliente.Length > 1 && apecliente.Length > 1)
                valido = true;
            return valido;
        }



        private void btnImprimirTerminar_Click(object sender, EventArgs e)
        {


            if (FormularioValido())
            {
                if (dgvVenta.Rows.Count < 1)
                {
                    MessageBox.Show("DEBE INGRESAR UN ´PRODUCTO COMO MÍNIMO\nPARA REGISTRAR UNA VENTA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (existeCliente())
                {
                    using (FerreteriaEntities1 bd = new FerreteriaEntities1())
                    {
                        COMPROBANTE estru = new COMPROBANTE();
                        estru.IdCliente = Int32.Parse(txtDocumentoCliente.Text);
                        estru.NomCliente = txtNombreCliente.Text;
                        estru.IGVComprobante = decimal.Parse(lblIGV.Text);
                        estru.Total = decimal.Parse(lblTotal.Text);
                        estru.TipoComprobante = cboTipoDocumentoVenta.Text;
                        estru.FechaComprobante = Convert.ToDateTime(txtFechaVenta.Text);
                        estru.IdUsuario = Int32.Parse(txtEmpleadoID.Text);
                        estru.NomUsuario = txtEmpleadoNombre.Text;
                        estru.ApeCliente = txtApellidoCliente.Text;
                        bd.COMPROBANTE.Add(estru);
                        bd.SaveChanges();

                        DETALLE_COMPROBANTE estru2 = new DETALLE_COMPROBANTE();
                        foreach (DataGridViewRow row in dgvVenta.Rows)
                        {
                            estru2.IdComprobante = estru.NumComprobante;
                            estru2.CodProd = Convert.ToInt32(row.Cells["IdProducto"].FormattedValue);
                            estru2.CantProd = Convert.ToInt32(row.Cells["Cantidad"].FormattedValue);
                            estru2.PrecioVenta = Convert.ToDecimal(row.Cells["PrecioUnidad"].FormattedValue);
                            estru2.ImporteProd = Convert.ToDecimal(row.Cells["ImporteTotal"].FormattedValue); ;
                            bd.DETALLE_COMPROBANTE.Add(estru2);
                            bd.SaveChanges();

                        }
                    }
                    limpiarDatos();
                    dgvVenta.Rows.Clear();
                    MessageBox.Show("COMPRA GUARDADA EXITOSAMENTE");
                }
                else
                    MessageBox.Show("CLIENTE NO EXISTE, REGISTRARLO PRIMERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("INGRESE TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvVenta.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                int cod = Convert.ToInt32(dgvVenta.Rows[e.RowIndex].Cells["IdProducto"].Value.ToString().Trim());
                int stock = 0;
                using (FerreteriaEntities1 bdP = new FerreteriaEntities1())
                {
                    var lst = from p in bdP.PRODUCTO
                              where
                              p.CodProd == cod
                              select p;
                    foreach (PRODUCTO u in lst)
                    {
                        stock = Convert.ToInt32(u.StockProd);
                    }

                }
                using (FerreteriaEntities1 bdP2 = new FerreteriaEntities1())
                {

                    PRODUCTO estruP = new PRODUCTO();
                    estruP.CodProd = cod;
                    estruP.StockProd = Convert.ToInt32(dgvVenta.Rows[index].Cells["Cantidad"].Value.ToString()) + stock;
                    estruP.NomProd = dgvVenta.Rows[index].Cells["Producto"].Value.ToString();
                    estruP.PrecioVenta = Convert.ToDecimal(dgvVenta.Rows[index].Cells["PrecioUnidad"].Value.ToString());
                    estruP.Estado = "ACTIVO";
                    bdP2.Entry(estruP).State = System.Data.Entity.EntityState.Modified;
                    bdP2.SaveChanges();
                }
                dgvVenta.Rows.RemoveAt(index);
                CalcularTotal();

            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            oObjecto = null;
            frmBusquedaProducto frm = new frmBusquedaProducto();
            frm.ShowDialog();

            if (oObjecto != null)
            {
                PRODUCTO oProducto = (PRODUCTO)oObjecto;
                if (oProducto != null)
                {
                    txtProductoCodigo.Text = oProducto.CodProd.ToString();
                    txtProductoNombre.Text = oProducto.NomProd.ToString();
                    txtStock.Text = oProducto.StockProd.ToString();
                    txtPrecioUnidad.Text = oProducto.PrecioVenta.ToString();


                    txtCantidad.Value = 1;
                    txtCantidad.Maximum = Convert.ToDecimal(oProducto.StockProd.ToString());
                }
            }


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            oObjecto2 = null;
            frmBusquedaCliente frm = new frmBusquedaCliente();
            frm.ShowDialog();

            if (oObjecto2 != null)
            {
                CLIENTE oCliente = (CLIENTE)oObjecto2;
                if (oCliente != null)
                {
                    txtNombreCliente.Text = oCliente.NomCliente.ToString();
                    txtDocumentoCliente.Text = oCliente.NumDoc.ToString();
                    txtApellidoCliente.Text = oCliente.ApeCliente.ToString();
                    cboTipoDocumentoCliente.Text = oCliente.TipoDoc.ToString();
                }
                txtDocumentoCliente.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            limpiarDgv();
            limpiarDatos();
        }

        private void txtDocumentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoCliente.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombreCliente.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 126))
            {
                MessageBox.Show("SOLO SE PERMITEN LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDocumentoCliente.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 126))
            {
                MessageBox.Show("SOLO SE PERMITEN LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}