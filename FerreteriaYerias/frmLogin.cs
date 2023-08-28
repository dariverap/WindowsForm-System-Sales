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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool FormularioValido()
        {
            bool valido = false;

            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (usuario.Length > 0 && contraseña.Length > 0 )
                valido = true;
            return valido;
        }
        public void autentificar()
        {
            if (FormularioValido())
            {
                int ID = 0;
                using (FerreteriaEntities1 bd = new FerreteriaEntities1())
                {
                    var lst = from u in bd.USUARIO
                              where
                              u.NomUsuario == txtUsuario.Text
                              &&
                              u.ContraUsuario == txtContraseña.Text
                              select u;

                    foreach (USUARIO u in lst)
                    {
                        ID = u.IdUsuario;
                    }

                    if (lst.Count() > 0)
                    {

                        frmPrincipal ventana = new frmPrincipal(ID);
                        ventana.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("CONTRASEÑA O USUARIO INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("INGRESE TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            autentificar();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña ventana = new frmCambiarContraseña();
            
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS Y/O LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                e.Handled = true;
                return;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS Y/O LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
