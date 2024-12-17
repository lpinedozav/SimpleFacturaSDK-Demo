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
            this.Propiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.consultarDTE.Location = new System.Drawing.Point(435, 680);
            this.consultarDTE.Margin = new System.Windows.Forms.Padding(2);
            this.consultarDTE.Name = "consultarDTE";
            this.consultarDTE.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.consultarDTE.Size = new System.Drawing.Size(76, 28);
            this.consultarDTE.TabIndex = 1;
            this.consultarDTE.Text = "Obtener";
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
            this.groupBox2.Location = new System.Drawing.Point(9, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(502, 83);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dte Referenciado Externo";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(184, 54);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(79, 17);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(94, 54);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // tipodte_oDTE
            // 
            this.tipodte_oDTE.FormattingEnabled = true;
            this.tipodte_oDTE.Location = new System.Drawing.Point(355, 18);
            this.tipodte_oDTE.Margin = new System.Windows.Forms.Padding(2);
            this.tipodte_oDTE.Name = "tipodte_oDTE";
            this.tipodte_oDTE.Size = new System.Drawing.Size(141, 21);
            this.tipodte_oDTE.TabIndex = 15;
            this.tipodte_oDTE.TabStop = false;
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(85, 18);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(140, 20);
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
            this.label5.Location = new System.Drawing.Point(237, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código TipoDTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ambiente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Folio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(502, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(93, 23);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(264, 20);
            this.textRutEmisor.TabIndex = 2;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // gridResultado
            // 
            this.gridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Propiedad,
            this.Valor});
            this.gridResultado.Location = new System.Drawing.Point(9, 164);
            this.gridResultado.Margin = new System.Windows.Forms.Padding(2);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RowHeadersVisible = false;
            this.gridResultado.RowHeadersWidth = 51;
            this.gridResultado.RowTemplate.Height = 24;
            this.gridResultado.Size = new System.Drawing.Size(501, 219);
            this.gridResultado.TabIndex = 16;
            // 
            // Propiedad
            // 
            this.Propiedad.HeaderText = "Propiedad";
            this.Propiedad.Name = "Propiedad";
            this.Propiedad.Width = 247;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 247;
            // 
            // gridDetalles
            // 
            this.gridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalles.Location = new System.Drawing.Point(9, 388);
            this.gridDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.RowHeadersWidth = 51;
            this.gridDetalles.RowTemplate.Height = 24;
            this.gridDetalles.Size = new System.Drawing.Size(501, 219);
            this.gridDetalles.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabelDTE);
            this.groupBox5.Controls.Add(this.textDocumentacion);
            this.groupBox5.Location = new System.Drawing.Point(9, 613);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(421, 95);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            // 
            // linkLabelDTE
            // 
            this.linkLabelDTE.AutoSize = true;
            this.linkLabelDTE.Location = new System.Drawing.Point(9, -2);
            this.linkLabelDTE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelDTE.Name = "linkLabelDTE";
            this.linkLabelDTE.Size = new System.Drawing.Size(82, 13);
            this.linkLabelDTE.TabIndex = 41;
            this.linkLabelDTE.TabStop = true;
            this.linkLabelDTE.Text = "Documentación";
            this.linkLabelDTE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDTE_LinkClicked);
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(6, 19);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(410, 71);
            this.textDocumentacion.TabIndex = 20;
            this.textDocumentacion.Text = resources.GetString("textDocumentacion.Text");
            // 
            // ObtenerDTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 715);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gridDetalles);
            this.Controls.Add(this.gridResultado);
            this.Controls.Add(this.consultarDTE);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Propiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}