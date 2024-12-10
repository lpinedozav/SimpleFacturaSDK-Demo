namespace SimpleFacturaSDK_Demo
{
    partial class ListadoBhe_Emitida_Recibida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoBhe_Emitida_Recibida));
            this.radioButton_recibidoPdf = new System.Windows.Forms.RadioButton();
            this.radioButton_emitidoPdf = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folio_oPDF = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generarpdf = new System.Windows.Forms.Button();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.hasta = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionAnulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.TotalHonorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_recibidoPdf
            // 
            this.radioButton_recibidoPdf.Location = new System.Drawing.Point(86, 9);
            this.radioButton_recibidoPdf.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_recibidoPdf.Name = "radioButton_recibidoPdf";
            this.radioButton_recibidoPdf.Size = new System.Drawing.Size(69, 15);
            this.radioButton_recibidoPdf.TabIndex = 45;
            this.radioButton_recibidoPdf.Text = "Recibido";
            this.radioButton_recibidoPdf.UseVisualStyleBackColor = true;
            // 
            // radioButton_emitidoPdf
            // 
            this.radioButton_emitidoPdf.Checked = true;
            this.radioButton_emitidoPdf.Location = new System.Drawing.Point(11, 9);
            this.radioButton_emitidoPdf.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_emitidoPdf.Name = "radioButton_emitidoPdf";
            this.radioButton_emitidoPdf.Size = new System.Drawing.Size(69, 15);
            this.radioButton_emitidoPdf.TabIndex = 44;
            this.radioButton_emitidoPdf.TabStop = true;
            this.radioButton_emitidoPdf.Text = "Emitido";
            this.radioButton_emitidoPdf.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeHasta);
            this.groupBox1.Controls.Add(this.dateTimeDesde);
            this.groupBox1.Controls.Add(this.hasta);
            this.groupBox1.Controls.Add(this.desde);
            this.groupBox1.Controls.Add(this.folio_oPDF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(470, 122);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Consulta";
            // 
            // folio_oPDF
            // 
            this.folio_oPDF.Location = new System.Drawing.Point(100, 82);
            this.folio_oPDF.Margin = new System.Windows.Forms.Padding(2);
            this.folio_oPDF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oPDF.Name = "folio_oPDF";
            this.folio_oPDF.Size = new System.Drawing.Size(141, 20);
            this.folio_oPDF.TabIndex = 6;
            this.folio_oPDF.TabStop = false;
            this.folio_oPDF.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Folio:";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(101, 54);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(140, 20);
            this.textNombreSucursal.TabIndex = 5;
            this.textNombreSucursal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre sucursal:";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(100, 27);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(140, 20);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // generarpdf
            // 
            this.generarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarpdf.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarpdf.Location = new System.Drawing.Point(405, 704);
            this.generarpdf.Margin = new System.Windows.Forms.Padding(2);
            this.generarpdf.Name = "generarpdf";
            this.generarpdf.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarpdf.Size = new System.Drawing.Size(76, 28);
            this.generarpdf.TabIndex = 46;
            this.generarpdf.Text = "Generar";
            this.generarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarpdf.UseVisualStyleBackColor = true;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(307, 54);
            this.dateTimeHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(100, 20);
            this.dateTimeHasta.TabIndex = 23;
            this.dateTimeHasta.TabStop = false;
            this.dateTimeHasta.Value = new System.DateTime(2024, 11, 11, 0, 0, 0, 0);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(307, 27);
            this.dateTimeDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(98, 20);
            this.dateTimeDesde.TabIndex = 22;
            this.dateTimeDesde.TabStop = false;
            this.dateTimeDesde.Value = new System.DateTime(2024, 9, 3, 0, 0, 0, 0);
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(251, 59);
            this.hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(38, 13);
            this.hasta.TabIndex = 21;
            this.hasta.Text = "Hasta:";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(251, 31);
            this.desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(41, 13);
            this.desde.TabIndex = 20;
            this.desde.Text = "Desde:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(11, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 130);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
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
            this.folio,
            this.fechaEmision,
            this.codigoBarra,
            this.estado,
            this.descripcionAnulacion});
            this.gridResultados.Location = new System.Drawing.Point(7, 13);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(454, 111);
            this.gridResultados.TabIndex = 0;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Width = 50;
            // 
            // fechaEmision
            // 
            this.fechaEmision.DataPropertyName = "fechaEmision";
            this.fechaEmision.HeaderText = "Fecha Emision";
            this.fechaEmision.MinimumWidth = 6;
            this.fechaEmision.Name = "fechaEmision";
            this.fechaEmision.ReadOnly = true;
            this.fechaEmision.Width = 97;
            // 
            // codigoBarra
            // 
            this.codigoBarra.DataPropertyName = "codigoBarra";
            dataGridViewCellStyle1.Format = "N0";
            this.codigoBarra.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigoBarra.HeaderText = "Codigo Barra";
            this.codigoBarra.MinimumWidth = 6;
            this.codigoBarra.Name = "codigoBarra";
            this.codigoBarra.ReadOnly = true;
            this.codigoBarra.Width = 90;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 60;
            // 
            // descripcionAnulacion
            // 
            this.descripcionAnulacion.HeaderText = "Descr Anulación";
            this.descripcionAnulacion.Name = "descripcionAnulacion";
            this.descripcionAnulacion.ReadOnly = true;
            this.descripcionAnulacion.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 130);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emisor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.direccion,
            this.razonSocial});
            this.dataGridView1.Location = new System.Drawing.Point(7, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(454, 111);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(11, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 130);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receptor";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(7, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 25;
            this.dataGridView2.Size = new System.Drawing.Size(454, 111);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Rut";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaEmision";
            this.dataGridViewTextBoxColumn2.HeaderText = "Comuna";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 97;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            dataGridViewCellStyle3.Format = "N0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Región";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 75;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 170;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            dataGridViewCellStyle2.Format = "N0";
            this.razonSocial.DefaultCellStyle = dataGridViewCellStyle2;
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 170;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(11, 569);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 130);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Totales";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalHonorarios,
            this.MontoBruto,
            this.MontoLiquido,
            this.pagado,
            this.retenido});
            this.dataGridView3.Location = new System.Drawing.Point(7, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 25;
            this.dataGridView3.Size = new System.Drawing.Size(454, 111);
            this.dataGridView3.TabIndex = 0;
            // 
            // TotalHonorarios
            // 
            this.TotalHonorarios.HeaderText = "Total Honorarios";
            this.TotalHonorarios.Name = "TotalHonorarios";
            this.TotalHonorarios.ReadOnly = true;
            this.TotalHonorarios.Width = 97;
            // 
            // MontoBruto
            // 
            this.MontoBruto.DataPropertyName = "MontoBruto";
            this.MontoBruto.HeaderText = "Monto Bruto";
            this.MontoBruto.MinimumWidth = 6;
            this.MontoBruto.Name = "MontoBruto";
            this.MontoBruto.ReadOnly = true;
            this.MontoBruto.Width = 97;
            // 
            // MontoLiquido
            // 
            this.MontoLiquido.DataPropertyName = "MontoLiquido";
            dataGridViewCellStyle4.Format = "N0";
            this.MontoLiquido.DefaultCellStyle = dataGridViewCellStyle4;
            this.MontoLiquido.HeaderText = "Monto Liquido";
            this.MontoLiquido.MinimumWidth = 6;
            this.MontoLiquido.Name = "MontoLiquido";
            this.MontoLiquido.ReadOnly = true;
            this.MontoLiquido.Width = 97;
            // 
            // pagado
            // 
            this.pagado.HeaderText = "Pagado";
            this.pagado.Name = "pagado";
            this.pagado.ReadOnly = true;
            this.pagado.Width = 87;
            // 
            // retenido
            // 
            this.retenido.HeaderText = "Retenido";
            this.retenido.Name = "retenido";
            this.retenido.ReadOnly = true;
            this.retenido.Width = 87;
            // 
            // ListadoBhe_Emitida_Recibida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 742);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.generarpdf);
            this.Controls.Add(this.radioButton_recibidoPdf);
            this.Controls.Add(this.radioButton_emitidoPdf);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoBhe_Emitida_Recibida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoBhe_Emitida_Recibida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oPDF)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarpdf;
        private System.Windows.Forms.RadioButton radioButton_recibidoPdf;
        private System.Windows.Forms.RadioButton radioButton_emitidoPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown folio_oPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionAnulacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHonorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn retenido;
    }
}