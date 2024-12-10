namespace SimpleFacturaSDK_Demo
{
    partial class SolicitarFolios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitarFolios));
            this.generarAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboxTipoDte = new System.Windows.Forms.ComboBox();
            this.TipoDte = new System.Windows.Forms.Label();
            this.numericFolio = new System.Windows.Forms.NumericUpDown();
            this.Codigosii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoliosDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Dte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ambiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).BeginInit();
            this.SuspendLayout();
            // 
            // generarAgregarProducto
            // 
            this.generarAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarAgregarProducto.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarAgregarProducto.Location = new System.Drawing.Point(438, 216);
            this.generarAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.generarAgregarProducto.Name = "generarAgregarProducto";
            this.generarAgregarProducto.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarAgregarProducto.Size = new System.Drawing.Size(76, 28);
            this.generarAgregarProducto.TabIndex = 28;
            this.generarAgregarProducto.Text = "Generar";
            this.generarAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(11, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 117);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
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
            this.Codigosii,
            this.FoliosDisp,
            this.desde,
            this.hasta,
            this.fechaIngreso,
            this.fechaVencimiento,
            this.tipo_Dte,
            this.Ambiente});
            this.gridResultados.Location = new System.Drawing.Point(5, 13);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(488, 98);
            this.gridResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(264, 78);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(109, 47);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(140, 20);
            this.textNombreSucursal.TabIndex = 0;
            this.textNombreSucursal.TabStop = false;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(109, 19);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(140, 20);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericFolio);
            this.groupBox2.Controls.Add(this.comboxTipoDte);
            this.groupBox2.Controls.Add(this.TipoDte);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(279, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(235, 78);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad:";
            // 
            // comboxTipoDte
            // 
            this.comboxTipoDte.FormattingEnabled = true;
            this.comboxTipoDte.Location = new System.Drawing.Point(76, 48);
            this.comboxTipoDte.Margin = new System.Windows.Forms.Padding(2);
            this.comboxTipoDte.Name = "comboxTipoDte";
            this.comboxTipoDte.Size = new System.Drawing.Size(141, 21);
            this.comboxTipoDte.TabIndex = 25;
            this.comboxTipoDte.TabStop = false;
            // 
            // TipoDte
            // 
            this.TipoDte.AutoSize = true;
            this.TipoDte.Location = new System.Drawing.Point(12, 50);
            this.TipoDte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TipoDte.Name = "TipoDte";
            this.TipoDte.Size = new System.Drawing.Size(56, 13);
            this.TipoDte.TabIndex = 24;
            this.TipoDte.Text = "Tipo DTE:";
            // 
            // numericFolio
            // 
            this.numericFolio.Location = new System.Drawing.Point(77, 20);
            this.numericFolio.Margin = new System.Windows.Forms.Padding(2);
            this.numericFolio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFolio.Name = "numericFolio";
            this.numericFolio.Size = new System.Drawing.Size(140, 20);
            this.numericFolio.TabIndex = 26;
            this.numericFolio.TabStop = false;
            this.numericFolio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Codigosii
            // 
            this.Codigosii.HeaderText = "Código Sii";
            this.Codigosii.Name = "Codigosii";
            this.Codigosii.ReadOnly = true;
            this.Codigosii.Width = 65;
            // 
            // FoliosDisp
            // 
            this.FoliosDisp.DataPropertyName = "FoliosDisp";
            this.FoliosDisp.HeaderText = "Folios Disp";
            this.FoliosDisp.MinimumWidth = 6;
            this.FoliosDisp.Name = "FoliosDisp";
            this.FoliosDisp.ReadOnly = true;
            this.FoliosDisp.Width = 75;
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            this.desde.Width = 60;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            this.hasta.Width = 60;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.HeaderText = "Fecha Ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            this.fechaIngreso.Width = 90;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.DataPropertyName = "fechaVencimiento";
            dataGridViewCellStyle1.Format = "N1";
            this.fechaVencimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.fechaVencimiento.MinimumWidth = 6;
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.ReadOnly = true;
            this.fechaVencimiento.Width = 105;
            // 
            // tipo_Dte
            // 
            this.tipo_Dte.HeaderText = "Tipo DTE";
            this.tipo_Dte.Name = "tipo_Dte";
            this.tipo_Dte.ReadOnly = true;
            this.tipo_Dte.Width = 125;
            // 
            // Ambiente
            // 
            this.Ambiente.DataPropertyName = "Ambiente";
            dataGridViewCellStyle2.Format = "N0";
            this.Ambiente.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ambiente.HeaderText = "Ambiente";
            this.Ambiente.MinimumWidth = 6;
            this.Ambiente.Name = "Ambiente";
            this.Ambiente.ReadOnly = true;
            this.Ambiente.Width = 80;
            // 
            // SolicitarFolios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 251);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generarAgregarProducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SolicitarFolios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Folios";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarAgregarProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboxTipoDte;
        private System.Windows.Forms.Label TipoDte;
        private System.Windows.Forms.NumericUpDown numericFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigosii;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoliosDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_Dte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ambiente;
    }
}