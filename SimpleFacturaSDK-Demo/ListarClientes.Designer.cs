namespace SimpleFacturaSDK_Demo
{
    partial class ListarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarClientes));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut_Formateado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generarAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Rut Emisor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(9, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 117);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
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
            this.Activo,
            this.RutCliente,
            this.Dv,
            this.Rut_Formateado,
            this.razonSocial,
            this.Giro,
            this.correoPart,
            this.correoFact,
            this.Ciudad,
            this.Comuna,
            this.dirPart,
            this.DirFact});
            this.gridResultados.Location = new System.Drawing.Point(5, 13);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(515, 98);
            this.gridResultados.TabIndex = 0;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // RutCliente
            // 
            this.RutCliente.HeaderText = "Rut";
            this.RutCliente.Name = "RutCliente";
            this.RutCliente.ReadOnly = true;
            this.RutCliente.Width = 65;
            // 
            // Dv
            // 
            this.Dv.DataPropertyName = "Dv";
            this.Dv.HeaderText = "Dv";
            this.Dv.MinimumWidth = 6;
            this.Dv.Name = "Dv";
            this.Dv.ReadOnly = true;
            this.Dv.Width = 28;
            // 
            // Rut_Formateado
            // 
            this.Rut_Formateado.HeaderText = "Rut Formateado";
            this.Rut_Formateado.Name = "Rut_Formateado";
            this.Rut_Formateado.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 187;
            // 
            // Giro
            // 
            this.Giro.DataPropertyName = "Giro";
            dataGridViewCellStyle1.Format = "N1";
            this.Giro.DefaultCellStyle = dataGridViewCellStyle1;
            this.Giro.HeaderText = "Giro";
            this.Giro.MinimumWidth = 6;
            this.Giro.Name = "Giro";
            this.Giro.ReadOnly = true;
            this.Giro.Width = 187;
            // 
            // correoPart
            // 
            this.correoPart.HeaderText = "Correo Part";
            this.correoPart.Name = "correoPart";
            this.correoPart.ReadOnly = true;
            this.correoPart.Width = 105;
            // 
            // correoFact
            // 
            this.correoFact.DataPropertyName = "CorreoFact";
            dataGridViewCellStyle2.Format = "N0";
            this.correoFact.DefaultCellStyle = dataGridViewCellStyle2;
            this.correoFact.HeaderText = "Correo Fact";
            this.correoFact.MinimumWidth = 6;
            this.correoFact.Name = "correoFact";
            this.correoFact.ReadOnly = true;
            this.correoFact.Width = 105;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Comuna
            // 
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.Name = "Comuna";
            this.Comuna.ReadOnly = true;
            // 
            // dirPart
            // 
            this.dirPart.DataPropertyName = "DirPart";
            dataGridViewCellStyle3.Format = "N0";
            this.dirPart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dirPart.HeaderText = "Dirección Part";
            this.dirPart.MinimumWidth = 6;
            this.dirPart.Name = "dirPart";
            this.dirPart.ReadOnly = true;
            this.dirPart.Width = 105;
            // 
            // DirFact
            // 
            this.DirFact.DataPropertyName = "DirFact";
            this.DirFact.HeaderText = "Dirección Fact";
            this.DirFact.MinimumWidth = 6;
            this.DirFact.Name = "DirFact";
            this.DirFact.ReadOnly = true;
            this.DirFact.Width = 105;
            // 
            // generarAgregarProducto
            // 
            this.generarAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarAgregarProducto.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarAgregarProducto.Location = new System.Drawing.Point(462, 161);
            this.generarAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.generarAgregarProducto.Name = "generarAgregarProducto";
            this.generarAgregarProducto.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.generarAgregarProducto.Size = new System.Drawing.Size(76, 28);
            this.generarAgregarProducto.TabIndex = 27;
            this.generarAgregarProducto.Text = "Generar";
            this.generarAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 200);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generarAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarClientes";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generarAgregarProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut_Formateado;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giro;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirFact;
    }
}