namespace SimpleFacturaSDK_Demo
{
    partial class ListadoDteEmitidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoDteEmitidos));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.ambiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioreutilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigosii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoacuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialreceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutreceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCodigoTipoDTE = new System.Windows.Forms.ComboBox();
            this.numericFolio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.hasta = new System.Windows.Forms.Label();
            this.ambientelabel = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generarListaDTE = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(314, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 280);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.AllowUserToResizeColumns = false;
            this.gridResultados.AllowUserToResizeRows = false;
            this.gridResultados.ColumnHeadersHeight = 29;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ambiente,
            this.folioreutilizado,
            this.importado,
            this.codigosii,
            this.tipodte,
            this.estadoacuse,
            this.fechadte,
            this.folio,
            this.razonsocialreceptor,
            this.rutreceptor,
            this.trackid,
            this.estadosii,
            this.neto,
            this.exento,
            this.iva,
            this.total,
            this.detalles});
            this.gridResultados.Location = new System.Drawing.Point(6, 25);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(431, 248);
            this.gridResultados.TabIndex = 0;
            // 
            // ambiente
            // 
            this.ambiente.HeaderText = "Ambiente";
            this.ambiente.MinimumWidth = 6;
            this.ambiente.Name = "ambiente";
            this.ambiente.ReadOnly = true;
            this.ambiente.Width = 70;
            // 
            // folioreutilizado
            // 
            this.folioreutilizado.HeaderText = "Folio reutilizado";
            this.folioreutilizado.MinimumWidth = 6;
            this.folioreutilizado.Name = "folioreutilizado";
            this.folioreutilizado.ReadOnly = true;
            this.folioreutilizado.Width = 90;
            // 
            // importado
            // 
            this.importado.HeaderText = "Importado";
            this.importado.MinimumWidth = 6;
            this.importado.Name = "importado";
            this.importado.ReadOnly = true;
            this.importado.Width = 60;
            // 
            // codigosii
            // 
            this.codigosii.HeaderText = "Codigo Sii";
            this.codigosii.MinimumWidth = 6;
            this.codigosii.Name = "codigosii";
            this.codigosii.ReadOnly = true;
            this.codigosii.Width = 60;
            // 
            // tipodte
            // 
            this.tipodte.HeaderText = "Tipo dte";
            this.tipodte.MinimumWidth = 6;
            this.tipodte.Name = "tipodte";
            this.tipodte.ReadOnly = true;
            this.tipodte.Width = 125;
            // 
            // estadoacuse
            // 
            this.estadoacuse.HeaderText = "Estado acuse";
            this.estadoacuse.MinimumWidth = 6;
            this.estadoacuse.Name = "estadoacuse";
            this.estadoacuse.ReadOnly = true;
            this.estadoacuse.Width = 80;
            // 
            // fechadte
            // 
            this.fechadte.HeaderText = "Fecha dte";
            this.fechadte.MinimumWidth = 6;
            this.fechadte.Name = "fechadte";
            this.fechadte.ReadOnly = true;
            this.fechadte.Width = 65;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.MinimumWidth = 6;
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Width = 45;
            // 
            // razonsocialreceptor
            // 
            this.razonsocialreceptor.HeaderText = "Razon social receptor";
            this.razonsocialreceptor.MinimumWidth = 6;
            this.razonsocialreceptor.Name = "razonsocialreceptor";
            this.razonsocialreceptor.ReadOnly = true;
            this.razonsocialreceptor.Width = 125;
            // 
            // rutreceptor
            // 
            this.rutreceptor.HeaderText = "Rut receptor";
            this.rutreceptor.MinimumWidth = 6;
            this.rutreceptor.Name = "rutreceptor";
            this.rutreceptor.ReadOnly = true;
            this.rutreceptor.Width = 75;
            // 
            // trackid
            // 
            this.trackid.HeaderText = "Track id";
            this.trackid.MinimumWidth = 6;
            this.trackid.Name = "trackid";
            this.trackid.ReadOnly = true;
            this.trackid.Width = 75;
            // 
            // estadosii
            // 
            this.estadosii.HeaderText = "Estado Sii";
            this.estadosii.MinimumWidth = 6;
            this.estadosii.Name = "estadosii";
            this.estadosii.ReadOnly = true;
            this.estadosii.Width = 125;
            // 
            // neto
            // 
            this.neto.HeaderText = "Neto";
            this.neto.MinimumWidth = 6;
            this.neto.Name = "neto";
            this.neto.ReadOnly = true;
            this.neto.Width = 65;
            // 
            // exento
            // 
            this.exento.HeaderText = "Exento";
            this.exento.MinimumWidth = 6;
            this.exento.Name = "exento";
            this.exento.ReadOnly = true;
            this.exento.Width = 65;
            // 
            // iva
            // 
            this.iva.HeaderText = "Iva";
            this.iva.MinimumWidth = 6;
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Width = 65;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 65;
            // 
            // detalles
            // 
            this.detalles.HeaderText = "Detalles";
            this.detalles.MinimumWidth = 6;
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Width = 85;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxCodigoTipoDTE);
            this.groupBox2.Controls.Add(this.numericFolio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimeHasta);
            this.groupBox2.Controls.Add(this.dateTimeDesde);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.hasta);
            this.groupBox2.Controls.Add(this.ambientelabel);
            this.groupBox2.Controls.Add(this.desde);
            this.groupBox2.Location = new System.Drawing.Point(15, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(287, 185);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // comboBoxCodigoTipoDTE
            // 
            this.comboBoxCodigoTipoDTE.FormattingEnabled = true;
            this.comboBoxCodigoTipoDTE.Location = new System.Drawing.Point(94, 48);
            this.comboBoxCodigoTipoDTE.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCodigoTipoDTE.Name = "comboBoxCodigoTipoDTE";
            this.comboBoxCodigoTipoDTE.Size = new System.Drawing.Size(141, 21);
            this.comboBoxCodigoTipoDTE.TabIndex = 23;
            this.comboBoxCodigoTipoDTE.TabStop = false;
            // 
            // numericFolio
            // 
            this.numericFolio.Location = new System.Drawing.Point(94, 22);
            this.numericFolio.Margin = new System.Windows.Forms.Padding(2);
            this.numericFolio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFolio.Name = "numericFolio";
            this.numericFolio.Size = new System.Drawing.Size(140, 20);
            this.numericFolio.TabIndex = 22;
            this.numericFolio.TabStop = false;
            this.numericFolio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Codigo TipoDTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Folio:";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(93, 107);
            this.dateTimeHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(142, 20);
            this.dateTimeHasta.TabIndex = 19;
            this.dateTimeHasta.TabStop = false;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(93, 76);
            this.dateTimeDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(142, 20);
            this.dateTimeDesde.TabIndex = 18;
            this.dateTimeDesde.TabStop = false;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(182, 141);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(79, 17);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.Text = "Produccion";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Location = new System.Drawing.Point(94, 141);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(4, 112);
            this.hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(38, 13);
            this.hasta.TabIndex = 8;
            this.hasta.Text = "Hasta:";
            // 
            // ambientelabel
            // 
            this.ambientelabel.AutoSize = true;
            this.ambientelabel.Location = new System.Drawing.Point(5, 142);
            this.ambientelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ambientelabel.Name = "ambientelabel";
            this.ambientelabel.Size = new System.Drawing.Size(54, 13);
            this.ambientelabel.TabIndex = 5;
            this.ambientelabel.Text = "Ambiente:";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(4, 80);
            this.desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(41, 13);
            this.desde.TabIndex = 4;
            this.desde.Text = "Desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(287, 89);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(93, 53);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(181, 20);
            this.textNombreSucursal.TabIndex = 3;
            this.textNombreSucursal.TabStop = false;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(93, 23);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(181, 20);
            this.textRutEmisor.TabIndex = 2;
            this.textRutEmisor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut emisor:";
            // 
            // generarListaDTE
            // 
            this.generarListaDTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarListaDTE.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarListaDTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarListaDTE.Location = new System.Drawing.Point(675, 291);
            this.generarListaDTE.Margin = new System.Windows.Forms.Padding(2);
            this.generarListaDTE.Name = "generarListaDTE";
            this.generarListaDTE.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarListaDTE.Size = new System.Drawing.Size(76, 28);
            this.generarListaDTE.TabIndex = 1;
            this.generarListaDTE.Text = "Generar";
            this.generarListaDTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarListaDTE.UseVisualStyleBackColor = true;
            this.generarListaDTE.Click += new System.EventHandler(this.generarListaDTE_Click);
            // 
            // ListadoDteEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarListaDTE);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoDteEmitidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoDteEmitidos";
            this.Load += new System.EventHandler(this.ListadoDteEmitidos_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.Button generarListaDTE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label ambientelabel;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCodigoTipoDTE;
        private System.Windows.Forms.NumericUpDown numericFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioreutilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn importado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigosii;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodte;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoacuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadte;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialreceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutreceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackid;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosii;
        private System.Windows.Forms.DataGridViewTextBoxColumn neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn exento;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn detalles;
    }
}