namespace SimpleFacturaSDK_Demo
{
    partial class ObtenerPdfBhe_Emitida_Recibida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerPdfBhe_Emitida_Recibida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folio_oPDF_BHE = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textRutContribuyente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_recibidoPdf = new System.Windows.Forms.RadioButton();
            this.radioButton_emitidoPdf = new System.Windows.Forms.RadioButton();
            this.generarpdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF_BHE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folio_oPDF_BHE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textRutContribuyente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(255, 118);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Consulta";
            // 
            // folio_oPDF_BHE
            // 
            this.folio_oPDF_BHE.Location = new System.Drawing.Point(100, 82);
            this.folio_oPDF_BHE.Margin = new System.Windows.Forms.Padding(2);
            this.folio_oPDF_BHE.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF_BHE.Name = "folio_oPDF_BHE";
            this.folio_oPDF_BHE.Size = new System.Drawing.Size(141, 20);
            this.folio_oPDF_BHE.TabIndex = 6;
            this.folio_oPDF_BHE.TabStop = false;
            this.folio_oPDF_BHE.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Folio:";
            // 
            // textRutContribuyente
            // 
            this.textRutContribuyente.Location = new System.Drawing.Point(101, 54);
            this.textRutContribuyente.Margin = new System.Windows.Forms.Padding(2);
            this.textRutContribuyente.Name = "textRutContribuyente";
            this.textRutContribuyente.Size = new System.Drawing.Size(140, 20);
            this.textRutContribuyente.TabIndex = 5;
            this.textRutContribuyente.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rut Contribuyente:";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(100, 27);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(140, 20);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // radioButton_recibidoPdf
            // 
            this.radioButton_recibidoPdf.Location = new System.Drawing.Point(86, 11);
            this.radioButton_recibidoPdf.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_recibidoPdf.Name = "radioButton_recibidoPdf";
            this.radioButton_recibidoPdf.Size = new System.Drawing.Size(69, 15);
            this.radioButton_recibidoPdf.TabIndex = 41;
            this.radioButton_recibidoPdf.Text = "Recibido";
            this.radioButton_recibidoPdf.UseVisualStyleBackColor = true;
            this.radioButton_recibidoPdf.CheckedChanged += new System.EventHandler(this.radioButton_recibidoPdf_CheckedChanged_1);
            // 
            // radioButton_emitidoPdf
            // 
            this.radioButton_emitidoPdf.Checked = true;
            this.radioButton_emitidoPdf.Location = new System.Drawing.Point(11, 11);
            this.radioButton_emitidoPdf.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_emitidoPdf.Name = "radioButton_emitidoPdf";
            this.radioButton_emitidoPdf.Size = new System.Drawing.Size(69, 15);
            this.radioButton_emitidoPdf.TabIndex = 40;
            this.radioButton_emitidoPdf.TabStop = true;
            this.radioButton_emitidoPdf.Text = "Emitido";
            this.radioButton_emitidoPdf.UseVisualStyleBackColor = true;
            this.radioButton_emitidoPdf.CheckedChanged += new System.EventHandler(this.radioButton_emitidoPdf_CheckedChanged_1);
            // 
            // generarpdf
            // 
            this.generarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarpdf.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarpdf.Location = new System.Drawing.Point(190, 158);
            this.generarpdf.Margin = new System.Windows.Forms.Padding(2);
            this.generarpdf.Name = "generarpdf";
            this.generarpdf.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarpdf.Size = new System.Drawing.Size(76, 28);
            this.generarpdf.TabIndex = 42;
            this.generarpdf.Text = "Generar";
            this.generarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarpdf.UseVisualStyleBackColor = true;
            this.generarpdf.Click += new System.EventHandler(this.generarpdf_Click);
            // 
            // ObtenerPdfBhe_Emitida_Recibida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 191);
            this.Controls.Add(this.generarpdf);
            this.Controls.Add(this.radioButton_recibidoPdf);
            this.Controls.Add(this.radioButton_emitidoPdf);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObtenerPdfBhe_Emitida_Recibida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener Pdf Boletas de Honorarios";
            this.Load += new System.EventHandler(this.ObtenerPdfBhe_Emitida_Recibida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF_BHE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_recibidoPdf;
        private System.Windows.Forms.RadioButton radioButton_emitidoPdf;
        private System.Windows.Forms.TextBox textRutContribuyente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown folio_oPDF_BHE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generarpdf;
    }
}