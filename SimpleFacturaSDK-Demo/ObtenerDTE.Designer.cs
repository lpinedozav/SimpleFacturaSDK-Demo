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
            this.cancelarDte = new System.Windows.Forms.Button();
            this.consultarDTE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.tipodte_oDTE = new System.Windows.Forms.ComboBox();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ambiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioReutilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAcuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaTerceros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaPropio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalImpuestosAdicionales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarDte
            // 
            this.cancelarDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarDte.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.cruzar;
            this.cancelarDte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarDte.Location = new System.Drawing.Point(726, 567);
            this.cancelarDte.Name = "cancelarDte";
            this.cancelarDte.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.cancelarDte.Size = new System.Drawing.Size(102, 35);
            this.cancelarDte.TabIndex = 15;
            this.cancelarDte.Text = "Cancelar";
            this.cancelarDte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarDte.UseVisualStyleBackColor = true;
            this.cancelarDte.Click += new System.EventHandler(this.cancelarDte_Click);
            // 
            // consultarDTE
            // 
            this.consultarDTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarDTE.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.consultarDTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarDTE.Location = new System.Drawing.Point(834, 567);
            this.consultarDTE.Name = "consultarDTE";
            this.consultarDTE.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.consultarDTE.Size = new System.Drawing.Size(102, 35);
            this.consultarDTE.TabIndex = 14;
            this.consultarDTE.Text = "Consultar";
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
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 121);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dte Referenciado Externo";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(245, 66);
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
            this.radioCertificacion.Location = new System.Drawing.Point(125, 66);
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
            this.tipodte_oDTE.Name = "tipodte_oDTE";
            this.tipodte_oDTE.Size = new System.Drawing.Size(187, 24);
            this.tipodte_oDTE.TabIndex = 15;
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(124, 22);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(186, 22);
            this.folio_oPDF.TabIndex = 14;
            this.folio_oPDF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(413, 22);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo TipoDTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ambiente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(124, 28);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(351, 22);
            this.textRutEmisor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ambiente,
            this.folioReutilizado,
            this.importado,
            this.codigoSii,
            this.tipodte,
            this.estadoAcuse,
            this.estadoSII,
            this.fechaDte,
            this.fechaCreacion,
            this.folio,
            this.razonSocialReceptor,
            this.rutReceptor,
            this.trackId,
            this.neto,
            this.exento,
            this.iva,
            this.ivaTerceros,
            this.ivaPropio,
            this.totalImpuestosAdicionales,
            this.total,
            this.detalles});
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 317);
            this.dataGridView1.TabIndex = 16;
            // 
            // ambiente
            // 
            this.ambiente.HeaderText = "Ambiente";
            this.ambiente.MinimumWidth = 6;
            this.ambiente.Name = "ambiente";
            this.ambiente.ReadOnly = true;
            this.ambiente.Width = 80;
            // 
            // folioReutilizado
            // 
            this.folioReutilizado.HeaderText = "Folio reutilizado";
            this.folioReutilizado.MinimumWidth = 6;
            this.folioReutilizado.Name = "folioReutilizado";
            this.folioReutilizado.ReadOnly = true;
            this.folioReutilizado.Width = 80;
            // 
            // importado
            // 
            this.importado.HeaderText = "Importado";
            this.importado.MinimumWidth = 6;
            this.importado.Name = "importado";
            this.importado.ReadOnly = true;
            this.importado.Width = 80;
            // 
            // codigoSii
            // 
            this.codigoSii.HeaderText = "Codigo Sii";
            this.codigoSii.MinimumWidth = 6;
            this.codigoSii.Name = "codigoSii";
            this.codigoSii.ReadOnly = true;
            this.codigoSii.Width = 80;
            // 
            // tipodte
            // 
            this.tipodte.HeaderText = "Tipo Dte";
            this.tipodte.MinimumWidth = 6;
            this.tipodte.Name = "tipodte";
            this.tipodte.ReadOnly = true;
            this.tipodte.Width = 80;
            // 
            // estadoAcuse
            // 
            this.estadoAcuse.HeaderText = "Estado Acuse";
            this.estadoAcuse.MinimumWidth = 6;
            this.estadoAcuse.Name = "estadoAcuse";
            this.estadoAcuse.ReadOnly = true;
            this.estadoAcuse.Width = 80;
            // 
            // estadoSII
            // 
            this.estadoSII.HeaderText = "Estado Sii";
            this.estadoSII.MinimumWidth = 6;
            this.estadoSII.Name = "estadoSII";
            this.estadoSII.ReadOnly = true;
            this.estadoSII.Width = 80;
            // 
            // fechaDte
            // 
            this.fechaDte.HeaderText = "Fecha Dte";
            this.fechaDte.MinimumWidth = 6;
            this.fechaDte.Name = "fechaDte";
            this.fechaDte.ReadOnly = true;
            this.fechaDte.Width = 80;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha Creacion";
            this.fechaCreacion.MinimumWidth = 6;
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            this.fechaCreacion.Width = 80;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.MinimumWidth = 6;
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Width = 80;
            // 
            // razonSocialReceptor
            // 
            this.razonSocialReceptor.HeaderText = "Razon Social Receptor";
            this.razonSocialReceptor.MinimumWidth = 6;
            this.razonSocialReceptor.Name = "razonSocialReceptor";
            this.razonSocialReceptor.ReadOnly = true;
            this.razonSocialReceptor.Width = 80;
            // 
            // rutReceptor
            // 
            this.rutReceptor.HeaderText = "Rut Receptor";
            this.rutReceptor.MinimumWidth = 6;
            this.rutReceptor.Name = "rutReceptor";
            this.rutReceptor.ReadOnly = true;
            this.rutReceptor.Width = 80;
            // 
            // trackId
            // 
            this.trackId.HeaderText = "TrackId";
            this.trackId.MinimumWidth = 6;
            this.trackId.Name = "trackId";
            this.trackId.ReadOnly = true;
            this.trackId.Width = 80;
            // 
            // neto
            // 
            this.neto.HeaderText = "Neto";
            this.neto.MinimumWidth = 6;
            this.neto.Name = "neto";
            this.neto.ReadOnly = true;
            this.neto.Width = 80;
            // 
            // exento
            // 
            this.exento.HeaderText = "Exento";
            this.exento.MinimumWidth = 6;
            this.exento.Name = "exento";
            this.exento.ReadOnly = true;
            this.exento.Width = 80;
            // 
            // iva
            // 
            this.iva.HeaderText = "Iva";
            this.iva.MinimumWidth = 6;
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Width = 80;
            // 
            // ivaTerceros
            // 
            this.ivaTerceros.HeaderText = "IvaTerceros";
            this.ivaTerceros.MinimumWidth = 6;
            this.ivaTerceros.Name = "ivaTerceros";
            this.ivaTerceros.ReadOnly = true;
            this.ivaTerceros.Width = 80;
            // 
            // ivaPropio
            // 
            this.ivaPropio.HeaderText = "IvaPropio";
            this.ivaPropio.MinimumWidth = 6;
            this.ivaPropio.Name = "ivaPropio";
            this.ivaPropio.ReadOnly = true;
            this.ivaPropio.Width = 80;
            // 
            // totalImpuestosAdicionales
            // 
            this.totalImpuestosAdicionales.HeaderText = "Total Impuestos Adicionales";
            this.totalImpuestosAdicionales.MinimumWidth = 6;
            this.totalImpuestosAdicionales.Name = "totalImpuestosAdicionales";
            this.totalImpuestosAdicionales.ReadOnly = true;
            this.totalImpuestosAdicionales.Width = 80;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 80;
            // 
            // detalles
            // 
            this.detalles.HeaderText = "Detalles";
            this.detalles.MinimumWidth = 6;
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Width = 80;
            // 
            // ObtenerDTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelarDte);
            this.Controls.Add(this.consultarDTE);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObtenerDTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObtenerDTE";
            this.Load += new System.EventHandler(this.ObtenerDTE_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarDte;
        private System.Windows.Forms.Button consultarDTE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.ComboBox tipodte_oDTE;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioReutilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn importado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSii;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodte;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAcuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoSII;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDte;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn exento;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaTerceros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaPropio;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalImpuestosAdicionales;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles;
    }
}