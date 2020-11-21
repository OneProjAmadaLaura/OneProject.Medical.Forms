
namespace OneProject.Medical.Forms
{
    partial class frmBusqueda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerPrincipal = new System.Windows.Forms.SplitContainer();
            this.chkFechaReg = new System.Windows.Forms.CheckBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.dtpFechaReg = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEstudios = new System.Windows.Forms.DataGridView();
            this.bSourceDatos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).BeginInit();
            this.splitContainerPrincipal.Panel1.SuspendLayout();
            this.splitContainerPrincipal.Panel2.SuspendLayout();
            this.splitContainerPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerPrincipal
            // 
            this.splitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerPrincipal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPrincipal.Name = "splitContainerPrincipal";
            this.splitContainerPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPrincipal.Panel1
            // 
            this.splitContainerPrincipal.Panel1.Controls.Add(this.chkFechaReg);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblMaterno);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.txtMaterno);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblPaterno);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.txtPaterno);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.cboEstatus);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblEstatus);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.dtpFechaReg);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblNombre);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.txtNombre);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.btnBuscar);
            // 
            // splitContainerPrincipal.Panel2
            // 
            this.splitContainerPrincipal.Panel2.Controls.Add(this.dgvEstudios);
            this.splitContainerPrincipal.Size = new System.Drawing.Size(905, 510);
            this.splitContainerPrincipal.SplitterDistance = 85;
            this.splitContainerPrincipal.TabIndex = 0;
            // 
            // chkFechaReg
            // 
            this.chkFechaReg.AutoSize = true;
            this.chkFechaReg.Location = new System.Drawing.Point(12, 11);
            this.chkFechaReg.Name = "chkFechaReg";
            this.chkFechaReg.Size = new System.Drawing.Size(96, 17);
            this.chkFechaReg.TabIndex = 12;
            this.chkFechaReg.Text = "Fecha registro:";
            this.chkFechaReg.UseVisualStyleBackColor = true;
            this.chkFechaReg.CheckedChanged += new System.EventHandler(this.chkFechaReg_CheckedChanged);
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(217, 67);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(88, 13);
            this.lblMaterno.TabIndex = 11;
            this.lblMaterno.Text = "Apellido materno:";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(305, 61);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(216, 20);
            this.txtMaterno.TabIndex = 10;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(217, 42);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(86, 13);
            this.lblPaterno.TabIndex = 9;
            this.lblPaterno.Text = "Apellido paterno:";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(305, 36);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(216, 20);
            this.txtPaterno.TabIndex = 8;
            // 
            // cboEstatus
            // 
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(598, 39);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(100, 21);
            this.cboEstatus.TabIndex = 7;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(549, 42);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 6;
            this.lblEstatus.Text = "Estatus:";
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReg.Location = new System.Drawing.Point(12, 35);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(84, 20);
            this.dtpFechaReg.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(217, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre (s):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(305, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(722, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEstudios
            // 
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstudios.Location = new System.Drawing.Point(0, 0);
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.Size = new System.Drawing.Size(905, 421);
            this.dgvEstudios.TabIndex = 0;
            this.dgvEstudios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudios_CellContentClick);
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 510);
            this.Controls.Add(this.splitContainerPrincipal);
            this.Name = "frmBusqueda";
            this.Text = "Búsqueda";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.splitContainerPrincipal.Panel1.ResumeLayout(false);
            this.splitContainerPrincipal.Panel1.PerformLayout();
            this.splitContainerPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).EndInit();
            this.splitContainerPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerPrincipal;
        private System.Windows.Forms.DataGridView dgvEstudios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DateTimePicker dtpFechaReg;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.CheckBox chkFechaReg;
        private System.Windows.Forms.BindingSource bSourceDatos;
    }
}

