﻿namespace SimpleFacturaSDK_Demo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.labelRutEmisor = new System.Windows.Forms.Label();
            this.cancelarEmitido = new System.Windows.Forms.Button();
            this.generarEmitidos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textRespuesta = new System.Windows.Forms.TextBox();
            this.textMes = new System.Windows.Forms.NumericUpDown();
            this.textAnio = new System.Windows.Forms.NumericUpDown();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelAnio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.labelRutEmisor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(97, 24);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(198, 22);
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
            // cancelarEmitido
            // 
            this.cancelarEmitido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarEmitido.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.cruzar;
            this.cancelarEmitido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarEmitido.Location = new System.Drawing.Point(590, 274);
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
            this.generarEmitidos.Location = new System.Drawing.Point(698, 274);
            this.generarEmitidos.Name = "generarEmitidos";
            this.generarEmitidos.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarEmitidos.Size = new System.Drawing.Size(102, 35);
            this.generarEmitidos.TabIndex = 14;
            this.generarEmitidos.Text = "Generar";
            this.generarEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarEmitidos.UseVisualStyleBackColor = true;
            this.generarEmitidos.Click += new System.EventHandler(this.generarEmitidos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRespuesta);
            this.groupBox3.Location = new System.Drawing.Point(339, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(471, 248);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // textRespuesta
            // 
            this.textRespuesta.Location = new System.Drawing.Point(8, 28);
            this.textRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.textRespuesta.Multiline = true;
            this.textRespuesta.Name = "textRespuesta";
            this.textRespuesta.Size = new System.Drawing.Size(453, 212);
            this.textRespuesta.TabIndex = 19;
            // 
            // textMes
            // 
            this.textMes.Location = new System.Drawing.Point(109, 84);
            this.textMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.textMes.Name = "textMes";
            this.textMes.Size = new System.Drawing.Size(125, 22);
            this.textMes.TabIndex = 3;
            // 
            // textAnio
            // 
            this.textAnio.Location = new System.Drawing.Point(109, 124);
            this.textAnio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textAnio.Name = "textAnio";
            this.textAnio.Size = new System.Drawing.Size(125, 22);
            this.textAnio.TabIndex = 25;
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(18, 84);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(45, 20);
            this.labelMes.TabIndex = 3;
            this.labelMes.Text = "Mes:";
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(18, 124);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(46, 20);
            this.labelAnio.TabIndex = 26;
            this.labelAnio.Text = "Anio:";
            // 
            // ConciliarEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 316);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.textAnio);
            this.Controls.Add(this.textMes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelarEmitido);
            this.Controls.Add(this.generarEmitidos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConciliarEmitidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliar Emitidos";
            this.Load += new System.EventHandler(this.ConciliarEmitidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarEmitido;
        private System.Windows.Forms.Button generarEmitidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label labelRutEmisor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textRespuesta;
        private System.Windows.Forms.NumericUpDown textMes;
        private System.Windows.Forms.NumericUpDown textAnio;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelAnio;
    }
}