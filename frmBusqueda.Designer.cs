﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusqueda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerPrincipal = new System.Windows.Forms.SplitContainer();
            this.lblErrorGral = new System.Windows.Forms.Label();
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
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblErrorGral);
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
            // lblErrorGral
            // 
            this.lblErrorGral.AutoSize = true;
            this.lblErrorGral.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGral.Location = new System.Drawing.Point(549, 67);
            this.lblErrorGral.Name = "lblErrorGral";
            this.lblErrorGral.Size = new System.Drawing.Size(0, 13);
            this.lblErrorGral.TabIndex = 13;
            // 
            // chkFechaReg
            // 
            this.chkFechaReg.AutoSize = true;
            this.chkFechaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFechaReg.Location = new System.Drawing.Point(12, 11);
            this.chkFechaReg.Name = "chkFechaReg";
            this.chkFechaReg.Size = new System.Drawing.Size(122, 19);
            this.chkFechaReg.TabIndex = 12;
            this.chkFechaReg.Text = "Fecha registro:";
            this.chkFechaReg.UseVisualStyleBackColor = true;
            this.chkFechaReg.CheckedChanged += new System.EventHandler(this.chkFechaReg_CheckedChanged);
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterno.Location = new System.Drawing.Point(186, 64);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(120, 15);
            this.lblMaterno.TabIndex = 11;
            this.lblMaterno.Text = "Apellido materno:";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(305, 60);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(216, 21);
            this.txtMaterno.TabIndex = 10;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaterno.Location = new System.Drawing.Point(186, 39);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(116, 15);
            this.lblPaterno.TabIndex = 9;
            this.lblPaterno.Text = "Apellido paterno:";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(305, 35);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(216, 21);
            this.txtPaterno.TabIndex = 8;
            // 
            // cboEstatus
            // 
            this.cboEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(537, 35);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(114, 23);
            this.cboEstatus.TabIndex = 7;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(534, 12);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(58, 15);
            this.lblEstatus.TabIndex = 6;
            this.lblEstatus.Text = "Estatus:";
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReg.Location = new System.Drawing.Point(12, 35);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(84, 21);
            this.dtpFechaReg.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(186, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre (s):";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(305, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(724, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 66);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEstudios
            // 
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstudios.Location = new System.Drawing.Point(0, 0);
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudios.Size = new System.Drawing.Size(905, 421);
            this.dgvEstudios.TabIndex = 0;
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 510);
            this.Controls.Add(this.splitContainerPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusqueda";
            this.Text = "Búsqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblErrorGral;
    }
}

