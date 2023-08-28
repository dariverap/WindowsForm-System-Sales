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
    public partial class frmPrincipal : Form
    {
        public static int IdUsuario;
        public frmPrincipal( int pIdusuario)
        {
            IdUsuario=pIdusuario;
            InitializeComponent();
        }

        private void mostrarformulario(Form formulario, object senderitem)
        {
            foreach (Form formu in this.MdiChildren)
            {
                formu.Close();
            }

            foreach (ToolStripMenuItem menu in msMenu.Items)
            {
                menu.BackColor = Color.White;
            }
            ((ToolStripMenuItem)senderitem).BackColor = Color.White;

            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
        }

        private void ventasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmVenta fmrHijo = new frmVenta((IdUsuario));
            mostrarformulario(fmrHijo, sender);
        }

        private void pRODUCTOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProductos fmrHijo = new frmProductos();
            mostrarformulario(fmrHijo, sender);
        }

        private void rEPORTEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmReporteVentas fmrHijo = new frmReporteVentas();
            mostrarformulario(fmrHijo, sender);
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModalAcercaDe fmrHijo = new frmModalAcercaDe();
            fmrHijo.ShowDialog();
        }
    }
}
