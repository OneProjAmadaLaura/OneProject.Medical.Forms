
namespace OneProject.Medical.Forms
{
    partial class frmDetalleEstudio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleEstudio));
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnRegistrarPrueba = new System.Windows.Forms.Button();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblMaternoV = new System.Windows.Forms.Label();
            this.lblPaternoV = new System.Windows.Forms.Label();
            this.lblNombreV = new System.Windows.Forms.Label();
            this.lblFolioPago = new System.Windows.Forms.Label();
            this.lblIdentificadorV = new System.Windows.Forms.Label();
            this.txtFolioPago = new System.Windows.Forms.TextBox();
            this.lblReqFolio = new System.Windows.Forms.Label();
            this.lblErrorReq = new System.Windows.Forms.Label();
            this.lblErrorGeneral = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterno.Location = new System.Drawing.Point(33, 100);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(135, 17);
            this.lblMaterno.TabIndex = 17;
            this.lblMaterno.Text = "Apellido materno:";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaterno.Location = new System.Drawing.Point(33, 75);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(132, 17);
            this.lblPaterno.TabIndex = 15;
            this.lblPaterno.Text = "Apellido paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 17);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre (s):";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(175, 185);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 66);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Enabled = false;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPago.Image")));
            this.btnRegistrarPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrarPago.Location = new System.Drawing.Point(36, 185);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(135, 66);
            this.btnRegistrarPago.TabIndex = 1;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // btnRegistrarPrueba
            // 
            this.btnRegistrarPrueba.Enabled = false;
            this.btnRegistrarPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrueba.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPrueba.Image")));
            this.btnRegistrarPrueba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrarPrueba.Location = new System.Drawing.Point(316, 185);
            this.btnRegistrarPrueba.Name = "btnRegistrarPrueba";
            this.btnRegistrarPrueba.Size = new System.Drawing.Size(135, 66);
            this.btnRegistrarPrueba.TabIndex = 3;
            this.btnRegistrarPrueba.Text = "Registrar prueba";
            this.btnRegistrarPrueba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarPrueba.UseVisualStyleBackColor = true;
            this.btnRegistrarPrueba.Click += new System.EventHandler(this.btnRegistrarPrueba_Click);
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador.Location = new System.Drawing.Point(33, 25);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(117, 17);
            this.lblIdentificador.TabIndex = 21;
            this.lblIdentificador.Text = "Indentificador: ";
            // 
            // lblMaternoV
            // 
            this.lblMaternoV.AutoSize = true;
            this.lblMaternoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaternoV.Location = new System.Drawing.Point(168, 100);
            this.lblMaternoV.Name = "lblMaternoV";
            this.lblMaternoV.Size = new System.Drawing.Size(83, 17);
            this.lblMaternoV.TabIndex = 24;
            this.lblMaternoV.Text = "lblMaternoV";
            // 
            // lblPaternoV
            // 
            this.lblPaternoV.AutoSize = true;
            this.lblPaternoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaternoV.Location = new System.Drawing.Point(168, 75);
            this.lblPaternoV.Name = "lblPaternoV";
            this.lblPaternoV.Size = new System.Drawing.Size(81, 17);
            this.lblPaternoV.TabIndex = 23;
            this.lblPaternoV.Text = "lblPaternoV";
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreV.Location = new System.Drawing.Point(168, 50);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(81, 17);
            this.lblNombreV.TabIndex = 22;
            this.lblNombreV.Text = "lblNombreV";
            // 
            // lblFolioPago
            // 
            this.lblFolioPago.AutoSize = true;
            this.lblFolioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioPago.Location = new System.Drawing.Point(33, 125);
            this.lblFolioPago.Name = "lblFolioPago";
            this.lblFolioPago.Size = new System.Drawing.Size(89, 17);
            this.lblFolioPago.TabIndex = 25;
            this.lblFolioPago.Text = "Folio pago:";
            // 
            // lblIdentificadorV
            // 
            this.lblIdentificadorV.AutoSize = true;
            this.lblIdentificadorV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificadorV.Location = new System.Drawing.Point(168, 25);
            this.lblIdentificadorV.Name = "lblIdentificadorV";
            this.lblIdentificadorV.Size = new System.Drawing.Size(108, 17);
            this.lblIdentificadorV.TabIndex = 26;
            this.lblIdentificadorV.Text = "lblIdentificadorV";
            // 
            // txtFolioPago
            // 
            this.txtFolioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioPago.Location = new System.Drawing.Point(171, 122);
            this.txtFolioPago.MaxLength = 20;
            this.txtFolioPago.Name = "txtFolioPago";
            this.txtFolioPago.Size = new System.Drawing.Size(225, 23);
            this.txtFolioPago.TabIndex = 0;
            this.txtFolioPago.TextChanged += new System.EventHandler(this.txtFolioPago_TextChanged);
            // 
            // lblReqFolio
            // 
            this.lblReqFolio.AutoSize = true;
            this.lblReqFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqFolio.Location = new System.Drawing.Point(154, 125);
            this.lblReqFolio.Name = "lblReqFolio";
            this.lblReqFolio.Size = new System.Drawing.Size(14, 17);
            this.lblReqFolio.TabIndex = 29;
            this.lblReqFolio.Text = "*";
            this.lblReqFolio.Visible = false;
            // 
            // lblErrorReq
            // 
            this.lblErrorReq.AutoSize = true;
            this.lblErrorReq.ForeColor = System.Drawing.Color.Red;
            this.lblErrorReq.Location = new System.Drawing.Point(171, 148);
            this.lblErrorReq.Name = "lblErrorReq";
            this.lblErrorReq.Size = new System.Drawing.Size(113, 13);
            this.lblErrorReq.TabIndex = 30;
            this.lblErrorReq.Text = "Este dato es requerido";
            this.lblErrorReq.Visible = false;
            // 
            // lblErrorGeneral
            // 
            this.lblErrorGeneral.AutoSize = true;
            this.lblErrorGeneral.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGeneral.Location = new System.Drawing.Point(37, 260);
            this.lblErrorGeneral.Name = "lblErrorGeneral";
            this.lblErrorGeneral.Size = new System.Drawing.Size(0, 13);
            this.lblErrorGeneral.TabIndex = 31;
            this.lblErrorGeneral.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(455, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 66);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDetalleEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 278);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblErrorGeneral);
            this.Controls.Add(this.lblErrorReq);
            this.Controls.Add(this.lblReqFolio);
            this.Controls.Add(this.txtFolioPago);
            this.Controls.Add(this.lblIdentificadorV);
            this.Controls.Add(this.lblFolioPago);
            this.Controls.Add(this.lblMaternoV);
            this.Controls.Add(this.lblPaternoV);
            this.Controls.Add(this.lblNombreV);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnRegistrarPrueba);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleEstudio";
            this.Text = "Estudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnRegistrarPrueba;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblMaternoV;
        private System.Windows.Forms.Label lblPaternoV;
        private System.Windows.Forms.Label lblNombreV;
        private System.Windows.Forms.Label lblFolioPago;
        private System.Windows.Forms.Label lblIdentificadorV;
        private System.Windows.Forms.TextBox txtFolioPago;
        private System.Windows.Forms.Label lblReqFolio;
        private System.Windows.Forms.Label lblErrorReq;
        private System.Windows.Forms.Label lblErrorGeneral;
        private System.Windows.Forms.Button btnCancelar;
    }
}