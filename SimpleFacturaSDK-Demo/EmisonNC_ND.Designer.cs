namespace SimpleFacturaSDK_Demo
{
    partial class EmisonNC_ND
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipodte_ListEmitidos = new System.Windows.Forms.ComboBox();
            this.tipoDte = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FchEmision = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textRUTReceptor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textGiroReceptor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textCiudadReceptor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textDireccionReceptor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textRazonSocialReceptor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textGiroEmisor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textComunaEmisor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textRazonSocialEmisor = new System.Windows.Forms.TextBox();
            this.textRUTEmisor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textDireccionEmisor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.FchEmision);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tipodte_ListEmitidos);
            this.groupBox1.Controls.Add(this.tipoDte);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1474, 78);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificacion DTE";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(1227, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1086, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha vencimiento:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(490, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Forma de pago:";
            // 
            // tipodte_ListEmitidos
            // 
            this.tipodte_ListEmitidos.FormattingEnabled = true;
            this.tipodte_ListEmitidos.Location = new System.Drawing.Point(104, 27);
            this.tipodte_ListEmitidos.Name = "tipodte_ListEmitidos";
            this.tipodte_ListEmitidos.Size = new System.Drawing.Size(229, 24);
            this.tipodte_ListEmitidos.TabIndex = 25;
            this.tipodte_ListEmitidos.SelectedIndexChanged += new System.EventHandler(this.tipodte_ListEmitidos_SelectedIndexChanged);
            // 
            // tipoDte
            // 
            this.tipoDte.AutoSize = true;
            this.tipoDte.Location = new System.Drawing.Point(15, 31);
            this.tipoDte.Name = "tipoDte";
            this.tipoDte.Size = new System.Drawing.Size(66, 16);
            this.tipoDte.TabIndex = 24;
            this.tipoDte.Text = "TipoDTE:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(866, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // FchEmision
            // 
            this.FchEmision.AutoSize = true;
            this.FchEmision.Location = new System.Drawing.Point(745, 32);
            this.FchEmision.Name = "FchEmision";
            this.FchEmision.Size = new System.Drawing.Size(98, 16);
            this.FchEmision.TabIndex = 32;
            this.FchEmision.Text = "Fecha emisión:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textRUTReceptor);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textGiroReceptor);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textCiudadReceptor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textDireccionReceptor);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textRazonSocialReceptor);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(345, 386);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(809, 105);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receptor";
            // 
            // textRUTReceptor
            // 
            this.textRUTReceptor.Enabled = false;
            this.textRUTReceptor.Location = new System.Drawing.Point(67, 31);
            this.textRUTReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.textRUTReceptor.Name = "textRUTReceptor";
            this.textRUTReceptor.Size = new System.Drawing.Size(107, 22);
            this.textRUTReceptor.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "RUT:";
            // 
            // textGiroReceptor
            // 
            this.textGiroReceptor.Location = new System.Drawing.Point(275, 63);
            this.textGiroReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.textGiroReceptor.Name = "textGiroReceptor";
            this.textGiroReceptor.Size = new System.Drawing.Size(524, 22);
            this.textGiroReceptor.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Giro:";
            // 
            // textCiudadReceptor
            // 
            this.textCiudadReceptor.Location = new System.Drawing.Point(67, 63);
            this.textCiudadReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.textCiudadReceptor.Name = "textCiudadReceptor";
            this.textCiudadReceptor.Size = new System.Drawing.Size(157, 22);
            this.textCiudadReceptor.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ciudad:";
            // 
            // textDireccionReceptor
            // 
            this.textDireccionReceptor.Location = new System.Drawing.Point(576, 30);
            this.textDireccionReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.textDireccionReceptor.Name = "textDireccionReceptor";
            this.textDireccionReceptor.Size = new System.Drawing.Size(223, 22);
            this.textDireccionReceptor.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(495, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Dirección:";
            // 
            // textRazonSocialReceptor
            // 
            this.textRazonSocialReceptor.Location = new System.Drawing.Point(299, 30);
            this.textRazonSocialReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.textRazonSocialReceptor.Name = "textRazonSocialReceptor";
            this.textRazonSocialReceptor.Size = new System.Drawing.Size(187, 22);
            this.textRazonSocialReceptor.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(195, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Razón Social:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textDireccionEmisor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textGiroEmisor);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textComunaEmisor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textRazonSocialEmisor);
            this.groupBox3.Controls.Add(this.textRUTEmisor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(10, 97);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1473, 105);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emisor";
            // 
            // textGiroEmisor
            // 
            this.textGiroEmisor.Location = new System.Drawing.Point(555, 30);
            this.textGiroEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.textGiroEmisor.Name = "textGiroEmisor";
            this.textGiroEmisor.Size = new System.Drawing.Size(500, 22);
            this.textGiroEmisor.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(503, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Giro:";
            // 
            // textComunaEmisor
            // 
            this.textComunaEmisor.Location = new System.Drawing.Point(81, 62);
            this.textComunaEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.textComunaEmisor.Name = "textComunaEmisor";
            this.textComunaEmisor.Size = new System.Drawing.Size(157, 22);
            this.textComunaEmisor.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Comuna:";
            // 
            // textRazonSocialEmisor
            // 
            this.textRazonSocialEmisor.Location = new System.Drawing.Point(300, 30);
            this.textRazonSocialEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.textRazonSocialEmisor.Name = "textRazonSocialEmisor";
            this.textRazonSocialEmisor.Size = new System.Drawing.Size(187, 22);
            this.textRazonSocialEmisor.TabIndex = 18;
            // 
            // textRUTEmisor
            // 
            this.textRUTEmisor.Location = new System.Drawing.Point(81, 30);
            this.textRUTEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.textRUTEmisor.Name = "textRUTEmisor";
            this.textRUTEmisor.Size = new System.Drawing.Size(107, 22);
            this.textRUTEmisor.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Razón Social:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "RUT:";
            // 
            // textDireccionEmisor
            // 
            this.textDireccionEmisor.Location = new System.Drawing.Point(367, 65);
            this.textDireccionEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.textDireccionEmisor.Name = "textDireccionEmisor";
            this.textDireccionEmisor.Size = new System.Drawing.Size(223, 22);
            this.textDireccionEmisor.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dirección:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1148, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1075, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefono:";
            // 
            // EmisonNC_ND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 764);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmisonNC_ND";
            this.Text = "Emison NC-ND";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tipodte_ListEmitidos;
        private System.Windows.Forms.Label tipoDte;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FchEmision;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textRUTReceptor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textGiroReceptor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCiudadReceptor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textDireccionReceptor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textRazonSocialReceptor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textDireccionEmisor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textGiroEmisor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textComunaEmisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textRazonSocialEmisor;
        private System.Windows.Forms.TextBox textRUTEmisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}