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
using System.IO;
using System.Configuration;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace OneProject.Medical.Forms
{
    public partial class frmDetalleEstudio : Form
    {
        public int? id;

        public DatosGenerales datEnt;
        public DatosGenerales dat;

        public frmDetalleEstudio(DatosGenerales dat)
        {
            InitializeComponent();
            this.datEnt = dat;

            lblIdentificadorV.Text = string.Empty;
            lblNombreV.Text = string.Empty;
            lblPaternoV.Text = string.Empty;
            lblMaternoV.Text = string.Empty;

            cargaDatos();
        }

        private void cargaDatos()
        {

            using (EstudioEpidemiologicoEntities tablas = new EstudioEpidemiologicoEntities())
            {
                dat = tablas.DatosGenerales.Find(datEnt.IdPersona);
            }

            lblIdentificadorV.Text = dat.IdPersona.ToString();
            lblNombreV.Text = dat.Nombres;
            lblPaternoV.Text = dat.PrimerApellido;
            lblMaternoV.Text = dat.SegundoApellido;

            if (dat.FechaPago is null)
            {
                // Captura
                lblReqFolio.Visible = true;
                btnRegistrarPago.Visible = true;

            }
            else if (dat.FechaPago != null && dat.FechaImpresion is null)
            {
                // Pagado
                txtFolioPago.Enabled = false;
                txtFolioPago.Text = dat.FolioPago;

                btnImprimir.Visible = true;

            }
            else if (dat.FechaImpresion != null && dat.FechaPrueba is null)
            {
                // Impreso

                txtFolioPago.Enabled = false;
                txtFolioPago.Text = dat.FolioPago;

                btnRegistrarPrueba.Visible = true;
            }
            else if (dat.FechaPrueba != null)
            {
                // Prueba tomada

                txtFolioPago.Enabled = false;
                txtFolioPago.Text = dat.FolioPago;

            }

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (txtFolioPago.Text.Trim().Length > 0)
            {
                lblErrorReq.Visible = false;
                DatosGenerales oTabla = null;

                using (EstudioEpidemiologicoEntities tablas = new EstudioEpidemiologicoEntities())
                {
                    oTabla = tablas.DatosGenerales.Find(dat.IdPersona);

                    oTabla.FolioPago = txtFolioPago.Text;
                    oTabla.FechaPago = DateTime.Now;

                    tablas.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                    tablas.SaveChanges();
                    this.Close();
                }
            }
            else
            {
                lblErrorReq.Visible = true;
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string archivo = "";
            archivo = generarArchivo();

            if (editarArchivo(archivo))
            {
                // Falta pasarlo a PDF e imprimir

                DatosGenerales oTabla = null;

                using (EstudioEpidemiologicoEntities tablas = new EstudioEpidemiologicoEntities())
                {
                    oTabla = tablas.DatosGenerales.Find(dat.IdPersona);

                    oTabla.FechaImpresion = DateTime.Now;

                    tablas.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                    tablas.SaveChanges();
                    this.Close();
                }
            }
        }

        private void btnRegistrarPrueba_Click(object sender, EventArgs e)
        {
            DatosGenerales oTabla = null;

            using (EstudioEpidemiologicoEntities tablas = new EstudioEpidemiologicoEntities())
            {
                oTabla = tablas.DatosGenerales.Find(dat.IdPersona);

                oTabla.FechaPrueba = DateTime.Now;

                tablas.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                tablas.SaveChanges();
                this.Close();
            }
        }

        private string generarArchivo()
        {

            string fuentePath = ConfigurationManager.AppSettings["dirFormato"];
            string destinoPath = ConfigurationManager.AppSettings["dirSalidas"];
            string nombreArchivo = ConfigurationManager.AppSettings["formato"];

            string nuevoArchivo = nombreArchivo + "_" + dat.IdPersona + "_" + DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string ext = ".xlsx";

            string current = Environment.CurrentDirectory;

            // Use Path class to manipulate file and directory paths.
            string fuenteFile = System.IO.Path.Combine(fuentePath, nombreArchivo + ext);
            string destinoFile = System.IO.Path.Combine(destinoPath, nuevoArchivo + ext);
            System.IO.File.Copy(fuenteFile, destinoFile, true);
            return destinoFile;

        }

        private bool editarArchivo(string archivo)
        {
            try
            {
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(archivo, true))
                {
                    IEnumerable<Sheet> sheets = spreadsheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    Sheet sheets1 = sheets.First();

                    string relationshipId = sheets.First().Id.Value;

                    WorksheetPart worksheetPart = (WorksheetPart)spreadsheetDocument.WorkbookPart.GetPartById(relationshipId);

                    if (worksheetPart != null)
                    {

                        Worksheet worksheet = worksheetPart.Worksheet;

                        SheetData sheetData = worksheet.GetFirstChild<SheetData>();

                        string cellReference = "E14";
                        Row row = sheetData.Elements<Row>().Where(r => r.RowIndex == 14).First();

                        Cell cell = new Cell();

                        cell = row.Elements<Cell>().Where(c => c.CellReference.Value == cellReference).First();

                        //cell.CellReference = "E14";

                        cell.CellValue = new CellValue(dat.Nombres);

                        worksheetPart.Worksheet.Save();
                    }

                    spreadsheetDocument.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void txtFolioPago_TextChanged(object sender, EventArgs e)
        {
            if (txtFolioPago.Text.Trim().Length > 0)
                lblErrorReq.Visible = false;
            else
                lblErrorReq.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
