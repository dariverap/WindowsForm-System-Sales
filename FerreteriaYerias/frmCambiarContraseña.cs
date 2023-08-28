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
    public partial class frmCambiarContraseña : Form
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }
        private bool FormularioValido()
        {
            bool valido = false;

            string nomusuario = txtNombreUsuario.Text.Trim();
            string pregunta = txtPregunta.Text.Trim();
            string respuesta = txtRespuesta.Text.Trim();
            string nuevacontraseña = txtNuevaContraseña.Text.Trim();

            if (nomusuario.Length > 0 && pregunta.Length > 0 && respuesta.Length > 0 && nuevacontraseña.Length > 0)
                valido = true;
            return valido;
        }

        public void obtenerUsuario()
        {
            if (FormularioValido())
            {
                int ID = 0;
                String nombre = "";
                using (FerreteriaEntities1 bd = new FerreteriaEntities1())
                {
                    var lst = from u in bd.USUARIO
                              where
                              u.NomUsuario == txtNombreUsuario.Text
                              &&
                              u.Pregunta == txtPregunta.Text
                              select u;

                    foreach (USUARIO u in lst)
                    {
                        ID = u.IdUsuario;
                        nombre = u.NombreEmpleado;
                    }

                    if (lst.Count() > 0)
                    {
                        using (FerreteriaEntities1 bdU = new FerreteriaEntities1())
                        {
                            USUARIO estruU = new USUARIO();
                            estruU.NomUsuario = txtNombreUsuario.Text;
                            estruU.Pregunta = txtPregunta.Text;
                            estruU.ContraUsuario = txtNuevaContraseña.Text;
                            estruU.IdUsuario = ID;
                            estruU.NombreEmpleado = nombre;


                            bdU.Entry(estruU).State = System.Data.Entity.EntityState.Modified;
                            bdU.SaveChanges();

                        }
                        MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("DATOS INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("INGRESE TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPregunta.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS Y/O LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtPregunta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNuevaContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS Y/O LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevaContraseña.Focus();
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS Y/O LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
