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
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_recibidoPdf = new System.Windows.Forms.RadioButton();
            this.radioButton_emitidoPdf = new System.Windows.Forms.RadioButton();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.generarpdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folio_oPDF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textNombreSucursal);
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
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(101, 54);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(140, 20);
            this.textNombreSucursal.TabIndex = 5;
            this.textNombreSucursal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre sucursal:";
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(100, 82);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(141, 20);
            this.folio_oPDF.TabIndex = 6;
            this.folio_oPDF.TabStop = false;
            this.folio_oPDF.Value = new decimal(new int[] {
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_recibidoPdf;
        private System.Windows.Forms.RadioButton radioButton_emitidoPdf;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generarpdf;
    }
}