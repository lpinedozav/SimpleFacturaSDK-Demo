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
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.generarListarClientes = new System.Windows.Forms.Button();
            this.textDocumentacion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.Location = new System.Drawing.Point(97, 11);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(185, 22);
            this.textRutEmisor.TabIndex = 28;
            this.textRutEmisor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Rut Emisor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridResultados);
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(705, 272);
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
            this.gridResultados.Location = new System.Drawing.Point(7, 16);
            this.gridResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.Size = new System.Drawing.Size(687, 238);
            this.gridResultados.TabIndex = 0;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Width = 125;
            // 
            // RutCliente
            // 
            this.RutCliente.DataPropertyName = "Rut";
            this.RutCliente.HeaderText = "Rut";
            this.RutCliente.MinimumWidth = 6;
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
            this.Rut_Formateado.DataPropertyName = "RutFormateado";
            this.Rut_Formateado.HeaderText = "Rut Formateado";
            this.Rut_Formateado.MinimumWidth = 6;
            this.Rut_Formateado.Name = "Rut_Formateado";
            this.Rut_Formateado.ReadOnly = true;
            this.Rut_Formateado.Width = 125;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "RazonSocial";
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.MinimumWidth = 6;
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
            this.correoPart.DataPropertyName = "CorreoPar";
            this.correoPart.HeaderText = "Correo Part";
            this.correoPart.MinimumWidth = 6;
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
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 125;
            // 
            // Comuna
            // 
            this.Comuna.DataPropertyName = "Comuna";
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.MinimumWidth = 6;
            this.Comuna.Name = "Comuna";
            this.Comuna.ReadOnly = true;
            this.Comuna.Width = 125;
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
            // generarListarClientes
            // 
            this.generarListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarListarClientes.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.Guardar_32;
            this.generarListarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarListarClientes.Location = new System.Drawing.Point(615, 381);
            this.generarListarClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generarListarClientes.Name = "generarListarClientes";
            this.generarListarClientes.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.generarListarClientes.Size = new System.Drawing.Size(101, 34);
            this.generarListarClientes.TabIndex = 27;
            this.generarListarClientes.Text = "Generar";
            this.generarListarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generarListarClientes.UseVisualStyleBackColor = true;
            this.generarListarClientes.Click += new System.EventHandler(this.generarListarClientes_Click);
            // 
            // textDocumentacion
            // 
            this.textDocumentacion.Location = new System.Drawing.Point(8, 23);
            this.textDocumentacion.Margin = new System.Windows.Forms.Padding(4);
            this.textDocumentacion.Multiline = true;
            this.textDocumentacion.Name = "textDocumentacion";
            this.textDocumentacion.Size = new System.Drawing.Size(388, 56);
            this.textDocumentacion.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.textDocumentacion);
            this.groupBox2.Location = new System.Drawing.Point(14, 328);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(404, 87);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
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
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textRutEmisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generarListarClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Clientes";
            this.Load += new System.EventHandler(this.ListarClientes_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generarListarClientes;
        private System.Windows.Forms.TextBox textRutEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
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
        private System.Windows.Forms.TextBox textDocumentacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}