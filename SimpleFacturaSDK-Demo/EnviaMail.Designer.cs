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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.hasta = new System.Windows.Forms.Label();
            this.ambiente = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.cancelarXml = new System.Windows.Forms.Button();
            this.generarpdf = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.hasta);
            this.groupBox2.Controls.Add(this.ambiente);
            this.groupBox2.Controls.Add(this.desde);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 162);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(98, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(220, 105);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(96, 20);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.TabStop = true;
            this.radioProduccion.Text = "Produccion";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Location = new System.Drawing.Point(97, 105);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(101, 20);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(413, 22);
            this.textBox5.TabIndex = 9;
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(6, 70);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(46, 16);
            this.hasta.TabIndex = 8;
            this.hasta.Text = "Hasta:";
            // 
            // ambiente
            // 
            this.ambiente.AutoSize = true;
            this.ambiente.Location = new System.Drawing.Point(6, 105);
            this.ambiente.Name = "ambiente";
            this.ambiente.Size = new System.Drawing.Size(67, 16);
            this.ambiente.TabIndex = 5;
            this.ambiente.Text = "Ambiente:";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(6, 34);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(51, 16);
            this.desde.TabIndex = 4;
            this.desde.Text = "Desde:";
            // 
            // cancelarXml
            // 
            this.cancelarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarXml.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.cruzar;
            this.cancelarXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarXml.Location = new System.Drawing.Point(127, 185);
            this.cancelarXml.Name = "cancelarXml";
            this.cancelarXml.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.cancelarXml.Size = new System.Drawing.Size(102, 35);
            this.cancelarXml.TabIndex = 18;
            this.cancelarXml.Text = "Cancelar";
            this.cancelarXml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarXml.UseVisualStyleBackColor = true;
            // 
            // generarpdf
            // 
            this.generarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarpdf.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarpdf.Location = new System.Drawing.Point(235, 185);
            this.generarpdf.Name = "generarpdf";
            this.generarpdf.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarpdf.Size = new System.Drawing.Size(102, 35);
            this.generarpdf.TabIndex = 17;
            this.generarpdf.Text = "Generar";
            this.generarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarpdf.UseVisualStyleBackColor = true;
            // 
            // EnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 233);
            this.Controls.Add(this.cancelarXml);
            this.Controls.Add(this.generarpdf);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnviarMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Mail";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarXml;
        private System.Windows.Forms.Button generarpdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label ambiente;
        private System.Windows.Forms.Label desde;
    }
}