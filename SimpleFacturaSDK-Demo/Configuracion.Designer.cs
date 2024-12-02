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
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textbaseurl = new System.Windows.Forms.TextBox();
            this.base_url = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(47, 210);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(140, 57);
            this.cancelar.TabIndex = 0;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.Location = new System.Drawing.Point(214, 210);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(136, 57);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(90, 29);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 2;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(90, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 16);
            this.password.TabIndex = 3;
            this.password.Text = "Password: ";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(93, 111);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(218, 22);
            this.textpassword.TabIndex = 4;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(93, 48);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(218, 22);
            this.textusername.TabIndex = 5;
            // 
            // textbaseurl
            // 
            this.textbaseurl.Location = new System.Drawing.Point(93, 169);
            this.textbaseurl.Name = "textbaseurl";
            this.textbaseurl.Size = new System.Drawing.Size(218, 22);
            this.textbaseurl.TabIndex = 7;
            // 
            // base_url
            // 
            this.base_url.AutoSize = true;
            this.base_url.Location = new System.Drawing.Point(90, 150);
            this.base_url.Name = "base_url";
            this.base_url.Size = new System.Drawing.Size(72, 16);
            this.base_url.TabIndex = 6;
            this.base_url.Text = "BaseURL: ";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 316);
            this.Controls.Add(this.textbaseurl);
            this.Controls.Add(this.base_url);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.cancelar);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textbaseurl;
        private System.Windows.Forms.Label base_url;
    }
}