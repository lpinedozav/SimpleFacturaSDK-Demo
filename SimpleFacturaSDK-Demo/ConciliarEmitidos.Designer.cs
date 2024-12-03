namespace SimpleFacturaSDK_Demo
{
    partial class ConciliarEmitidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConciliarEmitidos));
            this.cancelarEmitido = new System.Windows.Forms.Button();
            this.generarEmitidos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.labelRutEmisor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelarEmitido
            // 
            this.cancelarEmitido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarEmitido.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.cruzar;
            this.cancelarEmitido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarEmitido.Location = new System.Drawing.Point(303, 106);
            this.cancelarEmitido.Name = "cancelarEmitido";
            this.cancelarEmitido.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.cancelarEmitido.Size = new System.Drawing.Size(102, 35);
            this.cancelarEmitido.TabIndex = 15;
            this.cancelarEmitido.Text = "Cancelar";
            this.cancelarEmitido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarEmitido.UseVisualStyleBackColor = true;
            // 
            // generarEmitidos
            // 
            this.generarEmitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarEmitidos.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarEmitidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarEmitidos.Location = new System.Drawing.Point(411, 106);
            this.generarEmitidos.Name = "generarEmitidos";
            this.generarEmitidos.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarEmitidos.Size = new System.Drawing.Size(102, 35);
            this.generarEmitidos.TabIndex = 14;
            this.generarEmitidos.Text = "Generar";
            this.generarEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarEmitidos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.labelRutEmisor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(97, 24);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(351, 22);
            this.textRutEmisor.TabIndex = 2;
            // 
            // labelRutEmisor
            // 
            this.labelRutEmisor.AutoSize = true;
            this.labelRutEmisor.Location = new System.Drawing.Point(6, 28);
            this.labelRutEmisor.Name = "labelRutEmisor";
            this.labelRutEmisor.Size = new System.Drawing.Size(75, 16);
            this.labelRutEmisor.TabIndex = 0;
            this.labelRutEmisor.Text = "Rut Emisor:";
            // 
            // ConciliarEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 152);
            this.Controls.Add(this.cancelarEmitido);
            this.Controls.Add(this.generarEmitidos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConciliarEmitidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliar Emitidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarEmitido;
        private System.Windows.Forms.Button generarEmitidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label labelRutEmisor;
    }
}