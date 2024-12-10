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
            this.textRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.RutCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroResol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadSII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut_Representante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaResol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesEconomicas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.generarAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // textRut
            // 
            this.textRut.Location = new System.Drawing.Point(82, 16);
            this.textRut.Margin = new System.Windows.Forms.Padding(2);
            this.textRut.Name = "textRut";
            this.textRut.Size = new System.Drawing.Size(163, 20);
            this.textRut.TabIndex = 15;
            this.textRut.TabStop = false;
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
            this.groupBox3.Text = "Datos Empresa";
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
            this.correoPart,
            this.correoFact,
            this.Ciudad,
            this.Comuna,
            this.nroResol,
            this.unidadSII,
            this.Rut_Representante,
            this.fechaResol,
            this.ambiente,
            this.telefono,
            this.actividadesEconomicas});
            this.gridResultados.Location = new System.Drawing.Point(5, 13);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(579, 98);
            this.gridResultados.TabIndex = 0;
            // 
            // RutCliente
            // 
            this.RutCliente.HeaderText = "Rut";
            this.RutCliente.Name = "RutCliente";
            this.RutCliente.ReadOnly = true;
            this.RutCliente.Width = 75;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razón Social";
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
            // correoPart
            // 
            this.correoPart.HeaderText = "Correo Part";
            this.correoPart.Name = "correoPart";
            this.correoPart.ReadOnly = true;
            this.correoPart.Width = 105;
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
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Comuna
            // 
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.Name = "Comuna";
            this.Comuna.ReadOnly = true;
            // 
            // nroResol
            // 
            this.nroResol.FillWeight = 70F;
            this.nroResol.HeaderText = "Nro Resol.";
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
            // Rut_Representante
            // 
            this.Rut_Representante.HeaderText = "Rut Represent";
            this.Rut_Representante.Name = "Rut_Representante";
            this.Rut_Representante.ReadOnly = true;
            // 
            // fechaResol
            // 
            this.fechaResol.HeaderText = "Fecha Resol";
            this.fechaResol.Name = "fechaResol";
            this.fechaResol.ReadOnly = true;
            // 
            // ambiente
            // 
            this.ambiente.HeaderText = "Ambiente";
            this.ambiente.Name = "ambiente";
            this.ambiente.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // actividadesEconomicas
            // 
            this.actividadesEconomicas.HeaderText = "Act Economicas";
            this.actividadesEconomicas.Name = "actividadesEconomicas";
            this.actividadesEconomicas.ReadOnly = true;
            // 
            // generarAgregarProducto
            // 
            this.generarAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarAgregarProducto.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarAgregarProducto.Location = new System.Drawing.Point(530, 163);
            this.generarAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.generarAgregarProducto.Name = "generarAgregarProducto";
            this.generarAgregarProducto.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarAgregarProducto.Size = new System.Drawing.Size(76, 28);
            this.generarAgregarProducto.TabIndex = 32;
            this.generarAgregarProducto.Text = "Generar";
            this.generarAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // DatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 200);
            this.Controls.Add(this.generarAgregarProducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textRut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Empresa";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroResol;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadSII;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut_Representante;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaResol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewButtonColumn actividadesEconomicas;
        private System.Windows.Forms.Button generarAgregarProducto;
    }
}