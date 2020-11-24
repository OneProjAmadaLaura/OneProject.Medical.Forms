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
using Excel = Microsoft.Office.Interop.Excel;

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

            try
            {
                lblIdentificadorV.Text = string.Empty;
                lblNombreV.Text = string.Empty;
                lblPaternoV.Text = string.Empty;
                lblMaternoV.Text = string.Empty;

                cargaDatos();
            }
            catch (Exception ex)
            {
                lblErrorGeneral.Text = ex.Message;

            }
        }

        private void cargaDatos()
        {
            try
            {
                btnRegistrarPago.Enabled = false;
                btnImprimir.Enabled = false;
                btnRegistrarPrueba.Enabled = false;

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
                    btnRegistrarPago.Enabled = true;

                }
                else if (dat.FechaPago != null && dat.FechaImpresion is null)
                {
                    // Pagado
                    txtFolioPago.Enabled = false;
                    txtFolioPago.Text = dat.FolioPago;

                    btnImprimir.Enabled = true;

                }
                else if (dat.FechaImpresion != null && dat.FechaPrueba is null)
                {
                    // Impreso

                    txtFolioPago.Enabled = false;
                    txtFolioPago.Text = dat.FolioPago;

                    btnImprimir.Enabled = true;
                    btnRegistrarPrueba.Enabled = true;
                }
                else if (dat.FechaPrueba != null)
                {
                    // Prueba tomada

                    txtFolioPago.Enabled = false;
                    txtFolioPago.Text = dat.FolioPago;

                }
            }

            catch (Exception ex)
            {
                throw;

            }

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFolioPago.Text.Trim().Length > 0)
                {

                    DialogResult dr = MessageBox.Show("¿Está seguro que quiere registrar el pago?", "Consulta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
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
                            cargaDatos();
                        }
                    }
                }
                else
                {
                    lblErrorReq.Visible = true;
                }
            }

            catch (Exception ex)
            {
                lblErrorGeneral.Text = ex.Message;

            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            try
            {

                DialogResult dr = MessageBox.Show("¿Está seguro que quiere imprimir el estudio?", "Consulta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    Cursor.Current = Cursors.WaitCursor;

                    // Ruta de xls
                    string fuentePath = ConfigurationManager.AppSettings["dirFormato"];
                    string destinoPath = ConfigurationManager.AppSettings["dirSalidas"];
                    string nombreArchivo = ConfigurationManager.AppSettings["formato"];

                    string nuevoArchivo = nombreArchivo + "_" + dat.IdPersona + "_" + DateTime.Now.ToString("yyyyMMdd_hhmmss");
                    string ext = ".xlsx";

                    string current = Environment.CurrentDirectory;

                    // Use Path class to manipulate file and directory paths.
                    string workbookPath = System.IO.Path.Combine(fuentePath, nombreArchivo + ext);
                    string destinoFile = System.IO.Path.Combine(destinoPath, nuevoArchivo + ext);



                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false;


                    // open an existing workbook
                    //string workbookPath = @"C:\Temp\ecov.xlsx";
                    Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath,
                        0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                        true, false, 0, true, false, false);

                    // get all sheets in workbook
                    Excel.Sheets excelSheets = excelWorkbook.Worksheets;

                    // get some sheet
                    string currentSheet = "Estudio de caso";
                    Excel.Worksheet excelWorksheet =
                        (Excel.Worksheet)excelSheets.get_Item(currentSheet);


                    DatosNotificante notificante;
                    DatosGenerales generales;
                    Antecedentes antecedentes;
                    IEnumerable<Viaje> viajes;
                    DatosClinicos clinicos;
                    DatosUnidadMedica unidadMedica;
                    Tratamiento tratamiento;
                    Laboratorio laboratorio;
                    Evolucion evolucion;
                    IEnumerable<Contactos> contactos;


                    using (var context = new EstudioEpidemiologicoEntities())
                    {
                        notificante = context.DatosNotificante.Where(l => l.IdUnidadNotificante == 1).ToList().First();
                        generales = context.DatosGenerales.Where(l => l.IdPersona == dat.IdPersona).ToList().First();
                        antecedentes = context.Antecedentes.Where(l => l.IdPersona == dat.IdPersona).ToList().First();
                        viajes = context.Viaje.Where(l => l.IdPersona == dat.IdPersona).ToList();
                        clinicos = context.DatosClinicos.Where(l => l.IdPersona == dat.IdPersona).ToList().First();
                        unidadMedica = context.DatosUnidadMedica.Where(l => l.IdPersona == dat.IdPersona).ToList().First();
                        tratamiento = context.Tratamiento.Where(l => l.IdPersona == dat.IdPersona).ToList().First();
                        laboratorio = context.Laboratorio.Where(l => l.IdPersona == dat.IdPersona).ToList().First();
                        evolucion = context.Evolucion.Where(l => l.IdPersona == dat.IdPersona).ToList().First();
                        contactos = context.Contactos.Where(l => l.IdPersona == dat.IdPersona).ToList();

                    }


                    //DATOS DE LA UNIDAD NOTIFICANTE
                    excelWorksheet.Range["C7"].Value = notificante.Entidad;
                    excelWorksheet.Range["F7"].Value = notificante.Jurisdiccion;
                    excelWorksheet.Range["I7"].Value = notificante.Municipio;
                    excelWorksheet.Range["P7"].Value = notificante.NombreUnidadMedica;
                    excelWorksheet.Range["C9"].Value = notificante.Institucion;
                    excelWorksheet.Range["I9"].Value = notificante.CLUES;


                    //DATOS GENERALES

                    excelWorksheet.Range["E11"].Value = generales.FechaIngresoUnidad;
                    excelWorksheet.Range["E14"].Value = generales.PrimerApellido;
                    excelWorksheet.Range["k14"].Value = generales.SegundoApellido;
                    excelWorksheet.Range["Q14"].Value = generales.Nombres;
                    excelWorksheet.Range["E16"].Value = generales.NacimientoDía;
                    excelWorksheet.Range["G16"].Value = generales.NacimientoMes;
                    excelWorksheet.Range["I16"].Value = generales.NacimientoAnio;
                    excelWorksheet.Range["K16"].Value = generales.Edad;
                    excelWorksheet.Range["N16"].Value = generales.CURP;

                    if (generales.Sexo.Equals("H"))
                        excelWorksheet.Range["D18"].Value = "X";
                    else
                        excelWorksheet.Range["D19"].Value = "X";


                    if (!generales.Embarazada.Equals(null))
                        if (generales.Embarazada.Value)
                            excelWorksheet.Range["G19"].Value = "X";
                        else
                            excelWorksheet.Range["H19"].Value = "X";

                    excelWorksheet.Range["K19"].Value = generales.MesesEmbarazo;


                    if (!generales.EnPeriodoPuerperio.Equals(null))
                        if (generales.EnPeriodoPuerperio.Value)
                            excelWorksheet.Range["P19"].Value = "X";
                        else
                            excelWorksheet.Range["Q19"].Value = "X";



                    excelWorksheet.Range["S19"].Value = generales.DiasPuerperio;
                    //Nacionalidad

                    if (generales.Nacionalidad.Equals("M"))
                        excelWorksheet.Range["D21"].Value = "X";
                    else
                        excelWorksheet.Range["F21"].Value = "X";


                    excelWorksheet.Range["F21"].Value = generales.PaisOrigen;
                    excelWorksheet.Range["R21"].Value = generales.NoExpedienteSeguridadSocial;
                    excelWorksheet.Range["E23"].Value = generales.EntidadNacimiento;
                    excelWorksheet.Range["O23"].Value = generales.EntidadDelegacionResidencia;
                    excelWorksheet.Range["E25"].Value = generales.MunicipioResidencia;
                    excelWorksheet.Range["M25"].Value = generales.Localidad;
                    excelWorksheet.Range["E27"].Value = generales.Calle;
                    excelWorksheet.Range["M27"].Value = generales.NoExterno;
                    excelWorksheet.Range["R27"].Value = generales.NoInterno;
                    excelWorksheet.Range["E29"].Value = generales.EntreCalles;
                    excelWorksheet.Range["N29"].Value = generales.YCalle;
                    excelWorksheet.Range["E31"].Value = generales.Colonia;
                    excelWorksheet.Range["J31"].Value = generales.CP;
                    excelWorksheet.Range["P31"].Value = generales.Telefono;
                    //SeReconoceIndigena
                    if (!generales.SeReconoceIndigena.Equals(null))
                        if (generales.SeReconoceIndigena)
                            excelWorksheet.Range["F33"].Value = "X";
                        else
                            excelWorksheet.Range["G33"].Value = "X";


                    //HablaAlgunaLenguaIndigena

                    if (!generales.HablaAlgunaLenguaIndigena.Equals(null))
                        if (generales.HablaAlgunaLenguaIndigena)
                            excelWorksheet.Range["N33"].Value = "X";
                        else
                            excelWorksheet.Range["O33"].Value = "X";


                    excelWorksheet.Range["D36"].Value = generales.Ocupacion;
                    //EsMigrante
                    if (!generales.EsMigrante.Equals(null))
                        if (generales.EsMigrante)
                            excelWorksheet.Range["N36"].Value = "X";
                        else
                            excelWorksheet.Range["O36"].Value = "X";





                    ///ANTECEDENTES EPIDEMIOLÓGICOS

                    if (!antecedentes.ViajoChina14dPrevInicioSintomas.Equals(null))
                        if (antecedentes.ViajoChina14dPrevInicioSintomas)
                            excelWorksheet.Range["J39"].Value = "X";
                        else
                            excelWorksheet.Range["K39"].Value = "X";

                    if (!antecedentes.ResidenteChina.Equals(null))
                        if (antecedentes.ResidenteChina)
                            excelWorksheet.Range["R39"].Value = "X";
                        else
                            excelWorksheet.Range["S39"].Value = "X";

                    excelWorksheet.Range["F43"].Value = antecedentes.FechaViajeChina;
                    excelWorksheet.Range["M43"].Value = antecedentes.AerolineaVueloLlegadaMexico;
                    excelWorksheet.Range["E46"].Value = antecedentes.FechaLlegadaMexico;


                    if (!antecedentes.ContactoPersonaSintomasRespiratorios.Equals(null))
                        if (antecedentes.ContactoPersonaSintomasRespiratorios.Equals("S"))
                            excelWorksheet.Range["I49"].Value = "X";
                        else if (antecedentes.ContactoPersonaSintomasRespiratorios.Equals("N"))
                            excelWorksheet.Range["J49"].Value = "X";
                        else
                            excelWorksheet.Range["K49"].Value = "X";

                    excelWorksheet.Range["G52"].Value = antecedentes.LugarContactoPersonas;

                    if (!antecedentes.ContactoAnimales.Equals(null))
                        if (antecedentes.ContactoAnimales)
                            excelWorksheet.Range["F55"].Value = "X";
                        else
                            excelWorksheet.Range["G55"].Value = "X";

                    excelWorksheet.Range["J55"].Value = antecedentes.CualAnimal;
                    //Validar marcado
                    excelWorksheet.Range["C58"].Value = antecedentes.TipoContactoAnimal;
                    if (!antecedentes.VisitoMercadoVentaAnimales.Equals(null))
                        if (antecedentes.VisitoMercadoVentaAnimales)
                            excelWorksheet.Range["H60"].Value = "X";
                        else
                            excelWorksheet.Range["I60"].Value = "X";


                    excelWorksheet.Range["K60"].Value = antecedentes.LugarMercadoVentaAnimales;
                    excelWorksheet.Range["Q60"].Value = antecedentes.FechaVisitaMercado;

                    if (!antecedentes.Ult14dContacCercanoPersSospCoV.Equals(null))
                        if (antecedentes.Ult14dContacCercanoPersSospCoV)
                            excelWorksheet.Range["P71"].Value = "X";
                        else
                            excelWorksheet.Range["R71"].Value = "X";

                    if (!antecedentes.Ult14dContacCercanoPersCorfiLabCoV.Equals(null))
                        if (antecedentes.Ult14dContacCercanoPersCorfiLabCoV)
                            excelWorksheet.Range["P73"].Value = "X";
                        else
                            excelWorksheet.Range["R73"].Value = "X";

                    if (!antecedentes.ContacPersViajChina14dPrevIniSintomas.Equals(null))
                        if (antecedentes.ContacPersViajChina14dPrevIniSintomas)
                            excelWorksheet.Range["M76"].Value = "X";
                        else
                            excelWorksheet.Range["N76"].Value = "X";



                    //VIAJES
                    int numCeldaViaje = 65;
                    foreach (Viaje viaje in viajes)
                    {

                        excelWorksheet.Range["F" + numCeldaViaje].Value = viaje.Pais;
                        excelWorksheet.Range["H" + numCeldaViaje].Value = viaje.Ciudad;
                        excelWorksheet.Range["K" + numCeldaViaje].Value = viaje.FechaLlegada;
                        excelWorksheet.Range["O" + numCeldaViaje].Value = viaje.FechaSalida;
                        excelWorksheet.Range["R" + numCeldaViaje].Value = viaje.AerolineaVuelo;
                        numCeldaViaje++;
                    }



                    //DATOS CLINICOS
                    excelWorksheet.Range["C7"].Value = clinicos.IdPersona;
                    excelWorksheet.Range["C7"].Value = clinicos.FechaInicioSintomas;


                    writeBool(excelWorksheet, "D85", "E85", clinicos.Fiebre);
                    writeBool(excelWorksheet, "D86", "E86", clinicos.Tos);
                    writeBool(excelWorksheet, "D87", "E87", clinicos.DolorToracico);
                    writeBool(excelWorksheet, "D88", "E88", clinicos.DificultadRespiratoria);
                    writeBool(excelWorksheet, "K85", "L85", clinicos.Cefalea);
                    writeBool(excelWorksheet, "K86", "L86", clinicos.Irritabilidad);
                    writeBool(excelWorksheet, "K87", "L87", clinicos.Diarrea);
                    writeBool(excelWorksheet, "K88", "L88", clinicos.Vomito);
                    writeBool(excelWorksheet, "K89", "L89", clinicos.Calosfrios);
                    writeBool(excelWorksheet, "K90", "L90", clinicos.DolorAbdominal);
                    writeBool(excelWorksheet, "K91", "L91", clinicos.Mialgias);
                    writeBool(excelWorksheet, "K92", "L92", clinicos.Artralgias);
                    writeBool(excelWorksheet, "K93", "L93", clinicos.AtaqueAlEdoGral);
                    writeBool(excelWorksheet, "K94", "L94", clinicos.Rinorrea);
                    writeBool(excelWorksheet, "K95", "L95", clinicos.Polipnea);
                    writeBool(excelWorksheet, "K96", "L96", clinicos.Odinofagia);
                    writeBool(excelWorksheet, "K97", "L97", clinicos.Conjuntivitis);
                    writeBool(excelWorksheet, "K98", "L98", clinicos.Cianosis);
                    writeBool(excelWorksheet, "K99", "L99", clinicos.Convulsiones);
                    excelWorksheet.Range["K100"].Value = clinicos.OtroSintoma;
                    writeBool(excelWorksheet, "R83", "S83", clinicos.Diabetes);
                    writeBool(excelWorksheet, "R84", "S84", clinicos.EPOC);
                    writeBool(excelWorksheet, "R85", "S85", clinicos.Asma);
                    writeBool(excelWorksheet, "R86", "S86", clinicos.Inmunosupresion);
                    writeBool(excelWorksheet, "R87", "S87", clinicos.Hipertension);
                    writeBool(excelWorksheet, "R88", "S88", clinicos.VihSida);
                    writeBool(excelWorksheet, "R89", "S89", clinicos.EnfermedadCardio);
                    writeBool(excelWorksheet, "R90", "S90", clinicos.Obesidad);
                    writeBool(excelWorksheet, "R91", "S91", clinicos.InsuficienciaRenalCronica);
                    writeBool(excelWorksheet, "R92", "S92", clinicos.InsuficienciaHepaticaCronica);
                    writeBool(excelWorksheet, "R93", "S93", clinicos.Tabaquismo);
                    excelWorksheet.Range["O94"].Value = clinicos.OtroCoMorbilidad;


                    //DATOS DE LA UNIDAD MÉDICA

                    excelWorksheet.Range["E104"].Value = unidadMedica.ServicioIngreso;


                    if (unidadMedica.TipPaciente.Equals("A"))
                        excelWorksheet.Range["O104"].Value = "X";
                    else if (unidadMedica.TipPaciente.Equals("H"))
                        excelWorksheet.Range["R104"].Value = "X";


                    excelWorksheet.Range["P118"].Value = unidadMedica.FechaIngresoUnidad;
                    writeBool(excelWorksheet, "P106", "R106", unidadMedica.CasoIngresadoUCI);
                    writeBool(excelWorksheet, "P108", "R108", unidadMedica.CasoIntubado);
                    writeBool(excelWorksheet, "R110", "S110", unidadMedica.CasoDiagnostNeumoniaClinica);
                    writeBool(excelWorksheet, "R112", "S112", unidadMedica.CasoDiagnostNeumoniaRadiológica);

                    //TRATAMIENTO


                    if (!tratamiento.RecibioTrataAntipireticoAnalgesico.Equals(null))
                        if (tratamiento.RecibioTrataAntipireticoAnalgesico.Equals("S"))
                            excelWorksheet.Range["K116"].Value = "X";
                        else if (tratamiento.RecibioTrataAntipireticoAnalgesico.Equals("N"))
                            excelWorksheet.Range["L116"].Value = "X";
                        else
                            excelWorksheet.Range["M116"].Value = "X";


                    excelWorksheet.Range["C7"].Value = tratamiento.FechaInicioTrataAntipireticoAnalgesico;


                    excelWorksheet.Range["F121"].Value = tratamiento.Paracetamol ? "X" : "";
                    excelWorksheet.Range["F122"].Value = tratamiento.Ibuprofeno ? "X" : "";
                    excelWorksheet.Range["F123"].Value = tratamiento.AcidoAcetilsalicilico ? "X" : "";
                    excelWorksheet.Range["F124"].Value = tratamiento.ClonixinatoLisina ? "X" : "";
                    excelWorksheet.Range["K121"].Value = tratamiento.Naproxeno ? "X" : "";
                    excelWorksheet.Range["K122"].Value = tratamiento.Proxicam ? "X" : "";
                    excelWorksheet.Range["K123"].Value = tratamiento.MetamizolSodico ? "X" : "";
                    excelWorksheet.Range["Q121"].Value = tratamiento.Diclofenaco ? "X" : "";
                    excelWorksheet.Range["Q122"].Value = tratamiento.Ketorolaco ? "X" : "";
                    excelWorksheet.Range["Q123"].Value = tratamiento.OtroAntipireticoAnalgesico.Value ? "X" : "";
                    if (!tratamiento.RecibioTrataAntiviral.Equals(null))
                        if (tratamiento.RecibioTrataAntiviral.Equals("S"))
                            excelWorksheet.Range["K126"].Value = "X";
                        else if (tratamiento.RecibioTrataAntiviral.Equals("N"))
                            excelWorksheet.Range["L126"].Value = "X";
                        else
                            excelWorksheet.Range["M126"].Value = "X";

                    excelWorksheet.Range["P128"].Value = tratamiento.FechaInicioTrataAntiviral;
                    excelWorksheet.Range["F131"].Value = tratamiento.Amantadina ? "X" : "";
                    excelWorksheet.Range["F132"].Value = tratamiento.Rimantadina ? "X" : "";
                    excelWorksheet.Range["F133"].Value = tratamiento.Oseltamivir ? "X" : "";
                    excelWorksheet.Range["F133"].Value = tratamiento.Zanamivir ? "X" : "";
                    excelWorksheet.Range["J132"].Value = tratamiento.Peramivir ? "X" : "";
                    excelWorksheet.Range["O131"].Value = tratamiento.Ribavirina ? "X" : "";
                    excelWorksheet.Range["O132"].Value = tratamiento.OtroAntiviral;
                    if (!tratamiento.RecibioTrataAntibiotico.Equals(null))
                        if (tratamiento.RecibioTrataAntibiotico.Equals("S"))
                            excelWorksheet.Range["K135"].Value = "X";
                        else if (tratamiento.RecibioTrataAntibiotico.Equals("N"))
                            excelWorksheet.Range["L135"].Value = "X";
                        else
                            excelWorksheet.Range["M135"].Value = "X";

                    excelWorksheet.Range["P137"].Value = tratamiento.FechaInicioTrataAntibiotico;
                    excelWorksheet.Range["F140"].Value = tratamiento.Penicilina ? "X" : "";
                    excelWorksheet.Range["F141"].Value = tratamiento.Dicloxacilina ? "X" : "";
                    excelWorksheet.Range["F142"].Value = tratamiento.Ampicilina ? "X" : "";
                    excelWorksheet.Range["F143"].Value = tratamiento.Amikacina ? "X" : "";
                    excelWorksheet.Range["F144"].Value = tratamiento.Doxiciclina ? "X" : "";
                    excelWorksheet.Range["F145"].Value = tratamiento.Cefalosporina ? "X" : "";
                    excelWorksheet.Range["J140"].Value = tratamiento.Clindamicina ? "X" : "";
                    excelWorksheet.Range["J141"].Value = tratamiento.Claritromicina ? "X" : "";
                    excelWorksheet.Range["J142"].Value = tratamiento.Ciprofloxacino ? "X" : "";
                    excelWorksheet.Range["J143"].Value = tratamiento.Meropenem ? "X" : "";
                    excelWorksheet.Range["J144"].Value = tratamiento.Vancomicina ? "X" : "";
                    excelWorksheet.Range["Q140"].Value = tratamiento.AmoxicilinaAcClauvulanico ? "X" : "";
                    excelWorksheet.Range["Q141"].Value = tratamiento.OtrosAntibioticos.Value ? "X" : "";

                    //LABORATORIO

                    writeBool(excelWorksheet, "E149", "F149", laboratorio.SeTomoMuestraPaciente);

                    excelWorksheet.Range["M149"].Value = laboratorio.LaboratorioDiagnostico;
                    excelWorksheet.Range["G154"].Value = laboratorio.ExudadoFaringeo.Value ? "X" : "";
                    excelWorksheet.Range["G155"].Value = laboratorio.ExudadoNasofaringeo.Value ? "X" : "";
                    excelWorksheet.Range["N154"].Value = laboratorio.LavadoBronquial.Value ? "X" : "";
                    excelWorksheet.Range["N155"].Value = laboratorio.BiopsiaPulmon.Value ? "X" : "";
                    excelWorksheet.Range["E157"].Value = laboratorio.FechaTomaMuestra;
                    excelWorksheet.Range["O157"].Value = laboratorio.FechaEnvioMuestra;
                    excelWorksheet.Range["E159"].Value = laboratorio.FechaRecepcionMuestra;
                    excelWorksheet.Range["L159"].Value = laboratorio.FechaResultado;
                    excelWorksheet.Range["R159"].Value = laboratorio.Resultado;

                    //EVOLUCIÓN

                    if (!evolucion.Evolucion1.Equals(0))
                        excelWorksheet.Range["D163"].Value = evolucion.Evolucion1;

                    excelWorksheet.Range["E165"].Value = evolucion.FechaEgreso;
                    excelWorksheet.Range["E167"].Value = evolucion.FechaDefunción;
                    excelWorksheet.Range["H169"].Value = evolucion.FolioCertificadoDefunción;
                    writeBool(excelWorksheet, "O169", "P169", evolucion.Defuncion2019nCoV);


                    //CONTACTOS

                    int numCeldaContacto = 175;
                    foreach (Contactos contacto in contactos)
                    {

                        excelWorksheet.Range["B" + numCeldaContacto].Value = contacto.NombreCompleto;

                        if (contacto.Sexo.Equals("F"))
                            excelWorksheet.Range["F" + numCeldaContacto].Value = contacto.Sexo;
                        else if (contacto.Sexo.Equals("M"))
                            excelWorksheet.Range["G" + numCeldaContacto].Value = contacto.Sexo;

                        excelWorksheet.Range["H" + numCeldaContacto].Value = contacto.Edad;
                        excelWorksheet.Range["J" + numCeldaContacto].Value = contacto.TipoContactoIDoED;
                        excelWorksheet.Range["K" + numCeldaContacto].Value = contacto.CorreoElectronico;
                        excelWorksheet.Range["M" + numCeldaContacto].Value = contacto.SignosSintomas;
                        excelWorksheet.Range["R" + numCeldaContacto].Value = contacto.Observaciones;
                        numCeldaContacto++;
                    }


                    excelWorksheet.PrintOutEx(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    // excelWorkbook.SaveAs(@"C:\Temp\ecov1.xlsx");
                    excelWorkbook.SaveAs(destinoFile);

                    excelApp.Quit();


                    DatosGenerales oTabla = null;

                    using (EstudioEpidemiologicoEntities tablas = new EstudioEpidemiologicoEntities())
                    {
                        oTabla = tablas.DatosGenerales.Find(dat.IdPersona);

                        oTabla.FechaImpresion = DateTime.Now;

                        tablas.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        tablas.SaveChanges();
                        cargaDatos();
                    }

                }
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error en llenado del formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }



            void writeBool(Excel.Worksheet Hoja, string CeldaSi, string CeldaNo, bool? Valor)
            {

                if (Valor.Value)
                    Hoja.Range[CeldaSi].Value = "X";
                else
                    Hoja.Range[CeldaNo].Value = "X";
            }
        }

        private void btnRegistrarPrueba_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("¿Está seguro que quiere registrar la prueba?", "Consulta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
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

            }
            catch (Exception ex)
            {
                lblErrorGeneral.Text = ex.Message;

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
                throw;
            }

        }

        private void txtFolioPago_TextChanged(object sender, EventArgs e)
        {
            if (txtFolioPago.Text.Trim().Length > 0)
                lblErrorReq.Visible = false;
            else
                lblErrorReq.Visible = true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


