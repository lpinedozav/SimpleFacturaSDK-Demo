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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoDteEmitidos));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.gridFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTipoDte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmitido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipodte_ListEmitidos = new System.Windows.Forms.ComboBox();
            this.folio_ListEmitido = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.hasta = new System.Windows.Forms.Label();
            this.ambiente = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRutContribuyente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generarpdf = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_ListEmitido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(419, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(593, 251);
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
            this.gridFecha,
            this.gridTipoDte,
            this.gridEmitido,
            this.totalNeto,
            this.gridTotal});
            this.gridResultados.Location = new System.Drawing.Point(8, 31);
            this.gridResultados.Margin = new System.Windows.Forms.Padding(4);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(575, 198);
            this.gridResultados.TabIndex = 0;
            // 
            // gridFecha
            // 
            this.gridFecha.DataPropertyName = "Fecha";
            this.gridFecha.HeaderText = "Fecha";
            this.gridFecha.MinimumWidth = 6;
            this.gridFecha.Name = "gridFecha";
            this.gridFecha.ReadOnly = true;
            this.gridFecha.Width = 200;
            // 
            // gridTipoDte
            // 
            this.gridTipoDte.DataPropertyName = "TipoDte";
            dataGridViewCellStyle1.Format = "N1";
            this.gridTipoDte.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridTipoDte.HeaderText = "TipoDte";
            this.gridTipoDte.MinimumWidth = 6;
            this.gridTipoDte.Name = "gridTipoDte";
            this.gridTipoDte.ReadOnly = true;
            this.gridTipoDte.Width = 70;
            // 
            // gridEmitido
            // 
            this.gridEmitido.DataPropertyName = "Emitidos";
            dataGridViewCellStyle2.Format = "N0";
            this.gridEmitido.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmitido.HeaderText = "Emitidos";
            this.gridEmitido.MinimumWidth = 6;
            this.gridEmitido.Name = "gridEmitido";
            this.gridEmitido.ReadOnly = true;
            this.gridEmitido.Width = 75;
            // 
            // totalNeto
            // 
            this.totalNeto.DataPropertyName = "TotalNeto";
            this.totalNeto.HeaderText = "TotalNeto";
            this.totalNeto.MinimumWidth = 6;
            this.totalNeto.Name = "totalNeto";
            this.totalNeto.ReadOnly = true;
            this.totalNeto.Width = 125;
            // 
            // gridTotal
            // 
            this.gridTotal.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "N0";
            this.gridTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridTotal.HeaderText = "Total";
            this.gridTotal.MinimumWidth = 6;
            this.gridTotal.Name = "gridTotal";
            this.gridTotal.ReadOnly = true;
            this.gridTotal.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tipodte_ListEmitidos);
            this.groupBox2.Controls.Add(this.folio_ListEmitido);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimeHasta);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.hasta);
            this.groupBox2.Controls.Add(this.ambiente);
            this.groupBox2.Controls.Add(this.desde);
            this.groupBox2.Location = new System.Drawing.Point(20, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 228);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // tipodte_ListEmitidos
            // 
            this.tipodte_ListEmitidos.FormattingEnabled = true;
            this.tipodte_ListEmitidos.Location = new System.Drawing.Point(125, 59);
            this.tipodte_ListEmitidos.Name = "tipodte_ListEmitidos";
            this.tipodte_ListEmitidos.Size = new System.Drawing.Size(187, 24);
            this.tipodte_ListEmitidos.TabIndex = 23;
            // 
            // folio_ListEmitido
            // 
            this.folio_ListEmitido.Location = new System.Drawing.Point(126, 27);
            this.folio_ListEmitido.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_ListEmitido.Name = "folio_ListEmitido";
            this.folio_ListEmitido.Size = new System.Drawing.Size(186, 22);
            this.folio_ListEmitido.TabIndex = 22;
            this.folio_ListEmitido.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Codigo TipoDTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Folio:";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(124, 132);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(188, 22);
            this.dateTimeHasta.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(242, 173);
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
            this.radioCertificacion.Location = new System.Drawing.Point(125, 173);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(101, 20);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificacion";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(6, 138);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(46, 16);
            this.hasta.TabIndex = 8;
            this.hasta.Text = "Hasta:";
            // 
            // ambiente
            // 
            this.ambiente.AutoSize = true;
            this.ambiente.Location = new System.Drawing.Point(7, 175);
            this.ambiente.Name = "ambiente";
            this.ambiente.Size = new System.Drawing.Size(67, 16);
            this.ambiente.TabIndex = 5;
            this.ambiente.Text = "Ambiente:";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(6, 99);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(51, 16);
            this.desde.TabIndex = 4;
            this.desde.Text = "Desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRutContribuyente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 172);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textRutContribuyente
            // 
            this.textRutContribuyente.Location = new System.Drawing.Point(124, 64);
            this.textRutContribuyente.Name = "textRutContribuyente";
            this.textRutContribuyente.Size = new System.Drawing.Size(240, 22);
            this.textRutContribuyente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rut contribuyente:";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(124, 105);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(240, 22);
            this.textNombreSucursal.TabIndex = 3;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(124, 28);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(240, 22);
            this.textRutEmisor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut emisor:";
            // 
            // generarpdf
            // 
            this.generarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarpdf.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarpdf.Location = new System.Drawing.Point(900, 386);
            this.generarpdf.Name = "generarpdf";
            this.generarpdf.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarpdf.Size = new System.Drawing.Size(102, 35);
            this.generarpdf.TabIndex = 21;
            this.generarpdf.Text = "Generar";
            this.generarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarpdf.UseVisualStyleBackColor = true;
            // 
            // ListadoDteEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarpdf);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoDteEmitidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoDteEmitidos";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_ListEmitido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTipoDte;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTotal;
        private System.Windows.Forms.Button generarpdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label ambiente;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRutContribuyente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipodte_ListEmitidos;
        private System.Windows.Forms.NumericUpDown folio_ListEmitido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}