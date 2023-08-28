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
    public partial class frmBusquedaProducto : Form
    {
        public frmBusquedaProducto()
        {
            InitializeComponent();
        }
        public void obtenerProductos()
        {

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
                dgvLista.DataSource = consulta.ToList();
                dgvLista.Columns[1].HeaderText = "Codigo";
                dgvLista.Columns[2].HeaderText = "Nombre";
                dgvLista.Columns[3].HeaderText = "Stock";
                dgvLista.Columns[4].HeaderText = "Precio Venta";
                dgvLista.Columns[5].HeaderText = "Estado";
            }

        }

        private void frmBusquedaProducto_Load(object sender, EventArgs e)
        {
            //AGREGAR BOTON SELECCIONAR
            DataGridViewButtonColumn BotonSeleccionar = new DataGridViewButtonColumn();
            BotonSeleccionar.HeaderText = "Seleccionar";
            BotonSeleccionar.Text = "Seleccionar";
            BotonSeleccionar.Width = 70;
            BotonSeleccionar.Name = "btnSeleccionar";
            BotonSeleccionar.FlatStyle = FlatStyle.Flat;
            BotonSeleccionar.UseColumnTextForButtonValue = true;
            BotonSeleccionar.CellTemplate.Style.BackColor = Color.AliceBlue;
            BotonSeleccionar.CellTemplate.Style.SelectionBackColor = Color.CadetBlue;
            //AGREGAMOS EL BOTON
            dgvLista.Columns.Add(BotonSeleccionar);

            obtenerProductos();

            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.MultiSelect = false;
            dgvLista.ReadOnly = true;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                PRODUCTO oProducto = new PRODUCTO()
                {
                    CodProd = Convert.ToInt32(dgvLista.Rows[e.RowIndex].Cells["CodProd"].Value.ToString()),
                    NomProd = dgvLista.Rows[e.RowIndex].Cells["NomProd"].Value.ToString(),
                    StockProd = Convert.ToInt32(dgvLista.Rows[e.RowIndex].Cells["StockProd"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvLista.Rows[e.RowIndex].Cells["PrecioVenta"].Value.ToString()),
                    Estado = dgvLista.Rows[e.RowIndex].Cells["Estado"].Value.ToString()

                };
                if (oProducto.Estado=="INACTIVO") 
                {
                    MessageBox.Show("PRODUCTO INACTIVO, ESCOGA OTRO PRODUCTO");
                    return;
                }
                if (oProducto.StockProd == 0)
                {
                    MessageBox.Show("PRODUCTO AGOTADO");
                    return;
                }


                frmVenta.oObjecto = null;
                frmVenta.oObjecto = oProducto;
                this.Close();
                //int IdProducto = int.Parse(dgvVenta.Rows[index].Cells["IdProducto"].Value.ToString());
                //int Cantidad = int.Parse(dgvVenta.Rows[index].Cells["Cantidad"].Value.ToString());
                //bool Respuesta = CD_ProductoTienda.ControlarStock(IdProducto, int.Parse(txtIdTienda.Text.Trim()), Cantidad, false);



            }
        }
    }
}
