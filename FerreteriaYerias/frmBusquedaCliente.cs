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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }
        public void obtenerProductos()
        {

            using (FerreteriaEntities1 bd = new FerreteriaEntities1())
            {
                var consulta = (from
                                c in bd.CLIENTE
                                select new
                                {
                                    c.TipoDoc,
                                    c.NumDoc,
                                    c.NomCliente,
                                    c.ApeCliente
                                });
                dgvListaC.DataSource = consulta.ToList();
                dgvListaC.Columns[1].HeaderText = "Documento";
                dgvListaC.Columns[2].HeaderText = "N° Documento";
                dgvListaC.Columns[3].HeaderText = "Nombre";
                dgvListaC.Columns[4].HeaderText = "Apellido";
            }

        }
        private void dgvListaC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaC.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                CLIENTE oCliente = new CLIENTE()
                {
                    TipoDoc = dgvListaC.Rows[e.RowIndex].Cells["TipoDoc"].Value.ToString(),
                    NomCliente = dgvListaC.Rows[e.RowIndex].Cells["NomCliente"].Value.ToString(),
                    NumDoc = Convert.ToInt32(dgvListaC.Rows[e.RowIndex].Cells["NumDoc"].Value.ToString()),
                    ApeCliente = dgvListaC.Rows[e.RowIndex].Cells["ApeCliente"].Value.ToString()
                };

                frmVenta.oObjecto2 = null;
                frmVenta.oObjecto2 = oCliente;
                this.Close();
            }
        }
        private void frmBusquedaCliente_Load(object sender, EventArgs e)
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
            dgvListaC.Columns.Add(BotonSeleccionar);

            obtenerProductos();

            dgvListaC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaC.MultiSelect = false;
            dgvListaC.ReadOnly = true;
            dgvListaC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaC.AllowUserToAddRows = false;
            dgvListaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
