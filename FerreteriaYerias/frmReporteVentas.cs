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
    public partial class frmReporteVentas : Form
    {
        decimal ventasTotal=0;
        decimal ventasIGV = 0;
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        public void obtenerVentas() {

            using (FerreteriaEntities1 bd = new FerreteriaEntities1())
            {
                var consulta = (from c in bd.COMPROBANTE
                                join pg in bd.PAGO on c.IdPago equals pg.IdPago
                                select new
                                {
                                    c.FechaComprobante,
                                    c.TipoComprobante,
                                    c.NumComprobante,
                                    c.ApeCliente,
                                    c.NomCliente,
                                    pg.NomTipoPago,
                                    c.IGVComprobante,
                                    c.Total

                                });
                foreach (var item in consulta)
                {
                    ventasTotal = item.Total.Value + ventasTotal;
                    ventasIGV = item.IGVComprobante.Value + ventasIGV;
                }
                lblTotalVentas.Text = ventasTotal.ToString();
                lbligv.Text = ventasIGV.ToString();
                lblSubTotal.Text=(ventasTotal-ventasIGV).ToString();

                dgvReporte.DataSource = consulta.ToList();
                dgvReporte.Columns[0].HeaderText = "Fecha";
                dgvReporte.Columns[1].HeaderText = "Tipo Comprobante";
                dgvReporte.Columns[2].HeaderText = "N° Comprobante";
                dgvReporte.Columns[3].HeaderText = "Apellido";
                dgvReporte.Columns[4].HeaderText = "Nombre";
                dgvReporte.Columns[5].HeaderText = "Tipo Pago";
                dgvReporte.Columns[6].HeaderText = "IGV";
                dgvReporte.Columns[7].HeaderText = "Total";
                dgvReporte.MultiSelect = false;
                dgvReporte.ReadOnly = true;
                dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReporte.AllowUserToAddRows = false;
            }
            ventasTotal = 0;
            ventasIGV = 0;


        }
        public void rangoVentas() { 
        
        
        }
        public void sumaVentas( List<COMPROBANTE> lst) {

           
        }
        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
           obtenerVentas();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            dgvReporte.Columns.Clear();
            DateTime fecha1 = dtpDesde.Value;
            DateTime fecha2 = dtpHasta.Value;
            

            using (FerreteriaEntities1 bd = new FerreteriaEntities1())
            {
                var lst = (from p in bd.rango_fecha(fecha1,fecha2)
                           join pg in bd.PAGO on p.IdPago equals pg.IdPago
                           select new
                           {   p.FechaComprobante,
                               p.TipoComprobante,
                               p.NumComprobante,
                               p.ApeCliente,
                               p.NomCliente,
                               pg.NomTipoPago,
                               p.IGVComprobante,
                               p.Total

                           }).ToList();
                
                
                dgvReporte.DataSource = lst;
                dgvReporte.Columns[0].HeaderText = "Fecha";
                dgvReporte.Columns[1].HeaderText = "Tipo Comprobante";
                dgvReporte.Columns[2].HeaderText = "N° Comprobante";
                dgvReporte.Columns[3].HeaderText = "Apellido";
                dgvReporte.Columns[4].HeaderText = "Nombre";
                dgvReporte.Columns[5].HeaderText = "Tipo Pago";
                dgvReporte.Columns[6].HeaderText = "IGV";
                dgvReporte.Columns[7].HeaderText = "Total";

                dgvReporte.MultiSelect = false;
                dgvReporte.ReadOnly = true;
                dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReporte.AllowUserToAddRows = false;
                foreach (var item in lst)
                {
                    ventasTotal = item.Total.Value + ventasTotal;
                    ventasIGV = item.IGVComprobante.Value + ventasIGV;
                }

                lblTotalVentas.Text = ventasTotal.ToString();
                lbligv.Text = ventasIGV.ToString();
                lblSubTotal.Text = (ventasTotal - ventasIGV).ToString();

            }
            ventasTotal = 0;
            ventasIGV = 0;

        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
