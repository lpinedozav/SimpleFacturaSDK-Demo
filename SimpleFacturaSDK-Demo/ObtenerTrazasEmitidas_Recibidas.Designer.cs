namespace SimpleFacturaSDK_Demo
{
    partial class ObtenerTrazasEmitidas_Recibidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerTrazasEmitidas_Recibidas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutContribuyente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.comboBox_codigoTipoDTE = new System.Windows.Forms.ComboBox();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.obtener_trazas = new System.Windows.Forms.Button();
            this.radioButton_recibido = new System.Windows.Forms.RadioButton();
            this.radioButton_emitido = new System.Windows.Forms.RadioButton();
            this.gridTrazas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrazas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutContribuyente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(376, 88);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutContribuyente
            // 
            this.textRutContribuyente.Location = new System.Drawing.Point(100, 48);
            this.textRutContribuyente.Margin = new System.Windows.Forms.Padding(2);
            this.textRutContribuyente.Name = "textRutContribuyente";
            this.textRutContribuyente.Size = new System.Drawing.Size(265, 20);
            this.textRutContribuyente.TabIndex = 4;
            this.textRutContribuyente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rut contribuyente:";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(100, 20);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(265, 20);
            this.textRutEmisor.TabIndex = 2;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBox_codigoTipoDTE);
            this.groupBox2.Controls.Add(this.folio_oPDF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(11, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(376, 131);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dte Referenciado Externo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioProduccion);
            this.groupBox3.Controls.Add(this.radioCertificacion);
            this.groupBox3.Location = new System.Drawing.Point(7, 78);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(350, 43);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ambiente";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(212, 17);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(79, 17);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(85, 17);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // comboBox_codigoTipoDTE
            // 
            this.comboBox_codigoTipoDTE.FormattingEnabled = true;
            this.comboBox_codigoTipoDTE.Location = new System.Drawing.Point(100, 44);
            this.comboBox_codigoTipoDTE.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_codigoTipoDTE.Name = "comboBox_codigoTipoDTE";
            this.comboBox_codigoTipoDTE.Size = new System.Drawing.Size(265, 21);
            this.comboBox_codigoTipoDTE.TabIndex = 15;
            this.comboBox_codigoTipoDTE.TabStop = false;
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(100, 18);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(265, 20);
            this.folio_oPDF.TabIndex = 14;
            this.folio_oPDF.TabStop = false;
            this.folio_oPDF.Value = new decimal(new int[] {
            4117,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código TipoDTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Folio:";
            // 
            // obtener_trazas
            // 
            this.obtener_trazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtener_trazas.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.obtener_trazas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obtener_trazas.Location = new System.Drawing.Point(314, 588);
            this.obtener_trazas.Margin = new System.Windows.Forms.Padding(2);
            this.obtener_trazas.Name = "obtener_trazas";
            this.obtener_trazas.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.obtener_trazas.Size = new System.Drawing.Size(75, 35);
            this.obtener_trazas.TabIndex = 1;
            this.obtener_trazas.Text = "Obtener";
            this.obtener_trazas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.obtener_trazas.UseVisualStyleBackColor = true;
            this.obtener_trazas.Click += new System.EventHandler(this.obtener_trazas_Click);
            // 
            // radioButton_recibido
            // 
            this.radioButton_recibido.Location = new System.Drawing.Point(93, 11);
            this.radioButton_recibido.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_recibido.Name = "radioButton_recibido";
            this.radioButton_recibido.Size = new System.Drawing.Size(69, 15);
            this.radioButton_recibido.TabIndex = 41;
            this.radioButton_recibido.Text = "Recibido";
            this.radioButton_recibido.UseVisualStyleBackColor = true;
            this.radioButton_recibido.CheckedChanged += new System.EventHandler(this.radioButton_recibido_CheckedChanged);
            // 
            // radioButton_emitido
            // 
            this.radioButton_emitido.Checked = true;
            this.radioButton_emitido.Location = new System.Drawing.Point(18, 11);
            this.radioButton_emitido.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_emitido.Name = "radioButton_emitido";
            this.radioButton_emitido.Size = new System.Drawing.Size(69, 15);
            this.radioButton_emitido.TabIndex = 40;
            this.radioButton_emitido.Text = "Emitido";
            this.radioButton_emitido.UseVisualStyleBackColor = true;
            this.radioButton_emitido.CheckedChanged += new System.EventHandler(this.radioButton_emitido_CheckedChanged);
            // 
            // gridTrazas
            // 
            this.gridTrazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrazas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.descripcion});
            this.gridTrazas.Location = new System.Drawing.Point(12, 277);
            this.gridTrazas.Name = "gridTrazas";
            this.gridTrazas.RowHeadersWidth = 20;
            this.gridTrazas.Size = new System.Drawing.Size(377, 256);
            this.gridTrazas.TabIndex = 42;
            this.gridTrazas.TabStop = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.textDocumentacion);
            this.groupBox4.Location = new System.Drawing.Point(12, 539);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 84);
            this.groupBox4.TabIndex = 43;
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
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(6, 19);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(172, 85);
            this.textDocumentacion.TabIndex = 20;
            this.textDocumentacion.TabStop = false;
            this.textDocumentacion.Text = "Este endpoint permite generar y descargar archivo en formato PDF, correspondiente" +
    " a DTE emitido en portal SimpleFactura.";
            // 
            // ObtenerTrazasEmitidas_Recibidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 632);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gridTrazas);
            this.Controls.Add(this.radioButton_recibido);
            this.Controls.Add(this.radioButton_emitido);
            this.Controls.Add(this.obtener_trazas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObtenerTrazasEmitidas_Recibidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener Trazas";
            this.Load += new System.EventHandler(this.ObtenerTrazasEmitidas_Recibidas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrazas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRutContribuyente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.ComboBox comboBox_codigoTipoDTE;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button obtener_trazas;
        private System.Windows.Forms.RadioButton radioButton_recibido;
        private System.Windows.Forms.RadioButton radioButton_emitido;
        private System.Windows.Forms.DataGridView gridTrazas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textDocumentacion;
    }
}