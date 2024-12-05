namespace SimpleFacturaSDK_Demo
{
    partial class EnviarMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarMail));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folio = new System.Windows.Forms.Label();
            this.RutEmpresa = new System.Windows.Forms.Label();
            this.generarpdf = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textRespuesta = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tipodte_oDTE = new System.Windows.Forms.ComboBox();
            this.TipoDte = new System.Windows.Forms.Label();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.para = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cco = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comentario = new System.Windows.Forms.Label();
            this.xml = new System.Windows.Forms.CheckBox();
            this.pdf = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pdf);
            this.groupBox2.Controls.Add(this.xml);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.comentario);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.cc);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.cco);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.para);
            this.groupBox2.Controls.Add(this.folio_oPDF);
            this.groupBox2.Controls.Add(this.tipodte_oDTE);
            this.groupBox2.Controls.Add(this.TipoDte);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.folio);
            this.groupBox2.Controls.Add(this.RutEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 320);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Envio Mail";
            // 
            // folio
            // 
            this.folio.AutoSize = true;
            this.folio.Location = new System.Drawing.Point(6, 69);
            this.folio.Name = "folio";
            this.folio.Size = new System.Drawing.Size(40, 16);
            this.folio.TabIndex = 8;
            this.folio.Text = "Folio:";
            // 
            // RutEmpresa
            // 
            this.RutEmpresa.AutoSize = true;
            this.RutEmpresa.Location = new System.Drawing.Point(6, 34);
            this.RutEmpresa.Name = "RutEmpresa";
            this.RutEmpresa.Size = new System.Drawing.Size(110, 20);
            this.RutEmpresa.TabIndex = 4;
            this.RutEmpresa.Text = "Rut Empresa:";
            // 
            // generarpdf
            // 
            this.generarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarpdf.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarpdf.Location = new System.Drawing.Point(686, 345);
            this.generarpdf.Name = "generarpdf";
            this.generarpdf.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarpdf.Size = new System.Drawing.Size(102, 35);
            this.generarpdf.TabIndex = 17;
            this.generarpdf.Text = "Generar";
            this.generarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarpdf.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRespuesta);
            this.groupBox3.Location = new System.Drawing.Point(317, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(471, 320);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // textRespuesta
            // 
            this.textRespuesta.Location = new System.Drawing.Point(8, 31);
            this.textRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.textRespuesta.Multiline = true;
            this.textRespuesta.Name = "textRespuesta";
            this.textRespuesta.Size = new System.Drawing.Size(453, 281);
            this.textRespuesta.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 20;
            // 
            // tipodte_oDTE
            // 
            this.tipodte_oDTE.FormattingEnabled = true;
            this.tipodte_oDTE.Location = new System.Drawing.Point(97, 102);
            this.tipodte_oDTE.Name = "tipodte_oDTE";
            this.tipodte_oDTE.Size = new System.Drawing.Size(187, 24);
            this.tipodte_oDTE.TabIndex = 23;
            // 
            // TipoDte
            // 
            this.TipoDte.AutoSize = true;
            this.TipoDte.Location = new System.Drawing.Point(6, 105);
            this.TipoDte.Name = "TipoDte";
            this.TipoDte.Size = new System.Drawing.Size(69, 16);
            this.TipoDte.TabIndex = 22;
            this.TipoDte.Text = "Tipo DTE:";
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(97, 67);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(187, 22);
            this.folio_oPDF.TabIndex = 24;
            this.folio_oPDF.Value = new decimal(new int[] {
            4117,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 22);
            this.textBox2.TabIndex = 26;
            // 
            // para
            // 
            this.para.AutoSize = true;
            this.para.Location = new System.Drawing.Point(6, 138);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(49, 20);
            this.para.TabIndex = 25;
            this.para.Text = "Para:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 22);
            this.textBox3.TabIndex = 28;
            // 
            // cco
            // 
            this.cco.AutoSize = true;
            this.cco.Location = new System.Drawing.Point(6, 202);
            this.cco.Name = "cco";
            this.cco.Size = new System.Drawing.Size(34, 16);
            this.cco.TabIndex = 27;
            this.cco.Text = "Cco:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 22);
            this.textBox4.TabIndex = 30;
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(6, 166);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(26, 16);
            this.cc.TabIndex = 29;
            this.cc.Text = "Cc:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 240);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 22);
            this.textBox5.TabIndex = 32;
            // 
            // comentario
            // 
            this.comentario.AutoSize = true;
            this.comentario.Location = new System.Drawing.Point(6, 240);
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(99, 20);
            this.comentario.TabIndex = 31;
            this.comentario.Text = "Comentario:";
            // 
            // xml
            // 
            this.xml.AutoSize = true;
            this.xml.Location = new System.Drawing.Point(9, 278);
            this.xml.Name = "xml";
            this.xml.Size = new System.Drawing.Size(55, 20);
            this.xml.TabIndex = 33;
            this.xml.Text = "XML";
            this.xml.UseVisualStyleBackColor = true;
            // 
            // pdf
            // 
            this.pdf.AutoSize = true;
            this.pdf.Location = new System.Drawing.Point(97, 278);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(56, 20);
            this.pdf.TabIndex = 34;
            this.pdf.Text = "PDF";
            this.pdf.UseVisualStyleBackColor = true;
            // 
            // EnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarpdf);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnviarMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Mail";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generarpdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label folio;
        private System.Windows.Forms.Label RutEmpresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textRespuesta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox tipodte_oDTE;
        private System.Windows.Forms.Label TipoDte;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label para;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label cco;
        private System.Windows.Forms.CheckBox pdf;
        private System.Windows.Forms.CheckBox xml;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label comentario;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label cc;
    }
}