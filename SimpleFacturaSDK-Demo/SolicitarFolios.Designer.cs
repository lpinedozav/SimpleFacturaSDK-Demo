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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitarFolios));
            this.generarSolicitarFolio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCodigoTipoDTE = new System.Windows.Forms.ComboBox();
            this.TipoDte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Propiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // generarSolicitarFolio
            // 
            this.generarSolicitarFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarSolicitarFolio.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarSolicitarFolio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarSolicitarFolio.Location = new System.Drawing.Point(319, 492);
            this.generarSolicitarFolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generarSolicitarFolio.Name = "generarSolicitarFolio";
            this.generarSolicitarFolio.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.generarSolicitarFolio.Size = new System.Drawing.Size(101, 34);
            this.generarSolicitarFolio.TabIndex = 28;
            this.generarSolicitarFolio.Text = "Generar";
            this.generarSolicitarFolio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarSolicitarFolio.UseVisualStyleBackColor = true;
            this.generarSolicitarFolio.Click += new System.EventHandler(this.generarSolicitarFolio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(15, 216);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(405, 270);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de respuesta";
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
            this.Propiedad,
            this.Valor});
            this.gridResultados.Location = new System.Drawing.Point(7, 16);
            this.gridResultados.Margin = new System.Windows.Forms.Padding(4);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(390, 247);
            this.gridResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(406, 96);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(145, 58);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(185, 22);
            this.textNombreSucursal.TabIndex = 0;
            this.textNombreSucursal.TabStop = false;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(145, 23);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(185, 22);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericCantidad);
            this.groupBox2.Controls.Add(this.comboBoxCodigoTipoDTE);
            this.groupBox2.Controls.Add(this.TipoDte);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(406, 96);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(143, 25);
            this.numericCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(187, 22);
            this.numericCantidad.TabIndex = 26;
            this.numericCantidad.TabStop = false;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxCodigoTipoDTE
            // 
            this.comboBoxCodigoTipoDTE.FormattingEnabled = true;
            this.comboBoxCodigoTipoDTE.Location = new System.Drawing.Point(143, 59);
            this.comboBoxCodigoTipoDTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCodigoTipoDTE.Name = "comboBoxCodigoTipoDTE";
            this.comboBoxCodigoTipoDTE.Size = new System.Drawing.Size(187, 24);
            this.comboBoxCodigoTipoDTE.TabIndex = 25;
            this.comboBoxCodigoTipoDTE.TabStop = false;
            // 
            // TipoDte
            // 
            this.TipoDte.AutoSize = true;
            this.TipoDte.Location = new System.Drawing.Point(16, 62);
            this.TipoDte.Name = "TipoDte";
            this.TipoDte.Size = new System.Drawing.Size(69, 16);
            this.TipoDte.TabIndex = 24;
            this.TipoDte.Text = "Tipo DTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad:";
            // 
            // Propiedad
            // 
            this.Propiedad.DataPropertyName = "Propiedad";
            this.Propiedad.HeaderText = "Propiedad";
            this.Propiedad.MinimumWidth = 6;
            this.Propiedad.Name = "Propiedad";
            this.Propiedad.ReadOnly = true;
            this.Propiedad.Width = 125;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 125;
            // 
            // SolicitarFolios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generarSolicitarFolio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SolicitarFolios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Folios";
            this.Load += new System.EventHandler(this.SolicitarFolios_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarSolicitarFolio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCodigoTipoDTE;
        private System.Windows.Forms.Label TipoDte;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}