namespace SimpleFacturaSDK_Demo
{
    partial class ListarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarProductos));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNombreSucursal = new System.Windows.Forms.TextBox();
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generarListadoProductos = new System.Windows.Forms.Button();
            this.gridNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(15, 165);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(558, 352);
            this.groupBox3.TabIndex = 23;
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
            this.gridNombreProducto,
            this.gridPrecio,
            this.exento,
            this.impuesto});
            this.gridResultados.Location = new System.Drawing.Point(7, 16);
            this.gridResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(543, 328);
            this.gridResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(550, 126);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(124, 68);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(420, 22);
            this.textNombreSucursal.TabIndex = 0;
            this.textNombreSucursal.TabStop = false;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(124, 28);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(420, 22);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre sucursal:";
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
            // generarListadoProductos
            // 
            this.generarListadoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarListadoProductos.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarListadoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarListadoProductos.Location = new System.Drawing.Point(472, 523);
            this.generarListadoProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generarListadoProductos.Name = "generarListadoProductos";
            this.generarListadoProductos.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.generarListadoProductos.Size = new System.Drawing.Size(101, 34);
            this.generarListadoProductos.TabIndex = 24;
            this.generarListadoProductos.Text = "Generar";
            this.generarListadoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarListadoProductos.UseVisualStyleBackColor = true;
            this.generarListadoProductos.Click += new System.EventHandler(this.generarListadoProductos_Click);
            // 
            // gridNombreProducto
            // 
            this.gridNombreProducto.DataPropertyName = "Nombre";
            this.gridNombreProducto.HeaderText = "Nombre";
            this.gridNombreProducto.MaxInputLength = 20000;
            this.gridNombreProducto.MinimumWidth = 6;
            this.gridNombreProducto.Name = "gridNombreProducto";
            this.gridNombreProducto.ReadOnly = true;
            this.gridNombreProducto.Width = 120;
            // 
            // gridPrecio
            // 
            this.gridPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "N0";
            this.gridPrecio.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridPrecio.HeaderText = "Precio";
            this.gridPrecio.MinimumWidth = 6;
            this.gridPrecio.Name = "gridPrecio";
            this.gridPrecio.ReadOnly = true;
            this.gridPrecio.Width = 70;
            // 
            // exento
            // 
            this.exento.DataPropertyName = "Exento";
            this.exento.HeaderText = "Exento";
            this.exento.MinimumWidth = 6;
            this.exento.Name = "exento";
            this.exento.ReadOnly = true;
            this.exento.Width = 50;
            // 
            // impuesto
            // 
            this.impuesto.HeaderText = "Impuestos";
            this.impuesto.MinimumWidth = 6;
            this.impuesto.Name = "impuesto";
            this.impuesto.ReadOnly = true;
            this.impuesto.Width = 187;
            // 
            // ListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 566);
            this.Controls.Add(this.generarListadoProductos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarProductos";
            this.Load += new System.EventHandler(this.ListarProductos_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarListadoProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn exento;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
    }
}