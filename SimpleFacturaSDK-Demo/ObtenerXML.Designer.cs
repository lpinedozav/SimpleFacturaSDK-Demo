﻿namespace SimpleFacturaSDK_Demo
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generarXml
            // 
            this.generarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarXml.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarXml.Location = new System.Drawing.Point(198, 214);
            this.generarXml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generarXml.Name = "generarXml";
            this.generarXml.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarXml.Size = new System.Drawing.Size(76, 28);
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
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(9, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(266, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dte Referenciado Externo";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(184, 76);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(79, 17);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.Text = "Produccion";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(94, 76);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // tipodte_oXML
            // 
            this.tipodte_oXML.FormattingEnabled = true;
            this.tipodte_oXML.Location = new System.Drawing.Point(92, 44);
            this.tipodte_oXML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipodte_oXML.Name = "tipodte_oXML";
            this.tipodte_oXML.Size = new System.Drawing.Size(141, 21);
            this.tipodte_oXML.TabIndex = 15;
            this.tipodte_oXML.TabStop = false;
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(93, 18);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(140, 20);
            this.folio_oPDF.TabIndex = 14;
            this.folio_oPDF.TabStop = false;
            this.folio_oPDF.Value = new decimal(new int[] {
            4117,
            0,
            0,
            0});
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 132);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(311, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo TipoDTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ambiente:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(266, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(93, 23);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(164, 20);
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
            // ObtenerXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 255);
            this.Controls.Add(this.generarXml);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObtenerXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObtenerXML";
            this.Load += new System.EventHandler(this.ObtenerXML_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generarXml;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.ComboBox tipodte_oXML;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
    }
}