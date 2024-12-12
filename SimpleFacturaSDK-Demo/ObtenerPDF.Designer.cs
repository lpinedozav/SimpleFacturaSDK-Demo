using System;

namespace SimpleFacturaSDK_Demo
{
    partial class ObtenerPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerPDF));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRutContribuyente = new System.Windows.Forms.TextBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.tipodte_oPDF = new System.Windows.Forms.ComboBox();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generarpdf = new System.Windows.Forms.Button();
            this.radioButton_recibidoPdf = new System.Windows.Forms.RadioButton();
            this.radioButton_emitidoPdf = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textRutContribuyente);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(356, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(132, 102);
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
            this.textRutContribuyente.Location = new System.Drawing.Point(131, 65);
            this.textRutContribuyente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutContribuyente.Name = "textRutContribuyente";
            this.textRutContribuyente.Size = new System.Drawing.Size(185, 22);
            this.textRutContribuyente.TabIndex = 0;
            this.textRutContribuyente.TabStop = false;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(131, 28);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(185, 22);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.tipodte_oPDF);
            this.groupBox2.Controls.Add(this.folio_oPDF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(356, 130);
            this.groupBox2.TabIndex = 1;
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
            this.radioProduccion.TabIndex = 0;
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
            this.radioCertificacion.TabIndex = 0;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // tipodte_oPDF
            // 
            this.tipodte_oPDF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipodte_oPDF.FormattingEnabled = true;
            this.tipodte_oPDF.Location = new System.Drawing.Point(123, 53);
            this.tipodte_oPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipodte_oPDF.Name = "tipodte_oPDF";
            this.tipodte_oPDF.Size = new System.Drawing.Size(217, 24);
            this.tipodte_oPDF.TabIndex = 0;
            this.tipodte_oPDF.TabStop = false;
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(124, 20);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(217, 22);
            this.folio_oPDF.TabIndex = 0;
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
            // generarpdf
            // 
            this.generarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarpdf.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarpdf.Location = new System.Drawing.Point(270, 342);
            this.generarpdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generarpdf.Name = "generarpdf";
            this.generarpdf.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.generarpdf.Size = new System.Drawing.Size(101, 34);
            this.generarpdf.TabIndex = 1;
            this.generarpdf.Text = "Generar";
            this.generarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarpdf.UseVisualStyleBackColor = true;
            this.generarpdf.Click += new System.EventHandler(this.generarPdf_Click);
            // 
            // radioButton_recibidoPdf
            // 
            this.radioButton_recibidoPdf.Location = new System.Drawing.Point(115, 14);
            this.radioButton_recibidoPdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_recibidoPdf.Name = "radioButton_recibidoPdf";
            this.radioButton_recibidoPdf.Size = new System.Drawing.Size(92, 18);
            this.radioButton_recibidoPdf.TabIndex = 39;
            this.radioButton_recibidoPdf.Text = "Recibido";
            this.radioButton_recibidoPdf.UseVisualStyleBackColor = true;
            this.radioButton_recibidoPdf.CheckedChanged += new System.EventHandler(this.radioButton_recibidoPdf_CheckedChanged);
            // 
            // radioButton_emitidoPdf
            // 
            this.radioButton_emitidoPdf.Checked = true;
            this.radioButton_emitidoPdf.Location = new System.Drawing.Point(15, 14);
            this.radioButton_emitidoPdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_emitidoPdf.Name = "radioButton_emitidoPdf";
            this.radioButton_emitidoPdf.Size = new System.Drawing.Size(92, 18);
            this.radioButton_emitidoPdf.TabIndex = 38;
            this.radioButton_emitidoPdf.TabStop = true;
            this.radioButton_emitidoPdf.Text = "Emitido";
            this.radioButton_emitidoPdf.UseVisualStyleBackColor = true;
            this.radioButton_emitidoPdf.CheckedChanged += new System.EventHandler(this.radioButton_emitidoPdf_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.textDocumentacion);
            this.groupBox3.Location = new System.Drawing.Point(15, 342);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(245, 135);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(8, 23);
            this.textDocumentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(228, 104);
            this.textDocumentacion.TabIndex = 20;
            this.textDocumentacion.Text = "Este endpoint permite generar y descargar archivo en formato PDF, correspondiente" +
    " a DTE emitido en portal SimpleFactura.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, -2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 20);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Documentación";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ObtenerPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 490);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radioButton_recibidoPdf);
            this.Controls.Add(this.radioButton_emitidoPdf);
            this.Controls.Add(this.generarpdf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObtenerPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener PDF";
            this.Load += new System.EventHandler(this.ObtenerPDF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button generarpdf;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRutContribuyente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipodte_oPDF;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioButton_recibidoPdf;
        private System.Windows.Forms.RadioButton radioButton_emitidoPdf;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textDocumentacion;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}