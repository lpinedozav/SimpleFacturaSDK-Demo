namespace SimpleFacturaSDK_Demo
{
    partial class ConsultaFoliosDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFoliosDisponibles));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.textRutEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCodigoTipoDTE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generarConsultaFolios = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textRespuesta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioProduccion);
            this.groupBox1.Controls.Add(this.textRutEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioCertificacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxCodigoTipoDTE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(360, 145);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Consulta";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(225, 105);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(96, 20);
            this.radioProduccion.TabIndex = 22;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // textRutEmpresa
            // 
            this.textRutEmpresa.Location = new System.Drawing.Point(112, 33);
            this.textRutEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmpresa.Name = "textRutEmpresa";
            this.textRutEmpresa.Size = new System.Drawing.Size(185, 22);
            this.textRutEmpresa.TabIndex = 0;
            this.textRutEmpresa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Empresa:";
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(109, 105);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(101, 20);
            this.radioCertificacion.TabIndex = 21;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo DTE:";
            // 
            // comboBoxCodigoTipoDTE
            // 
            this.comboBoxCodigoTipoDTE.FormattingEnabled = true;
            this.comboBoxCodigoTipoDTE.Location = new System.Drawing.Point(111, 66);
            this.comboBoxCodigoTipoDTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCodigoTipoDTE.Name = "comboBoxCodigoTipoDTE";
            this.comboBoxCodigoTipoDTE.Size = new System.Drawing.Size(187, 24);
            this.comboBoxCodigoTipoDTE.TabIndex = 20;
            this.comboBoxCodigoTipoDTE.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ambiente:";
            // 
            // generarConsultaFolios
            // 
            this.generarConsultaFolios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarConsultaFolios.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarConsultaFolios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarConsultaFolios.Location = new System.Drawing.Point(273, 491);
            this.generarConsultaFolios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generarConsultaFolios.Name = "generarConsultaFolios";
            this.generarConsultaFolios.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.generarConsultaFolios.Size = new System.Drawing.Size(101, 34);
            this.generarConsultaFolios.TabIndex = 28;
            this.generarConsultaFolios.Text = "Generar";
            this.generarConsultaFolios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarConsultaFolios.UseVisualStyleBackColor = true;
            this.generarConsultaFolios.Click += new System.EventHandler(this.generarConsultaFolios_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRespuesta);
            this.groupBox3.Location = new System.Drawing.Point(15, 165);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(360, 320);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // textRespuesta
            // 
            this.textRespuesta.Location = new System.Drawing.Point(8, 25);
            this.textRespuesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRespuesta.Multiline = true;
            this.textRespuesta.Name = "textRespuesta";
            this.textRespuesta.Size = new System.Drawing.Size(336, 281);
            this.textRespuesta.TabIndex = 19;
            // 
            // ConsultaFoliosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarConsultaFolios);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaFoliosDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Folios Disponibles";
            this.Load += new System.EventHandler(this.ConsultaFoliosDisponibles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarConsultaFolios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCodigoTipoDTE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textRespuesta;
    }
}