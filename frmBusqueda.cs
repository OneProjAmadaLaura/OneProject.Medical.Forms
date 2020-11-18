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

using System.Data.Objects.SqlClient;

    namespace OneProject.Medical.Forms
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            chkFechaReg.Checked = true;

            List<EstatusEstudio> listEstatus = new List<EstatusEstudio>()
                {

                    new EstatusEstudio() { IdEstatus = 0, Estatus = "Seleccione..." },
                    new EstatusEstudio() { IdEstatus = 1, Estatus = "Captura" },
                    new EstatusEstudio() { IdEstatus = 2, Estatus = "Pagado" },
                    new EstatusEstudio() { IdEstatus = 3, Estatus = "Impreso" },
                    new EstatusEstudio() { IdEstatus = 4, Estatus = "Prueba tomada" },
                };

            cboEstatus.DisplayMember = "Estatus";
            cboEstatus.ValueMember = "IdEstatus";
            cboEstatus.DataSource = listEstatus.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }


        private void Buscar()
        {
            //  fecha = SqlFunctions.DateName("day", ma.fecha) + "/" + SqlFunctions.DateName("month", ma.fecha) + "/" + SqlFunctions.DateName("year", ma.fecha)

            /*
             *                                FechaRegistro = DateTime.Parse(d.FechaRegistro.ToString()).ToString("dd/MM/yyyy"),
                               FechaPago = DateTime.Parse(d.FechaPago.ToString()).ToString("dd/MM/yyyy"),
                               FechaImpresion = DateTime.Parse(d.FechaImpresion.ToString()).ToString("dd/MM/yyyy"),
                               FechaAplicacionPrueba = DateTime.Parse(d.FechaPrueba.ToString()).ToString("dd/MM/yyyy"),

             * 
             * */

            int iEstatus = 0;
            using (EstudioEpidemiologicoEntities tablas = new EstudioEpidemiologicoEntities())
            {
                var lst = (from d in tablas.DatosGenerales
                           select new
                           {
                               Identificador = d.IdPersona,
                               ApellidoPaterno = d.PrimerApellido,
                               ApellidoMaterno = d.SegundoApellido,
                               d.Nombres,
                               d.PagoRealizado,
                               FechaRegistro = d.FechaRegistro,
                               FechaPago = d.FechaPago,
                               FechaImpresion = d.FechaImpresion,
                               FechaAplicacionPrueba = d.FechaPrueba,
                           }).AsQueryable();

                if (txtNombre.Text.Trim().Length > 0)
                {
                    lst = lst.Where(d => d.Nombres.Contains(txtNombre.Text.Trim()));
                }

                if (txtPaterno.Text.Trim().Length > 0)
                {
                    lst = lst.Where(d => d.ApellidoPaterno.Contains(txtPaterno.Text.Trim()));
                }

                if (txtMaterno.Text.Trim().Length > 0)
                {
                    lst = lst.Where(d => d.ApellidoMaterno.Contains(txtMaterno.Text.Trim()));
                }

                iEstatus = Convert.ToInt32(cboEstatus.SelectedValue);

                if (iEstatus > 0)
                {
                    switch (iEstatus)
                    {
                        case 1:
                            // Captura
                            lst = lst.Where(d => d.PagoRealizado == false);
                            break;
                        case 2:
                            // Pagado
                            lst = lst.Where(d => d.PagoRealizado == true);
                            break;
                        case 3:
                            // Impreso
                            lst = lst.Where(d => d.FechaImpresion != null && d.FechaAplicacionPrueba == null);
                            break;
                        case 4:
                            // Prueba tomada
                            lst = lst.Where(d => d.FechaAplicacionPrueba != null);
                            break;
                    }

                }

                if (txtMaterno.Text.Trim().Length > 0)
                {
                    lst = lst.Where(d => d.ApellidoMaterno.Contains(txtMaterno.Text.Trim()));
                }

                if (chkFechaReg.Checked)
                {
                    DateTime fec = DateTime.Parse(dtpFechaReg.Value.ToString("dd/MM/yyyy"));
                    DateTime fecComodin = DateTime.Parse(fec.AddDays(1).ToString("dd/MM/yyyy"));

                    lst = lst.Where(d => d.FechaRegistro >= fec && d.FechaRegistro <= fecComodin);
                }

                dgvEstudios.DataSource = lst.ToList();

            }
        }

        private void chkFechaReg_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaReg.Enabled = chkFechaReg.Checked;
        }
    }
}
