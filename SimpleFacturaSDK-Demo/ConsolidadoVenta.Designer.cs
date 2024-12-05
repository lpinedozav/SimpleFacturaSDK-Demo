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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolidadoVenta));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.hasta = new System.Windows.Forms.Label();
            this.ambiente = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generarConsolidadoV = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridConsolidado = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anulados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalneto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalexento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaliva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsolidado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimeHasta);
            this.groupBox2.Controls.Add(this.dateTimeDesde);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.hasta);
            this.groupBox2.Controls.Add(this.ambiente);
            this.groupBox2.Controls.Add(this.desde);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 79);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(317, 33);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(132, 22);
            this.dateTimeHasta.TabIndex = 19;
            this.dateTimeHasta.Value = new System.DateTime(2023, 10, 30, 10, 23, 0, 0);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(77, 33);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(130, 22);
            this.dateTimeDesde.TabIndex = 18;
            this.dateTimeDesde.Value = new System.DateTime(2023, 10, 25, 10, 23, 0, 0);
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(716, 32);
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
            this.radioCertificacion.Location = new System.Drawing.Point(596, 32);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(101, 20);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(413, 22);
            this.textBox5.TabIndex = 9;
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(243, 36);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(46, 16);
            this.hasta.TabIndex = 8;
            this.hasta.Text = "Hasta:";
            // 
            // ambiente
            // 
            this.ambiente.AutoSize = true;
            this.ambiente.Location = new System.Drawing.Point(493, 34);
            this.ambiente.Name = "ambiente";
            this.ambiente.Size = new System.Drawing.Size(67, 16);
            this.ambiente.TabIndex = 5;
            this.ambiente.Text = "Ambiente:";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(6, 34);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(51, 16);
            this.desde.TabIndex = 4;
            this.desde.Text = "Desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(100, 29);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(216, 22);
            this.textRutEmisor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // generarConsolidadoV
            // 
            this.generarConsolidadoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarConsolidadoV.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarConsolidadoV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarConsolidadoV.Location = new System.Drawing.Point(731, 543);
            this.generarConsolidadoV.Name = "generarConsolidadoV";
            this.generarConsolidadoV.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarConsolidadoV.Size = new System.Drawing.Size(102, 35);
            this.generarConsolidadoV.TabIndex = 14;
            this.generarConsolidadoV.Text = "Generar";
            this.generarConsolidadoV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarConsolidadoV.UseVisualStyleBackColor = true;
            this.generarConsolidadoV.Click += new System.EventHandler(this.generarConsolidadoV_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridConsolidado);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(821, 324);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // dataGridConsolidado
            // 
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
            this.dataGridConsolidado.Location = new System.Drawing.Point(9, 32);
            this.dataGridConsolidado.Name = "dataGridConsolidado";
            this.dataGridConsolidado.RowHeadersWidth = 51;
            this.dataGridConsolidado.RowTemplate.Height = 24;
            this.dataGridConsolidado.Size = new System.Drawing.Size(803, 277);
            this.dataGridConsolidado.TabIndex = 17;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // tipodte
            // 
            this.tipodte.HeaderText = "Tipoe DTE";
            this.tipodte.MinimumWidth = 6;
            this.tipodte.Name = "tipodte";
            this.tipodte.Width = 125;
            // 
            // emitidos
            // 
            this.emitidos.HeaderText = "Emitidos";
            this.emitidos.MinimumWidth = 6;
            this.emitidos.Name = "emitidos";
            this.emitidos.Width = 125;
            // 
            // anulados
            // 
            this.anulados.HeaderText = "Anulados";
            this.anulados.MinimumWidth = 6;
            this.anulados.Name = "anulados";
            this.anulados.Width = 125;
            // 
            // totalneto
            // 
            this.totalneto.HeaderText = "Total Neto";
            this.totalneto.MinimumWidth = 6;
            this.totalneto.Name = "totalneto";
            this.totalneto.Width = 125;
            // 
            // totalexento
            // 
            this.totalexento.HeaderText = "Total Exento";
            this.totalexento.MinimumWidth = 6;
            this.totalexento.Name = "totalexento";
            this.totalexento.Width = 125;
            // 
            // totaliva
            // 
            this.totaliva.HeaderText = "Total Iva";
            this.totaliva.MinimumWidth = 6;
            this.totaliva.Name = "totaliva";
            this.totaliva.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.Width = 125;
            // 
            // ConsolidadoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 589);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarConsolidadoV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsolidadoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consolidado de Ventas";
            this.Load += new System.EventHandler(this.ConsolidadoVenta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsolidado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generarConsolidadoV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label ambiente;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridConsolidado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodte;
        private System.Windows.Forms.DataGridViewTextBoxColumn emitidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn anulados;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalneto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalexento;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaliva;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
    }
}