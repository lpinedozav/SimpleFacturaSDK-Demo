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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoBhe_Emitida_Recibida));
            this.radioButton_recibidoListado = new System.Windows.Forms.RadioButton();
            this.radioButton_emitidoListado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.hasta = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.folio_oListado = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generarListadoBHE = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridTotales = new System.Windows.Forms.DataGridView();
            this.TotalHonorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridReceptor = new System.Windows.Forms.DataGridView();
            this.RutReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComunaReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridEmisor = new System.Windows.Forms.DataGridView();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridOtros = new System.Windows.Forms.DataGridView();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionAnulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oListado)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotales)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceptor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmisor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtros)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_recibidoListado
            // 
            this.radioButton_recibidoListado.Location = new System.Drawing.Point(115, 11);
            this.radioButton_recibidoListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_recibidoListado.Name = "radioButton_recibidoListado";
            this.radioButton_recibidoListado.Size = new System.Drawing.Size(92, 18);
            this.radioButton_recibidoListado.TabIndex = 45;
            this.radioButton_recibidoListado.Text = "Recibido";
            this.radioButton_recibidoListado.UseVisualStyleBackColor = true;
            this.radioButton_recibidoListado.CheckedChanged += new System.EventHandler(this.radioButton_recibidoListado_CheckedChanged);
            // 
            // radioButton_emitidoListado
            // 
            this.radioButton_emitidoListado.Checked = true;
            this.radioButton_emitidoListado.Location = new System.Drawing.Point(15, 11);
            this.radioButton_emitidoListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_emitidoListado.Name = "radioButton_emitidoListado";
            this.radioButton_emitidoListado.Size = new System.Drawing.Size(92, 18);
            this.radioButton_emitidoListado.TabIndex = 44;
            this.radioButton_emitidoListado.TabStop = true;
            this.radioButton_emitidoListado.Text = "Emitido";
            this.radioButton_emitidoListado.UseVisualStyleBackColor = true;
            this.radioButton_emitidoListado.CheckedChanged += new System.EventHandler(this.radioButton_emitidoListado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeHasta);
            this.groupBox1.Controls.Add(this.dateTimeDesde);
            this.groupBox1.Controls.Add(this.hasta);
            this.groupBox1.Controls.Add(this.desde);
            this.groupBox1.Controls.Add(this.folio_oListado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(655, 150);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Consulta";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(409, 66);
            this.dateTimeHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(132, 22);
            this.dateTimeHasta.TabIndex = 23;
            this.dateTimeHasta.TabStop = false;
            this.dateTimeHasta.Value = new System.DateTime(2024, 11, 11, 0, 0, 0, 0);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(409, 33);
            this.dateTimeDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(129, 22);
            this.dateTimeDesde.TabIndex = 22;
            this.dateTimeDesde.TabStop = false;
            this.dateTimeDesde.Value = new System.DateTime(2024, 9, 3, 0, 0, 0, 0);
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(335, 73);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(46, 16);
            this.hasta.TabIndex = 21;
            this.hasta.Text = "Hasta:";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(335, 38);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(51, 16);
            this.desde.TabIndex = 20;
            this.desde.Text = "Desde:";
            // 
            // folio_oListado
            // 
            this.folio_oListado.Location = new System.Drawing.Point(133, 101);
            this.folio_oListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folio_oListado.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.folio_oListado.Name = "folio_oListado";
            this.folio_oListado.Size = new System.Drawing.Size(188, 22);
            this.folio_oListado.TabIndex = 6;
            this.folio_oListado.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Folio:";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(135, 66);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(185, 22);
            this.textNombreSucursal.TabIndex = 5;
            this.textNombreSucursal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre sucursal:";
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(133, 33);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(185, 22);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Emisor:";
            // 
            // generarListadoBHE
            // 
            this.generarListadoBHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarListadoBHE.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarListadoBHE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarListadoBHE.Location = new System.Drawing.Point(568, 976);
            this.generarListadoBHE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generarListadoBHE.Name = "generarListadoBHE";
            this.generarListadoBHE.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.generarListadoBHE.Size = new System.Drawing.Size(101, 34);
            this.generarListadoBHE.TabIndex = 46;
            this.generarListadoBHE.Text = "Generar";
            this.generarListadoBHE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarListadoBHE.UseVisualStyleBackColor = true;
            this.generarListadoBHE.Click += new System.EventHandler(this.generarListadoBHE_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Location = new System.Drawing.Point(15, 198);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(655, 698);
            this.groupBox6.TabIndex = 51;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultado";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridTotales);
            this.groupBox5.Location = new System.Drawing.Point(13, 358);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(627, 160);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Totales";
            // 
            // dataGridTotales
            // 
            this.dataGridTotales.AllowUserToAddRows = false;
            this.dataGridTotales.AllowUserToDeleteRows = false;
            this.dataGridTotales.AllowUserToResizeColumns = false;
            this.dataGridTotales.AllowUserToResizeRows = false;
            this.dataGridTotales.ColumnHeadersHeight = 29;
            this.dataGridTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalHonorarios,
            this.MontoBruto,
            this.MontoLiquido,
            this.pagado,
            this.retenido});
            this.dataGridTotales.Location = new System.Drawing.Point(9, 16);
            this.dataGridTotales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridTotales.Name = "dataGridTotales";
            this.dataGridTotales.ReadOnly = true;
            this.dataGridTotales.RowHeadersWidth = 25;
            this.dataGridTotales.Size = new System.Drawing.Size(605, 137);
            this.dataGridTotales.TabIndex = 0;
            // 
            // TotalHonorarios
            // 
            this.TotalHonorarios.DataPropertyName = "TotalHonorarios";
            this.TotalHonorarios.HeaderText = "Total Honorarios";
            this.TotalHonorarios.MinimumWidth = 6;
            this.TotalHonorarios.Name = "TotalHonorarios";
            this.TotalHonorarios.ReadOnly = true;
            this.TotalHonorarios.Width = 140;
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
            dataGridViewCellStyle1.Format = "N0";
            this.MontoLiquido.DefaultCellStyle = dataGridViewCellStyle1;
            this.MontoLiquido.HeaderText = "Monto Liquido";
            this.MontoLiquido.MinimumWidth = 6;
            this.MontoLiquido.Name = "MontoLiquido";
            this.MontoLiquido.ReadOnly = true;
            this.MontoLiquido.Width = 97;
            // 
            // pagado
            // 
            this.pagado.DataPropertyName = "pagado";
            this.pagado.HeaderText = "Pagado";
            this.pagado.MinimumWidth = 6;
            this.pagado.Name = "pagado";
            this.pagado.ReadOnly = true;
            this.pagado.Width = 87;
            // 
            // retenido
            // 
            this.retenido.DataPropertyName = "retenido";
            this.retenido.HeaderText = "Retenido";
            this.retenido.MinimumWidth = 6;
            this.retenido.Name = "retenido";
            this.retenido.ReadOnly = true;
            this.retenido.Width = 87;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridReceptor);
            this.groupBox4.Location = new System.Drawing.Point(12, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(627, 160);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receptor";
            // 
            // dataGridReceptor
            // 
            this.dataGridReceptor.AllowUserToAddRows = false;
            this.dataGridReceptor.AllowUserToDeleteRows = false;
            this.dataGridReceptor.AllowUserToResizeColumns = false;
            this.dataGridReceptor.AllowUserToResizeRows = false;
            this.dataGridReceptor.ColumnHeadersHeight = 29;
            this.dataGridReceptor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridReceptor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RutReceptor,
            this.ComunaReceptor,
            this.Nombre,
            this.DireccionReceptor,
            this.Region});
            this.dataGridReceptor.Location = new System.Drawing.Point(9, 16);
            this.dataGridReceptor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridReceptor.Name = "dataGridReceptor";
            this.dataGridReceptor.ReadOnly = true;
            this.dataGridReceptor.RowHeadersWidth = 25;
            this.dataGridReceptor.Size = new System.Drawing.Size(605, 137);
            this.dataGridReceptor.TabIndex = 0;
            // 
            // RutReceptor
            // 
            this.RutReceptor.DataPropertyName = "RutReceptor";
            this.RutReceptor.HeaderText = "Rut";
            this.RutReceptor.MinimumWidth = 6;
            this.RutReceptor.Name = "RutReceptor";
            this.RutReceptor.ReadOnly = true;
            this.RutReceptor.Width = 75;
            // 
            // ComunaReceptor
            // 
            this.ComunaReceptor.DataPropertyName = "ComunaReceptor";
            this.ComunaReceptor.HeaderText = "Comuna";
            this.ComunaReceptor.MinimumWidth = 6;
            this.ComunaReceptor.Name = "ComunaReceptor";
            this.ComunaReceptor.ReadOnly = true;
            this.ComunaReceptor.Width = 97;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.Format = "N0";
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // DireccionReceptor
            // 
            this.DireccionReceptor.DataPropertyName = "DireccionReceptor";
            this.DireccionReceptor.HeaderText = "Dirección";
            this.DireccionReceptor.MinimumWidth = 6;
            this.DireccionReceptor.Name = "DireccionReceptor";
            this.DireccionReceptor.ReadOnly = true;
            this.DireccionReceptor.Width = 90;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Región";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            this.Region.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridEmisor);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(627, 160);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emisor";
            // 
            // dataGridEmisor
            // 
            this.dataGridEmisor.AllowUserToAddRows = false;
            this.dataGridEmisor.AllowUserToDeleteRows = false;
            this.dataGridEmisor.AllowUserToResizeColumns = false;
            this.dataGridEmisor.AllowUserToResizeRows = false;
            this.dataGridEmisor.ColumnHeadersHeight = 29;
            this.dataGridEmisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEmisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.direccion,
            this.razonSocial});
            this.dataGridEmisor.Location = new System.Drawing.Point(9, 16);
            this.dataGridEmisor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridEmisor.Name = "dataGridEmisor";
            this.dataGridEmisor.ReadOnly = true;
            this.dataGridEmisor.RowHeadersWidth = 25;
            this.dataGridEmisor.Size = new System.Drawing.Size(605, 137);
            this.dataGridEmisor.TabIndex = 0;
            // 
            // Rut
            // 
            this.Rut.DataPropertyName = "Rut";
            this.Rut.HeaderText = "Rut";
            this.Rut.MinimumWidth = 6;
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 75;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 170;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "RazonSocial";
            dataGridViewCellStyle3.Format = "N0";
            this.razonSocial.DefaultCellStyle = dataGridViewCellStyle3;
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 170;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridOtros);
            this.groupBox3.Location = new System.Drawing.Point(12, 526);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(627, 160);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otros";
            // 
            // gridOtros
            // 
            this.gridOtros.AllowUserToAddRows = false;
            this.gridOtros.AllowUserToDeleteRows = false;
            this.gridOtros.AllowUserToResizeColumns = false;
            this.gridOtros.AllowUserToResizeRows = false;
            this.gridOtros.ColumnHeadersHeight = 29;
            this.gridOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOtros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio,
            this.fechaEmision,
            this.codigoBarra,
            this.estado,
            this.descripcionAnulacion});
            this.gridOtros.Location = new System.Drawing.Point(9, 16);
            this.gridOtros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridOtros.Name = "gridOtros";
            this.gridOtros.ReadOnly = true;
            this.gridOtros.RowHeadersWidth = 25;
            this.gridOtros.Size = new System.Drawing.Size(605, 137);
            this.gridOtros.TabIndex = 0;
            // 
            // folio
            // 
            this.folio.DataPropertyName = "folio";
            this.folio.HeaderText = "Folio";
            this.folio.MinimumWidth = 6;
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Width = 75;
            // 
            // fechaEmision
            // 
            this.fechaEmision.DataPropertyName = "fechaEmision";
            this.fechaEmision.HeaderText = "Fecha Emision";
            this.fechaEmision.MinimumWidth = 6;
            this.fechaEmision.Name = "fechaEmision";
            this.fechaEmision.ReadOnly = true;
            this.fechaEmision.Width = 105;
            // 
            // codigoBarra
            // 
            this.codigoBarra.DataPropertyName = "codigoBarra";
            dataGridViewCellStyle4.Format = "N0";
            this.codigoBarra.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.descripcionAnulacion.DataPropertyName = "descripcionAnulacion";
            this.descripcionAnulacion.HeaderText = "Descr Anulación";
            this.descripcionAnulacion.MinimumWidth = 6;
            this.descripcionAnulacion.Name = "descripcionAnulacion";
            this.descripcionAnulacion.ReadOnly = true;
            this.descripcionAnulacion.Width = 150;
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(8, 23);
            this.textDocumentacion.Margin = new System.Windows.Forms.Padding(4);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(365, 73);
            this.textDocumentacion.TabIndex = 20;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.linkLabel1);
            this.groupBox7.Controls.Add(this.textDocumentacion);
            this.groupBox7.Location = new System.Drawing.Point(15, 904);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(381, 106);
            this.groupBox7.TabIndex = 52;
            this.groupBox7.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, -2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 16);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Documentación";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ListadoBhe_Emitida_Recibida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 1013);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.generarListadoBHE);
            this.Controls.Add(this.radioButton_recibidoListado);
            this.Controls.Add(this.radioButton_emitidoListado);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoBhe_Emitida_Recibida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Boletas de Honorarios";
            this.Load += new System.EventHandler(this.ListadoBhe_Emitida_Recibida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folio_oListado)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotales)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceptor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmisor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOtros)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarListadoBHE;
        private System.Windows.Forms.RadioButton radioButton_recibidoListado;
        private System.Windows.Forms.RadioButton radioButton_emitidoListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown folio_oListado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridTotales;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridReceptor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridEmisor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridOtros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComunaReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHonorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn retenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionAnulacion;
        private System.Windows.Forms.TextBox textDocumentacion;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}