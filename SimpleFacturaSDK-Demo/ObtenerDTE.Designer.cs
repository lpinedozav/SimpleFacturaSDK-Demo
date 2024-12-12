namespace SimpleFacturaSDK_Demo
{
    partial class ObtenerDTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerDTE));
            this.consultarDTE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.tipodte_oDTE = new System.Windows.Forms.ComboBox();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridResultado = new System.Windows.Forms.DataGridView();
            this.gridDetalles = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabelDTE = new System.Windows.Forms.LinkLabel();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultarDTE
            // 
            this.consultarDTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarDTE.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.consultarDTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarDTE.Location = new System.Drawing.Point(579, 754);
            this.consultarDTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consultarDTE.Name = "consultarDTE";
            this.consultarDTE.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.consultarDTE.Size = new System.Drawing.Size(101, 34);
            this.consultarDTE.TabIndex = 1;
            this.consultarDTE.Text = "Generar";
            this.consultarDTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consultarDTE.UseVisualStyleBackColor = true;
            this.consultarDTE.Click += new System.EventHandler(this.consultarDTE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.tipodte_oDTE);
            this.groupBox2.Controls.Add(this.folio_oPDF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(669, 102);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dte Referenciado Externo";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(245, 66);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(96, 20);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.Text = "Produccion";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(125, 66);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(101, 20);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // tipodte_oDTE
            // 
            this.tipodte_oDTE.FormattingEnabled = true;
            this.tipodte_oDTE.Location = new System.Drawing.Point(473, 22);
            this.tipodte_oDTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipodte_oDTE.Name = "tipodte_oDTE";
            this.tipodte_oDTE.Size = new System.Drawing.Size(187, 24);
            this.tipodte_oDTE.TabIndex = 15;
            this.tipodte_oDTE.TabStop = false;
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(113, 22);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(187, 22);
            this.folio_oPDF.TabIndex = 14;
            this.folio_oPDF.TabStop = false;
            this.folio_oPDF.Value = new decimal(new int[] {
            4117,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo TipoDTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ambiente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Folio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(669, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(124, 28);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(351, 22);
            this.textRutEmisor.TabIndex = 2;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // gridResultado
            // 
            this.gridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultado.Location = new System.Drawing.Point(12, 202);
            this.gridResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RowHeadersWidth = 51;
            this.gridResultado.RowTemplate.Height = 24;
            this.gridResultado.Size = new System.Drawing.Size(668, 270);
            this.gridResultado.TabIndex = 16;
            // 
            // gridDetalles
            // 
            this.gridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalles.Location = new System.Drawing.Point(12, 477);
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.RowHeadersWidth = 51;
            this.gridDetalles.RowTemplate.Height = 24;
            this.gridDetalles.Size = new System.Drawing.Size(668, 270);
            this.gridDetalles.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabelDTE);
            this.groupBox5.Controls.Add(this.textDocumentacion);
            this.groupBox5.Location = new System.Drawing.Point(12, 754);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(561, 117);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            // 
            // linkLabelDTE
            // 
            this.linkLabelDTE.AutoSize = true;
            this.linkLabelDTE.Location = new System.Drawing.Point(12, -2);
            this.linkLabelDTE.Name = "linkLabelDTE";
            this.linkLabelDTE.Size = new System.Drawing.Size(101, 16);
            this.linkLabelDTE.TabIndex = 41;
            this.linkLabelDTE.TabStop = true;
            this.linkLabelDTE.Text = "Documentación";
            this.linkLabelDTE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDTE_LinkClicked);
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(8, 23);
            this.textDocumentacion.Margin = new System.Windows.Forms.Padding(4);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(545, 86);
            this.textDocumentacion.TabIndex = 20;
            this.textDocumentacion.Text = resources.GetString("textDocumentacion.Text");
            // 
            // ObtenerDTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 880);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gridDetalles);
            this.Controls.Add(this.gridResultado);
            this.Controls.Add(this.consultarDTE);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObtenerDTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener DTE";
            this.Load += new System.EventHandler(this.ObtenerDTE_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button consultarDTE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.ComboBox tipodte_oDTE;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridResultado;
        private System.Windows.Forms.DataGridView gridDetalles;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabelDTE;
        private System.Windows.Forms.TextBox textDocumentacion;
    }
}