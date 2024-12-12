namespace SimpleFacturaSDK_Demo
{
    partial class ObtenerXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerXML));
            this.generarXml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.tipodte_oXML = new System.Windows.Forms.ComboBox();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_Bton_recibidoXml = new System.Windows.Forms.RadioButton();
            this.radioButton_emitidoXml = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRutContribuyente = new System.Windows.Forms.TextBox();
            this.textRutE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabelXml = new System.Windows.Forms.LinkLabel();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // generarXml
            // 
            this.generarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarXml.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarXml.Location = new System.Drawing.Point(265, 336);
            this.generarXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generarXml.Name = "generarXml";
            this.generarXml.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.generarXml.Size = new System.Drawing.Size(101, 34);
            this.generarXml.TabIndex = 1;
            this.generarXml.Text = "Generar";
            this.generarXml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarXml.UseVisualStyleBackColor = true;
            this.generarXml.Click += new System.EventHandler(this.generarXml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.tipodte_oXML);
            this.groupBox2.Controls.Add(this.folio_oPDF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(355, 135);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros datos";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(245, 94);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(96, 20);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.Text = "Produccion";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(125, 94);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(101, 20);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // tipodte_oXML
            // 
            this.tipodte_oXML.FormattingEnabled = true;
            this.tipodte_oXML.Location = new System.Drawing.Point(123, 53);
            this.tipodte_oXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipodte_oXML.Name = "tipodte_oXML";
            this.tipodte_oXML.Size = new System.Drawing.Size(187, 24);
            this.tipodte_oXML.TabIndex = 15;
            this.tipodte_oXML.TabStop = false;
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(124, 18);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(187, 22);
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
            this.label5.Location = new System.Drawing.Point(5, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo TipoDTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ambiente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Folio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(355, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(124, 28);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(217, 22);
            this.textRutEmisor.TabIndex = 2;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // radio_Bton_recibidoXml
            // 
            this.radio_Bton_recibidoXml.Location = new System.Drawing.Point(115, 14);
            this.radio_Bton_recibidoXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_Bton_recibidoXml.Name = "radio_Bton_recibidoXml";
            this.radio_Bton_recibidoXml.Size = new System.Drawing.Size(92, 18);
            this.radio_Bton_recibidoXml.TabIndex = 41;
            this.radio_Bton_recibidoXml.Text = "Recibido";
            this.radio_Bton_recibidoXml.UseVisualStyleBackColor = true;
            this.radio_Bton_recibidoXml.CheckedChanged += new System.EventHandler(this.radio_Bton_recibidoXml_CheckedChanged);
            // 
            // radioButton_emitidoXml
            // 
            this.radioButton_emitidoXml.Checked = true;
            this.radioButton_emitidoXml.Location = new System.Drawing.Point(15, 14);
            this.radioButton_emitidoXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_emitidoXml.Name = "radioButton_emitidoXml";
            this.radioButton_emitidoXml.Size = new System.Drawing.Size(92, 18);
            this.radioButton_emitidoXml.TabIndex = 40;
            this.radioButton_emitidoXml.TabStop = true;
            this.radioButton_emitidoXml.Text = "Emitido";
            this.radioButton_emitidoXml.UseVisualStyleBackColor = true;
            this.radioButton_emitidoXml.CheckedChanged += new System.EventHandler(this.radioButton_emitidoXml_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textNombreSucursal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textRutContribuyente);
            this.groupBox3.Controls.Add(this.textRutE);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(356, 142);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(127, 102);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(185, 22);
            this.textNombreSucursal.TabIndex = 3;
            this.textNombreSucursal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre sucursal:";
            // 
            // textRutContribuyente
            // 
            this.textRutContribuyente.Location = new System.Drawing.Point(128, 65);
            this.textRutContribuyente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutContribuyente.Name = "textRutContribuyente";
            this.textRutContribuyente.Size = new System.Drawing.Size(185, 22);
            this.textRutContribuyente.TabIndex = 0;
            this.textRutContribuyente.TabStop = false;
            // 
            // textRutE
            // 
            this.textRutE.Location = new System.Drawing.Point(128, 28);
            this.textRutE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutE.Name = "textRutE";
            this.textRutE.Size = new System.Drawing.Size(185, 22);
            this.textRutE.TabIndex = 0;
            this.textRutE.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut contribuyente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rut Emisor:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabelXml);
            this.groupBox4.Controls.Add(this.textDocumentacion);
            this.groupBox4.Location = new System.Drawing.Point(12, 337);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(246, 117);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            // 
            // linkLabelXml
            // 
            this.linkLabelXml.AutoSize = true;
            this.linkLabelXml.Location = new System.Drawing.Point(12, -2);
            this.linkLabelXml.Name = "linkLabelXml";
            this.linkLabelXml.Size = new System.Drawing.Size(101, 16);
            this.linkLabelXml.TabIndex = 41;
            this.linkLabelXml.TabStop = true;
            this.linkLabelXml.Text = "Documentación";
            this.linkLabelXml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelXml_LinkClicked);
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(8, 23);
            this.textDocumentacion.Margin = new System.Windows.Forms.Padding(4);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(230, 83);
            this.textDocumentacion.TabIndex = 20;
            this.textDocumentacion.Text = "permite generar y descargar archivo XML, correspondiente a DTE emitido en portal " +
    "SimpleFactura.";
            // 
            // ObtenerXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 474);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radio_Bton_recibidoXml);
            this.Controls.Add(this.radioButton_emitidoXml);
            this.Controls.Add(this.generarXml);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObtenerXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener XML";
            this.Load += new System.EventHandler(this.ObtenerXML_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generarXml;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.ComboBox tipodte_oXML;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_Bton_recibidoXml;
        private System.Windows.Forms.RadioButton radioButton_emitidoXml;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRutContribuyente;
        private System.Windows.Forms.TextBox textRutE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabelXml;
        private System.Windows.Forms.TextBox textDocumentacion;
    }
}