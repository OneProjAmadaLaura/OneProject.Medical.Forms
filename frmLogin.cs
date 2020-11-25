using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OneProject.Medical.Forms.Models;

namespace OneProject.Medical.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (txtUsuario.Text.Trim().Length == 0 && txtContraseña.Text.Trim().Length == 0)
            {
                lblRequeridoUsu.Visible = true;
                lblRequeridoPass.Visible = true;
            }

            if (txtUsuario.Text.Trim().Length > 0)
            {
                if (txtContraseña.Text.Trim().Length > 0)
                {
                    int exito = 0;

                    List<int> lst = new List<int>();

                    using (EstudioEpidemiologicoEntities tablas = new EstudioEpidemiologicoEntities())
                    {
                        string user = txtUsuario.Text.Trim();
                        string pass = txtContraseña.Text.Trim();

                        lst = (from d in tablas.Usuario
                                  where d.Usuario1 == user
                                  && d.Contrasenia == pass
                                  select d.IdUsuario).ToList();

                    }

                    exito = (lst.Count>0)? lst[0]:0;

                    if (exito > 0)
                    {
                        frmBusqueda busqueda = new frmBusqueda();
                        busqueda.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblErrorGral.Visible=true;
                    }
                    
                }
                else
                {
                    lblRequeridoPass.Visible = true;
                }

            }
            else
            {
                lblRequeridoUsu.Visible = true;
            }
            Cursor.Current = Cursors.Default;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblErrorGral.Visible = false;

            if (txtUsuario.Text.Trim().Length > 0)
                lblRequeridoUsu.Visible = false;
            else
                txtUsuario.Visible = true;

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lblErrorGral.Visible = false;
            if (txtContraseña.Text.Trim().Length > 0)
                lblRequeridoPass.Visible = false;
            else
                txtContraseña.Visible = true;
        }
           
    }
}
