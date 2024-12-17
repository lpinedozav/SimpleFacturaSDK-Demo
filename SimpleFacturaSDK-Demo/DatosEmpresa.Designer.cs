namespace SimpleFacturaSDK_Demo
{
    partial class DatosEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEmpresa));
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.RutCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroResol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadSII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutRepresentanteLegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaResol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActividadesEconomicas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.generarDatosEmpresa = new System.Windows.Forms.Button();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(82, 16);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(163, 20);
            this.textRutEmisor.TabIndex = 15;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rut Emisor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(14, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 117);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado Datos Empresa";
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.AllowUserToResizeColumns = false;
            this.gridResultados.AllowUserToResizeRows = false;
            this.gridResultados.ColumnHeadersHeight = 29;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RutCliente,
            this.razonSocial,
            this.Giro,
            this.dirPart,
            this.DirFact,
            this.correoPar,
            this.correoFact,
            this.Ciudad,
            this.Comuna,
            this.nroResol,
            this.unidadSII,
            this.rutRepresentanteLegal,
            this.fechaResol,
            this.ambiente,
            this.telefono,
            this.colActividadesEconomicas});
            this.gridResultados.Location = new System.Drawing.Point(5, 13);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 20;
            this.gridResultados.Size = new System.Drawing.Size(579, 98);
            this.gridResultados.TabIndex = 0;
            // 
            // RutCliente
            // 
            this.RutCliente.DataPropertyName = "Rut";
            this.RutCliente.HeaderText = "Rut";
            this.RutCliente.MinimumWidth = 6;
            this.RutCliente.Name = "RutCliente";
            this.RutCliente.ReadOnly = true;
            this.RutCliente.Width = 75;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 187;
            // 
            // Giro
            // 
            this.Giro.DataPropertyName = "Giro";
            dataGridViewCellStyle1.Format = "N1";
            this.Giro.DefaultCellStyle = dataGridViewCellStyle1;
            this.Giro.HeaderText = "Giro";
            this.Giro.MinimumWidth = 6;
            this.Giro.Name = "Giro";
            this.Giro.ReadOnly = true;
            this.Giro.Width = 187;
            // 
            // dirPart
            // 
            this.dirPart.DataPropertyName = "DirPart";
            dataGridViewCellStyle2.Format = "N0";
            this.dirPart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dirPart.HeaderText = "Dirección Part";
            this.dirPart.MinimumWidth = 6;
            this.dirPart.Name = "dirPart";
            this.dirPart.ReadOnly = true;
            this.dirPart.Width = 105;
            // 
            // DirFact
            // 
            this.DirFact.DataPropertyName = "DirFact";
            this.DirFact.HeaderText = "Dirección Fact";
            this.DirFact.MinimumWidth = 6;
            this.DirFact.Name = "DirFact";
            this.DirFact.ReadOnly = true;
            this.DirFact.Width = 105;
            // 
            // correoPar
            // 
            this.correoPar.DataPropertyName = "correoPar";
            this.correoPar.HeaderText = "Correo Part";
            this.correoPar.MinimumWidth = 6;
            this.correoPar.Name = "correoPar";
            this.correoPar.ReadOnly = true;
            this.correoPar.Width = 105;
            // 
            // correoFact
            // 
            this.correoFact.DataPropertyName = "CorreoFact";
            dataGridViewCellStyle3.Format = "N0";
            this.correoFact.DefaultCellStyle = dataGridViewCellStyle3;
            this.correoFact.HeaderText = "Correo Fact";
            this.correoFact.MinimumWidth = 6;
            this.correoFact.Name = "correoFact";
            this.correoFact.ReadOnly = true;
            this.correoFact.Width = 105;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 125;
            // 
            // Comuna
            // 
            this.Comuna.DataPropertyName = "Comuna";
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.MinimumWidth = 6;
            this.Comuna.Name = "Comuna";
            this.Comuna.ReadOnly = true;
            this.Comuna.Width = 125;
            // 
            // nroResol
            // 
            this.nroResol.DataPropertyName = "nroResol";
            this.nroResol.FillWeight = 70F;
            this.nroResol.HeaderText = "Nro Resol.";
            this.nroResol.MinimumWidth = 6;
            this.nroResol.Name = "nroResol";
            this.nroResol.ReadOnly = true;
            this.nroResol.Width = 65;
            // 
            // unidadSII
            // 
            this.unidadSII.DataPropertyName = "unidadSII";
            this.unidadSII.HeaderText = "Unidad SII";
            this.unidadSII.MinimumWidth = 6;
            this.unidadSII.Name = "unidadSII";
            this.unidadSII.ReadOnly = true;
            this.unidadSII.Width = 80;
            // 
            // rutRepresentanteLegal
            // 
            this.rutRepresentanteLegal.DataPropertyName = "rutRepresentanteLegal";
            this.rutRepresentanteLegal.HeaderText = "Rut Represent";
            this.rutRepresentanteLegal.MinimumWidth = 6;
            this.rutRepresentanteLegal.Name = "rutRepresentanteLegal";
            this.rutRepresentanteLegal.ReadOnly = true;
            this.rutRepresentanteLegal.Width = 125;
            // 
            // fechaResol
            // 
            this.fechaResol.DataPropertyName = "fechaResol";
            this.fechaResol.HeaderText = "Fecha Resol";
            this.fechaResol.MinimumWidth = 6;
            this.fechaResol.Name = "fechaResol";
            this.fechaResol.ReadOnly = true;
            this.fechaResol.Width = 125;
            // 
            // ambiente
            // 
            this.ambiente.DataPropertyName = "ambiente";
            this.ambiente.HeaderText = "Ambiente";
            this.ambiente.MinimumWidth = 6;
            this.ambiente.Name = "ambiente";
            this.ambiente.ReadOnly = true;
            this.ambiente.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // colActividadesEconomicas
            // 
            this.colActividadesEconomicas.DataPropertyName = "actividadesEconomicas";
            this.colActividadesEconomicas.HeaderText = "Act Economicas";
            this.colActividadesEconomicas.MinimumWidth = 6;
            this.colActividadesEconomicas.Name = "colActividadesEconomicas";
            this.colActividadesEconomicas.ReadOnly = true;
            this.colActividadesEconomicas.Text = "Act Economicas";
            this.colActividadesEconomicas.UseColumnTextForButtonValue = true;
            this.colActividadesEconomicas.Width = 125;
            // 
            // generarDatosEmpresa
            // 
            this.generarDatosEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarDatosEmpresa.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarDatosEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarDatosEmpresa.Location = new System.Drawing.Point(531, 203);
            this.generarDatosEmpresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generarDatosEmpresa.Name = "generarDatosEmpresa";
            this.generarDatosEmpresa.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarDatosEmpresa.Size = new System.Drawing.Size(75, 35);
            this.generarDatosEmpresa.TabIndex = 32;
            this.generarDatosEmpresa.Text = "Ejecutar";
            this.generarDatosEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarDatosEmpresa.UseVisualStyleBackColor = true;
            this.generarDatosEmpresa.Click += new System.EventHandler(this.generarDatosEmpresa_Click);
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(6, 19);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(253, 49);
            this.textDocumentacion.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.textDocumentacion);
            this.groupBox4.Location = new System.Drawing.Point(14, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 74);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, -2);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Documentación";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 241);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.generarDatosEmpresa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textRutEmisor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Empresa";
            this.Load += new System.EventHandler(this.DatosEmpresa_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.Button generarDatosEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPar;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroResol;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadSII;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutRepresentanteLegal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaResol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewButtonColumn colActividadesEconomicas;
        private System.Windows.Forms.TextBox textDocumentacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}