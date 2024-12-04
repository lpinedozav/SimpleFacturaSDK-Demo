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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.Location = new System.Drawing.Point(654, 433);
            this.guardar.Name = "guardar";
            this.guardar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guardar.Size = new System.Drawing.Size(88, 41);
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
            this.username.Location = new System.Drawing.Point(30, 45);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 2;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(30, 73);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 16);
            this.password.TabIndex = 3;
            this.password.Text = "Password: ";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(109, 67);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(218, 22);
            this.textpassword.TabIndex = 4;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(109, 40);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(218, 22);
            this.textusername.TabIndex = 5;
            // 
            // textbaseurl
            // 
            this.textbaseurl.Location = new System.Drawing.Point(109, 99);
            this.textbaseurl.Name = "textbaseurl";
            this.textbaseurl.Size = new System.Drawing.Size(218, 22);
            this.textbaseurl.TabIndex = 7;
            // 
            // base_url
            // 
            this.base_url.AutoSize = true;
            this.base_url.Location = new System.Drawing.Point(30, 105);
            this.base_url.Name = "base_url";
            this.base_url.Size = new System.Drawing.Size(72, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 166);
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
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 166);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(133, 133);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(218, 22);
            this.textNombreSucursal.TabIndex = 14;
            // 
            // textRutContribuyente
            // 
            this.textRutContribuyente.Location = new System.Drawing.Point(133, 99);
            this.textRutContribuyente.Name = "textRutContribuyente";
            this.textRutContribuyente.Size = new System.Drawing.Size(218, 22);
            this.textRutContribuyente.TabIndex = 13;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(133, 65);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(218, 22);
            this.textRutEmisor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rut Contribuyente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rut emisor:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(133, 37);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(218, 22);
            this.textEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email usuario:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 233);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emisor";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}