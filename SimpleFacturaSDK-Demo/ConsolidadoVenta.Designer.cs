namespace SimpleFacturaSDK_Demo
{
    partial class ConsolidadoVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolidadoVenta));
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.hasta = new System.Windows.Forms.Label();
            this.ambiente = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generarConsolidadoV = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridConsolidado = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabelConsolidado = new System.Windows.Forms.LinkLabel();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anulados = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalneto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalexento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaliva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsolidado)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(340, 24);
            this.dateTimeHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(100, 20);
            this.dateTimeHasta.TabIndex = 19;
            this.dateTimeHasta.TabStop = false;
            this.dateTimeHasta.Value = new System.DateTime(2023, 10, 30, 10, 23, 0, 0);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(198, 24);
            this.dateTimeDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(98, 20);
            this.dateTimeDesde.TabIndex = 18;
            this.dateTimeDesde.TabStop = false;
            this.dateTimeDesde.Value = new System.DateTime(2023, 10, 25, 10, 23, 0, 0);
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(585, 25);
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
            this.radioCertificacion.Location = new System.Drawing.Point(499, 25);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(299, 28);
            this.hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(38, 13);
            this.hasta.TabIndex = 8;
            this.hasta.Text = "Hasta:";
            // 
            // ambiente
            // 
            this.ambiente.AutoSize = true;
            this.ambiente.Location = new System.Drawing.Point(443, 27);
            this.ambiente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ambiente.Name = "ambiente";
            this.ambiente.Size = new System.Drawing.Size(54, 13);
            this.ambiente.TabIndex = 5;
            this.ambiente.Text = "Ambiente:";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(151, 28);
            this.desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(41, 13);
            this.desde.TabIndex = 4;
            this.desde.Text = "Desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioProduccion);
            this.groupBox1.Controls.Add(this.dateTimeHasta);
            this.groupBox1.Controls.Add(this.radioCertificacion);
            this.groupBox1.Controls.Add(this.textRut);
            this.groupBox1.Controls.Add(this.dateTimeDesde);
            this.groupBox1.Controls.Add(this.ambiente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.desde);
            this.groupBox1.Controls.Add(this.hasta);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(685, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Consulta";
            // 
            // textRut
            // 
            this.textRut.Location = new System.Drawing.Point(68, 24);
            this.textRut.Margin = new System.Windows.Forms.Padding(2);
            this.textRut.Name = "textRut";
            this.textRut.Size = new System.Drawing.Size(81, 20);
            this.textRut.TabIndex = 2;
            this.textRut.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // generarConsolidadoV
            // 
            this.generarConsolidadoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarConsolidadoV.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarConsolidadoV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarConsolidadoV.Location = new System.Drawing.Point(619, 376);
            this.generarConsolidadoV.Margin = new System.Windows.Forms.Padding(2);
            this.generarConsolidadoV.Name = "generarConsolidadoV";
            this.generarConsolidadoV.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarConsolidadoV.Size = new System.Drawing.Size(75, 35);
            this.generarConsolidadoV.TabIndex = 1;
            this.generarConsolidadoV.Text = "Ejecutar";
            this.generarConsolidadoV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarConsolidadoV.UseVisualStyleBackColor = true;
            this.generarConsolidadoV.Click += new System.EventHandler(this.generarConsolidadoV_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridConsolidado);
            this.groupBox3.Location = new System.Drawing.Point(9, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 263);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // dataGridConsolidado
            // 
            this.dataGridConsolidado.AllowUserToAddRows = false;
            this.dataGridConsolidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsolidado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.tipodte,
            this.emitidos,
            this.anulados,
            this.totalneto,
            this.totalexento,
            this.totaliva,
            this.total,
            this.detalle});
            this.dataGridConsolidado.Location = new System.Drawing.Point(7, 26);
            this.dataGridConsolidado.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridConsolidado.Name = "dataGridConsolidado";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridConsolidado.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridConsolidado.RowHeadersWidth = 20;
            this.dataGridConsolidado.RowTemplate.Height = 24;
            this.dataGridConsolidado.Size = new System.Drawing.Size(671, 225);
            this.dataGridConsolidado.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabelConsolidado);
            this.groupBox4.Controls.Add(this.textDocumentacion);
            this.groupBox4.Location = new System.Drawing.Point(9, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(607, 63);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // linkLabelConsolidado
            // 
            this.linkLabelConsolidado.AutoSize = true;
            this.linkLabelConsolidado.Location = new System.Drawing.Point(9, -2);
            this.linkLabelConsolidado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelConsolidado.Name = "linkLabelConsolidado";
            this.linkLabelConsolidado.Size = new System.Drawing.Size(82, 13);
            this.linkLabelConsolidado.TabIndex = 41;
            this.linkLabelConsolidado.TabStop = true;
            this.linkLabelConsolidado.Text = "Documentación";
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(6, 19);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(595, 35);
            this.textDocumentacion.TabIndex = 20;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 64;
            // 
            // tipodte
            // 
            this.tipodte.DataPropertyName = "tiposDTE";
            this.tipodte.HeaderText = "Tipos DTE";
            this.tipodte.MinimumWidth = 6;
            this.tipodte.Name = "tipodte";
            this.tipodte.Width = 92;
            // 
            // emitidos
            // 
            this.emitidos.DataPropertyName = "emitidos";
            this.emitidos.HeaderText = "Emitidos";
            this.emitidos.MinimumWidth = 6;
            this.emitidos.Name = "emitidos";
            this.emitidos.Width = 52;
            // 
            // anulados
            // 
            this.anulados.DataPropertyName = "anulados";
            this.anulados.HeaderText = "Anulados";
            this.anulados.MinimumWidth = 6;
            this.anulados.Name = "anulados";
            this.anulados.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anulados.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.anulados.Width = 54;
            // 
            // totalneto
            // 
            this.totalneto.DataPropertyName = "totalNeto";
            this.totalneto.HeaderText = "Total Neto";
            this.totalneto.Name = "totalneto";
            this.totalneto.Width = 85;
            // 
            // totalexento
            // 
            this.totalexento.DataPropertyName = "totalExento";
            this.totalexento.HeaderText = "Total Exento";
            this.totalexento.MinimumWidth = 6;
            this.totalexento.Name = "totalexento";
            this.totalexento.Width = 95;
            // 
            // totaliva
            // 
            this.totaliva.DataPropertyName = "totalIva";
            this.totaliva.HeaderText = "Total Iva";
            this.totaliva.MinimumWidth = 6;
            this.totaliva.Name = "totaliva";
            this.totaliva.Width = 55;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 75;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detalle.Width = 70;
            // 
            // ConsolidadoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 421);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarConsolidadoV);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsolidadoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consolidado de Ventas";
            this.Load += new System.EventHandler(this.ConsolidadoVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsolidado)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generarConsolidadoV;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label ambiente;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridConsolidado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabelConsolidado;
        private System.Windows.Forms.TextBox textDocumentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodte;
        private System.Windows.Forms.DataGridViewTextBoxColumn emitidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anulados;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalneto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalexento;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaliva;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn detalle;
    }
}