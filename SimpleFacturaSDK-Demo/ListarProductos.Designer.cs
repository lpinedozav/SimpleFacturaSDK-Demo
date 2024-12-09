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
            this.generarAgregarProducto = new System.Windows.Forms.Button();
            this.productoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(257, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 102);
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
            this.productoId,
            this.gridNombreProducto,
            this.gridPrecio,
            this.exento});
            this.gridResultados.Location = new System.Drawing.Point(5, 13);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(537, 78);
            this.gridResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNombreSucursal);
            this.groupBox1.Controls.Add(this.textRutEmisor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(241, 102);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new System.Drawing.Point(93, 55);
            this.textNombreSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new System.Drawing.Size(140, 20);
            this.textNombreSucursal.TabIndex = 0;
            this.textNombreSucursal.TabStop = false;
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(93, 23);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(140, 20);
            this.textRutEmisor.TabIndex = 0;
            this.textRutEmisor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre sucursal:";
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
            // generarAgregarProducto
            // 
            this.generarAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarAgregarProducto.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarAgregarProducto.Location = new System.Drawing.Point(731, 118);
            this.generarAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.generarAgregarProducto.Name = "generarAgregarProducto";
            this.generarAgregarProducto.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarAgregarProducto.Size = new System.Drawing.Size(76, 28);
            this.generarAgregarProducto.TabIndex = 24;
            this.generarAgregarProducto.Text = "Generar";
            this.generarAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // productoId
            // 
            this.productoId.HeaderText = "Producto Id";
            this.productoId.Name = "productoId";
            this.productoId.ReadOnly = true;
            this.productoId.Width = 187;
            // 
            // gridNombreProducto
            // 
            this.gridNombreProducto.DataPropertyName = "Nombre";
            this.gridNombreProducto.HeaderText = "Nombre";
            this.gridNombreProducto.MinimumWidth = 6;
            this.gridNombreProducto.Name = "gridNombreProducto";
            this.gridNombreProducto.ReadOnly = true;
            this.gridNombreProducto.Width = 187;
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
            // ListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 152);
            this.Controls.Add(this.generarAgregarProducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarProductos";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarAgregarProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNombreSucursal;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn exento;
    }
}