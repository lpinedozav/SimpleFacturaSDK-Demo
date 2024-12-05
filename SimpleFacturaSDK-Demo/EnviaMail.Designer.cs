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
            this.checkPDF = new System.Windows.Forms.CheckBox();
            this.checkXML = new System.Windows.Forms.CheckBox();
            this.textComentario = new System.Windows.Forms.TextBox();
            this.comentario = new System.Windows.Forms.Label();
            this.textCC = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.Label();
            this.textCCO = new System.Windows.Forms.TextBox();
            this.cco = new System.Windows.Forms.Label();
            this.textPara = new System.Windows.Forms.TextBox();
            this.para = new System.Windows.Forms.Label();
            this.numericFolio = new System.Windows.Forms.NumericUpDown();
            this.comboxTipoDte = new System.Windows.Forms.ComboBox();
            this.TipoDte = new System.Windows.Forms.Label();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.folio = new System.Windows.Forms.Label();
            this.RutEmpresa = new System.Windows.Forms.Label();
            this.generarpdf = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textRespuesta = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkPDF);
            this.groupBox2.Controls.Add(this.checkXML);
            this.groupBox2.Controls.Add(this.textComentario);
            this.groupBox2.Controls.Add(this.comentario);
            this.groupBox2.Controls.Add(this.textCC);
            this.groupBox2.Controls.Add(this.cc);
            this.groupBox2.Controls.Add(this.textCCO);
            this.groupBox2.Controls.Add(this.cco);
            this.groupBox2.Controls.Add(this.textPara);
            this.groupBox2.Controls.Add(this.para);
            this.groupBox2.Controls.Add(this.numericFolio);
            this.groupBox2.Controls.Add(this.comboxTipoDte);
            this.groupBox2.Controls.Add(this.TipoDte);
            this.groupBox2.Controls.Add(this.textRutEmisor);
            this.groupBox2.Controls.Add(this.folio);
            this.groupBox2.Controls.Add(this.RutEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(224, 260);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Envio Mail";
            // 
            // checkPDF
            // 
            this.checkPDF.AutoSize = true;
            this.checkPDF.Location = new System.Drawing.Point(73, 226);
            this.checkPDF.Margin = new System.Windows.Forms.Padding(2);
            this.checkPDF.Name = "checkPDF";
            this.checkPDF.Size = new System.Drawing.Size(47, 17);
            this.checkPDF.TabIndex = 34;
            this.checkPDF.TabStop = false;
            this.checkPDF.Text = "PDF";
            this.checkPDF.UseVisualStyleBackColor = true;
            // 
            // checkXML
            // 
            this.checkXML.AutoSize = true;
            this.checkXML.Location = new System.Drawing.Point(7, 226);
            this.checkXML.Margin = new System.Windows.Forms.Padding(2);
            this.checkXML.Name = "checkXML";
            this.checkXML.Size = new System.Drawing.Size(48, 17);
            this.checkXML.TabIndex = 33;
            this.checkXML.TabStop = false;
            this.checkXML.Text = "XML";
            this.checkXML.UseVisualStyleBackColor = true;
            // 
            // textComentario
            // 
            this.textComentario.Location = new System.Drawing.Point(73, 195);
            this.textComentario.Margin = new System.Windows.Forms.Padding(2);
            this.textComentario.Name = "textComentario";
            this.textComentario.Size = new System.Drawing.Size(141, 20);
            this.textComentario.TabIndex = 32;
            this.textComentario.TabStop = false;
            // 
            // comentario
            // 
            this.comentario.AutoSize = true;
            this.comentario.Location = new System.Drawing.Point(4, 195);
            this.comentario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(63, 13);
            this.comentario.TabIndex = 31;
            this.comentario.Text = "Comentario:";
            // 
            // textCC
            // 
            this.textCC.Location = new System.Drawing.Point(73, 135);
            this.textCC.Margin = new System.Windows.Forms.Padding(2);
            this.textCC.Name = "textCC";
            this.textCC.Size = new System.Drawing.Size(141, 20);
            this.textCC.TabIndex = 30;
            this.textCC.TabStop = false;
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(4, 135);
            this.cc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(23, 13);
            this.cc.TabIndex = 29;
            this.cc.Text = "Cc:";
            // 
            // textCCO
            // 
            this.textCCO.Location = new System.Drawing.Point(73, 164);
            this.textCCO.Margin = new System.Windows.Forms.Padding(2);
            this.textCCO.Name = "textCCO";
            this.textCCO.Size = new System.Drawing.Size(141, 20);
            this.textCCO.TabIndex = 28;
            this.textCCO.TabStop = false;
            // 
            // cco
            // 
            this.cco.AutoSize = true;
            this.cco.Location = new System.Drawing.Point(4, 164);
            this.cco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cco.Name = "cco";
            this.cco.Size = new System.Drawing.Size(29, 13);
            this.cco.TabIndex = 27;
            this.cco.Text = "Cco:";
            // 
            // textPara
            // 
            this.textPara.Location = new System.Drawing.Point(73, 112);
            this.textPara.Margin = new System.Windows.Forms.Padding(2);
            this.textPara.Name = "textPara";
            this.textPara.Size = new System.Drawing.Size(141, 20);
            this.textPara.TabIndex = 26;
            this.textPara.TabStop = false;
            // 
            // para
            // 
            this.para.AutoSize = true;
            this.para.Location = new System.Drawing.Point(4, 112);
            this.para.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(32, 13);
            this.para.TabIndex = 25;
            this.para.Text = "Para:";
            // 
            // numericFolio
            // 
            this.numericFolio.Location = new System.Drawing.Point(73, 54);
            this.numericFolio.Margin = new System.Windows.Forms.Padding(2);
            this.numericFolio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFolio.Name = "numericFolio";
            this.numericFolio.Size = new System.Drawing.Size(140, 20);
            this.numericFolio.TabIndex = 24;
            this.numericFolio.TabStop = false;
            this.numericFolio.Value = new decimal(new int[] {
            4117,
            0,
            0,
            0});
            // 
            // comboxTipoDte
            // 
            this.comboxTipoDte.FormattingEnabled = true;
            this.comboxTipoDte.Location = new System.Drawing.Point(73, 83);
            this.comboxTipoDte.Margin = new System.Windows.Forms.Padding(2);
            this.comboxTipoDte.Name = "comboxTipoDte";
            this.comboxTipoDte.Size = new System.Drawing.Size(141, 21);
            this.comboxTipoDte.TabIndex = 23;
            this.comboxTipoDte.TabStop = false;
            // 
            // TipoDte
            // 
            this.TipoDte.AutoSize = true;
            this.TipoDte.Location = new System.Drawing.Point(4, 85);
            this.TipoDte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TipoDte.Name = "TipoDte";
            this.TipoDte.Size = new System.Drawing.Size(56, 13);
            this.TipoDte.TabIndex = 22;
            this.TipoDte.Text = "Tipo DTE:";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(73, 28);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(141, 20);
            this.textRutEmisor.TabIndex = 20;
            this.textRutEmisor.TabStop = false;
            // 
            // folio
            // 
            this.folio.AutoSize = true;
            this.folio.Location = new System.Drawing.Point(4, 56);
            this.folio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.folio.Name = "folio";
            this.folio.Size = new System.Drawing.Size(32, 13);
            this.folio.TabIndex = 8;
            this.folio.Text = "Folio:";
            // 
            // RutEmpresa
            // 
            this.RutEmpresa.AutoSize = true;
            this.RutEmpresa.Location = new System.Drawing.Point(4, 28);
            this.RutEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RutEmpresa.Name = "RutEmpresa";
            this.RutEmpresa.Size = new System.Drawing.Size(71, 13);
            this.RutEmpresa.TabIndex = 4;
            this.RutEmpresa.Text = "Rut Empresa:";
            // 
            // generarpdf
            // 
            this.generarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarpdf.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarpdf.Location = new System.Drawing.Point(514, 280);
            this.generarpdf.Margin = new System.Windows.Forms.Padding(2);
            this.generarpdf.Name = "generarpdf";
            this.generarpdf.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarpdf.Size = new System.Drawing.Size(76, 28);
            this.generarpdf.TabIndex = 1;
            this.generarpdf.Text = "Generar";
            this.generarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarpdf.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRespuesta);
            this.groupBox3.Location = new System.Drawing.Point(238, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 260);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // textRespuesta
            // 
            this.textRespuesta.Location = new System.Drawing.Point(6, 25);
            this.textRespuesta.Multiline = true;
            this.textRespuesta.Name = "textRespuesta";
            this.textRespuesta.Size = new System.Drawing.Size(341, 229);
            this.textRespuesta.TabIndex = 19;
            // 
            // EnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 318);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarpdf);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnviarMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Mail";
            this.Load += new System.EventHandler(this.EnviarMail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generarpdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label folio;
        private System.Windows.Forms.Label RutEmpresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textRespuesta;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.ComboBox comboxTipoDte;
        private System.Windows.Forms.Label TipoDte;
        private System.Windows.Forms.NumericUpDown numericFolio;
        private System.Windows.Forms.TextBox textPara;
        private System.Windows.Forms.Label para;
        private System.Windows.Forms.TextBox textCCO;
        private System.Windows.Forms.Label cco;
        private System.Windows.Forms.CheckBox checkPDF;
        private System.Windows.Forms.CheckBox checkXML;
        private System.Windows.Forms.TextBox textComentario;
        private System.Windows.Forms.Label comentario;
        private System.Windows.Forms.TextBox textCC;
        private System.Windows.Forms.Label cc;
    }
}