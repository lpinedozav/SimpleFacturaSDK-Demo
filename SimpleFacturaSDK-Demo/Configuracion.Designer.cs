namespace SimpleFacturaSDK_Demo
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.guardar = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textbaseurl = new System.Windows.Forms.TextBox();
            this.base_url = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.textRutContribuyente = new System.Windows.Forms.TextBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericAzteco = new System.Windows.Forms.NumericUpDown();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.textComuna = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textGiro = new System.Windows.Forms.TextBox();
            this.textRazonsocial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEmisor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAzteco)).BeginInit();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.Location = new System.Drawing.Point(490, 311);
            this.guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guardar.Name = "guardar";
            this.guardar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guardar.Size = new System.Drawing.Size(66, 33);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.UseWaitCursor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(22, 37);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 13);
            this.username.TabIndex = 2;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(22, 59);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(59, 13);
            this.password.TabIndex = 3;
            this.password.Text = "Password: ";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(82, 54);
            this.textpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(164, 20);
            this.textpassword.TabIndex = 4;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(82, 32);
            this.textusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(164, 20);
            this.textusername.TabIndex = 5;
            // 
            // textbaseurl
            // 
            this.textbaseurl.Location = new System.Drawing.Point(82, 80);
            this.textbaseurl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbaseurl.Name = "textbaseurl";
            this.textbaseurl.Size = new System.Drawing.Size(164, 20);
            this.textbaseurl.TabIndex = 7;
            // 
            // base_url
            // 
            this.base_url.AutoSize = true;
            this.base_url.Location = new System.Drawing.Point(22, 85);
            this.base_url.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.base_url.Name = "base_url";
            this.base_url.Size = new System.Drawing.Size(59, 13);
            this.base_url.TabIndex = 6;
            this.base_url.Text = "BaseURL: ";
            this.base_url.Click += new System.EventHandler(this.base_url_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textbaseurl);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.base_url);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.textusername);
            this.groupBox1.Controls.Add(this.textpassword);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(268, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion del cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textNombreSucursal);
            this.groupBox2.Controls.Add(this.textRutContribuyente);
            this.groupBox2.Controls.Add(this.textRutEmisor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(293, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(268, 135);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(100, 108);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(164, 20);
            this.textNombreSucursal.TabIndex = 14;
            // 
            // textRutContribuyente
            // 
            this.textRutContribuyente.Location = new System.Drawing.Point(100, 80);
            this.textRutContribuyente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRutContribuyente.Name = "textRutContribuyente";
            this.textRutContribuyente.Size = new System.Drawing.Size(164, 20);
            this.textRutContribuyente.TabIndex = 13;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(100, 53);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(164, 20);
            this.textRutEmisor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rut Contribuyente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rut emisor:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(100, 30);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(164, 20);
            this.textEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email usuario:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericAzteco);
            this.groupBox3.Controls.Add(this.textCiudad);
            this.groupBox3.Controls.Add(this.textComuna);
            this.groupBox3.Controls.Add(this.textDireccion);
            this.groupBox3.Controls.Add(this.textTelefono);
            this.groupBox3.Controls.Add(this.textCorreo);
            this.groupBox3.Controls.Add(this.textGiro);
            this.groupBox3.Controls.Add(this.textRazonsocial);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textEmisor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(547, 149);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emisor";
            // 
            // numericAzteco
            // 
            this.numericAzteco.Location = new System.Drawing.Point(344, 13);
            this.numericAzteco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericAzteco.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericAzteco.Name = "numericAzteco";
            this.numericAzteco.Size = new System.Drawing.Size(170, 20);
            this.numericAzteco.TabIndex = 31;
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(343, 89);
            this.textCiudad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(172, 20);
            this.textCiudad.TabIndex = 30;
            // 
            // textComuna
            // 
            this.textComuna.Location = new System.Drawing.Point(343, 60);
            this.textComuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textComuna.Name = "textComuna";
            this.textComuna.Size = new System.Drawing.Size(172, 20);
            this.textComuna.TabIndex = 29;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(343, 35);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(172, 20);
            this.textDireccion.TabIndex = 28;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(74, 113);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(172, 20);
            this.textTelefono.TabIndex = 27;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(74, 89);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(172, 20);
            this.textCorreo.TabIndex = 26;
            // 
            // textGiro
            // 
            this.textGiro.Location = new System.Drawing.Point(74, 62);
            this.textGiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textGiro.Name = "textGiro";
            this.textGiro.Size = new System.Drawing.Size(172, 20);
            this.textGiro.TabIndex = 25;
            // 
            // textRazonsocial
            // 
            this.textRazonsocial.Location = new System.Drawing.Point(74, 35);
            this.textRazonsocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRazonsocial.Name = "textRazonsocial";
            this.textRazonsocial.Size = new System.Drawing.Size(172, 20);
            this.textRazonsocial.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ciudad Origen:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Comuna Origen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(256, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Direccion Origen:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Acteco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "GIro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Razon social:";
            // 
            // textEmisor
            // 
            this.textEmisor.Location = new System.Drawing.Point(74, 12);
            this.textEmisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEmisor.Name = "textEmisor";
            this.textEmisor.Size = new System.Drawing.Size(172, 20);
            this.textEmisor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rut:";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 357);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAzteco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textbaseurl;
        private System.Windows.Forms.Label base_url;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.TextBox textRutContribuyente;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textEmisor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.TextBox textComuna;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textGiro;
        private System.Windows.Forms.TextBox textRazonsocial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericAzteco;
    }
}