namespace SimpleFacturaSDK_Demo
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Configuracion = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Facturacion = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.conciliar_emitidos = new System.Windows.Forms.Button();
            this.envio_mail = new System.Windows.Forms.Button();
            this.listado_dte_emitido = new System.Windows.Forms.Button();
            this.consolidado_ventas = new System.Windows.Forms.Button();
            this.otros_dte = new System.Windows.Forms.GroupBox();
            this.emision_nc_nd = new System.Windows.Forms.Button();
            this.facturacion_masiva = new System.Windows.Forms.Button();
            this.facturacion_dte = new System.Windows.Forms.Button();
            this.facturacion_exportacion = new System.Windows.Forms.Button();
            this.facturacion_boleta = new System.Windows.Forms.Button();
            this.Obtener_documentos = new System.Windows.Forms.GroupBox();
            this.obtener_sobre_xml = new System.Windows.Forms.Button();
            this.obtener_dte = new System.Windows.Forms.Button();
            this.obtener_xml = new System.Windows.Forms.Button();
            this.obtener_timbre = new System.Windows.Forms.Button();
            this.obtener_pdf = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.TabPage();
            this.Proveedores = new System.Windows.Forms.TabPage();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.Sucursales = new System.Windows.Forms.TabPage();
            this.Folios = new System.Windows.Forms.TabPage();
            this.Boletas_Honorario = new System.Windows.Forms.TabPage();
            this.tabControl2.SuspendLayout();
            this.Facturacion.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.otros_dte.SuspendLayout();
            this.Obtener_documentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Configuracion
            // 
            this.Configuracion.FlatAppearance.BorderSize = 0;
            this.Configuracion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuracion.Image = ((System.Drawing.Image)(resources.GetObject("Configuracion.Image")));
            this.Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Configuracion.Location = new System.Drawing.Point(24, 16);
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Configuracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Configuracion.Size = new System.Drawing.Size(137, 48);
            this.Configuracion.TabIndex = 0;
            this.Configuracion.Text = "Configuracion";
            this.Configuracion.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Facturacion);
            this.tabControl2.Controls.Add(this.Productos);
            this.tabControl2.Controls.Add(this.Proveedores);
            this.tabControl2.Controls.Add(this.Clientes);
            this.tabControl2.Controls.Add(this.Sucursales);
            this.tabControl2.Controls.Add(this.Folios);
            this.tabControl2.Controls.Add(this.Boletas_Honorario);
            this.tabControl2.Location = new System.Drawing.Point(24, 70);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(774, 363);
            this.tabControl2.TabIndex = 1;
            // 
            // Facturacion
            // 
            this.Facturacion.Controls.Add(this.groupBox6);
            this.Facturacion.Controls.Add(this.otros_dte);
            this.Facturacion.Controls.Add(this.Obtener_documentos);
            this.Facturacion.Location = new System.Drawing.Point(4, 25);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Padding = new System.Windows.Forms.Padding(3);
            this.Facturacion.Size = new System.Drawing.Size(766, 334);
            this.Facturacion.TabIndex = 0;
            this.Facturacion.Text = "Facturacion";
            this.Facturacion.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.conciliar_emitidos);
            this.groupBox6.Controls.Add(this.envio_mail);
            this.groupBox6.Controls.Add(this.listado_dte_emitido);
            this.groupBox6.Controls.Add(this.consolidado_ventas);
            this.groupBox6.Location = new System.Drawing.Point(512, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 258);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "LA WEA MALA";
            // 
            // conciliar_emitidos
            // 
            this.conciliar_emitidos.Location = new System.Drawing.Point(12, 153);
            this.conciliar_emitidos.Name = "conciliar_emitidos";
            this.conciliar_emitidos.Size = new System.Drawing.Size(210, 38);
            this.conciliar_emitidos.TabIndex = 13;
            this.conciliar_emitidos.Text = "Conciliar Emitidos";
            this.conciliar_emitidos.UseVisualStyleBackColor = true;
            // 
            // envio_mail
            // 
            this.envio_mail.Location = new System.Drawing.Point(12, 65);
            this.envio_mail.Name = "envio_mail";
            this.envio_mail.Size = new System.Drawing.Size(210, 38);
            this.envio_mail.TabIndex = 11;
            this.envio_mail.Text = "Envio Mail";
            this.envio_mail.UseVisualStyleBackColor = true;
            // 
            // listado_dte_emitido
            // 
            this.listado_dte_emitido.Location = new System.Drawing.Point(12, 21);
            this.listado_dte_emitido.Name = "listado_dte_emitido";
            this.listado_dte_emitido.Size = new System.Drawing.Size(210, 38);
            this.listado_dte_emitido.TabIndex = 10;
            this.listado_dte_emitido.Text = "Listado DTE Emitido";
            this.listado_dte_emitido.UseVisualStyleBackColor = true;
            // 
            // consolidado_ventas
            // 
            this.consolidado_ventas.Location = new System.Drawing.Point(12, 109);
            this.consolidado_ventas.Name = "consolidado_ventas";
            this.consolidado_ventas.Size = new System.Drawing.Size(210, 38);
            this.consolidado_ventas.TabIndex = 12;
            this.consolidado_ventas.Text = "Consolidado de ventas";
            this.consolidado_ventas.UseVisualStyleBackColor = true;
            // 
            // otros_dte
            // 
            this.otros_dte.Controls.Add(this.emision_nc_nd);
            this.otros_dte.Controls.Add(this.facturacion_masiva);
            this.otros_dte.Controls.Add(this.facturacion_dte);
            this.otros_dte.Controls.Add(this.facturacion_exportacion);
            this.otros_dte.Controls.Add(this.facturacion_boleta);
            this.otros_dte.Location = new System.Drawing.Point(267, 15);
            this.otros_dte.Name = "otros_dte";
            this.otros_dte.Size = new System.Drawing.Size(228, 258);
            this.otros_dte.TabIndex = 1;
            this.otros_dte.TabStop = false;
            this.otros_dte.Text = "Otros DTE";
            // 
            // emision_nc_nd
            // 
            this.emision_nc_nd.Location = new System.Drawing.Point(7, 197);
            this.emision_nc_nd.Name = "emision_nc_nd";
            this.emision_nc_nd.Size = new System.Drawing.Size(210, 38);
            this.emision_nc_nd.TabIndex = 9;
            this.emision_nc_nd.Text = "Emision NC/ND";
            this.emision_nc_nd.UseVisualStyleBackColor = true;
            // 
            // facturacion_masiva
            // 
            this.facturacion_masiva.Location = new System.Drawing.Point(7, 153);
            this.facturacion_masiva.Name = "facturacion_masiva";
            this.facturacion_masiva.Size = new System.Drawing.Size(210, 38);
            this.facturacion_masiva.TabIndex = 8;
            this.facturacion_masiva.Text = "Facturacion Masiva";
            this.facturacion_masiva.UseVisualStyleBackColor = true;
            // 
            // facturacion_dte
            // 
            this.facturacion_dte.Location = new System.Drawing.Point(7, 21);
            this.facturacion_dte.Name = "facturacion_dte";
            this.facturacion_dte.Size = new System.Drawing.Size(210, 38);
            this.facturacion_dte.TabIndex = 5;
            this.facturacion_dte.Text = "Facturacion DTE";
            this.facturacion_dte.UseVisualStyleBackColor = true;
            // 
            // facturacion_exportacion
            // 
            this.facturacion_exportacion.Location = new System.Drawing.Point(7, 109);
            this.facturacion_exportacion.Name = "facturacion_exportacion";
            this.facturacion_exportacion.Size = new System.Drawing.Size(210, 38);
            this.facturacion_exportacion.TabIndex = 7;
            this.facturacion_exportacion.Text = "Facturacion Exportacion";
            this.facturacion_exportacion.UseVisualStyleBackColor = true;
            // 
            // facturacion_boleta
            // 
            this.facturacion_boleta.Location = new System.Drawing.Point(7, 65);
            this.facturacion_boleta.Name = "facturacion_boleta";
            this.facturacion_boleta.Size = new System.Drawing.Size(210, 38);
            this.facturacion_boleta.TabIndex = 6;
            this.facturacion_boleta.Text = "Facturacion Boleta";
            this.facturacion_boleta.UseVisualStyleBackColor = true;
            // 
            // Obtener_documentos
            // 
            this.Obtener_documentos.Controls.Add(this.obtener_sobre_xml);
            this.Obtener_documentos.Controls.Add(this.obtener_dte);
            this.Obtener_documentos.Controls.Add(this.obtener_xml);
            this.Obtener_documentos.Controls.Add(this.obtener_timbre);
            this.Obtener_documentos.Controls.Add(this.obtener_pdf);
            this.Obtener_documentos.Location = new System.Drawing.Point(18, 15);
            this.Obtener_documentos.Name = "Obtener_documentos";
            this.Obtener_documentos.Size = new System.Drawing.Size(229, 258);
            this.Obtener_documentos.TabIndex = 0;
            this.Obtener_documentos.TabStop = false;
            this.Obtener_documentos.Text = "Obtener documentos";
            // 
            // obtener_sobre_xml
            // 
            this.obtener_sobre_xml.Location = new System.Drawing.Point(7, 197);
            this.obtener_sobre_xml.Name = "obtener_sobre_xml";
            this.obtener_sobre_xml.Size = new System.Drawing.Size(210, 38);
            this.obtener_sobre_xml.TabIndex = 4;
            this.obtener_sobre_xml.Text = "Obtener SobreXML";
            this.obtener_sobre_xml.UseVisualStyleBackColor = true;
            // 
            // obtener_dte
            // 
            this.obtener_dte.Location = new System.Drawing.Point(7, 153);
            this.obtener_dte.Name = "obtener_dte";
            this.obtener_dte.Size = new System.Drawing.Size(210, 38);
            this.obtener_dte.TabIndex = 3;
            this.obtener_dte.Text = "Obtener DTE";
            this.obtener_dte.UseVisualStyleBackColor = true;
            // 
            // obtener_xml
            // 
            this.obtener_xml.Location = new System.Drawing.Point(7, 109);
            this.obtener_xml.Name = "obtener_xml";
            this.obtener_xml.Size = new System.Drawing.Size(210, 38);
            this.obtener_xml.TabIndex = 2;
            this.obtener_xml.Text = "Obtener XML";
            this.obtener_xml.UseVisualStyleBackColor = true;
            // 
            // obtener_timbre
            // 
            this.obtener_timbre.Location = new System.Drawing.Point(7, 65);
            this.obtener_timbre.Name = "obtener_timbre";
            this.obtener_timbre.Size = new System.Drawing.Size(210, 38);
            this.obtener_timbre.TabIndex = 1;
            this.obtener_timbre.Text = "Obtener Timbre";
            this.obtener_timbre.UseVisualStyleBackColor = true;
            this.obtener_timbre.Click += new System.EventHandler(this.button16_Click);
            // 
            // obtener_pdf
            // 
            this.obtener_pdf.Location = new System.Drawing.Point(7, 21);
            this.obtener_pdf.Name = "obtener_pdf";
            this.obtener_pdf.Size = new System.Drawing.Size(210, 38);
            this.obtener_pdf.TabIndex = 0;
            this.obtener_pdf.Text = "Obtener PDF";
            this.obtener_pdf.UseVisualStyleBackColor = true;
            this.obtener_pdf.Click += new System.EventHandler(this.obtener_pdf_Click);
            // 
            // Productos
            // 
            this.Productos.Location = new System.Drawing.Point(4, 25);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(3);
            this.Productos.Size = new System.Drawing.Size(766, 334);
            this.Productos.TabIndex = 1;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.Proveedores.Location = new System.Drawing.Point(4, 25);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(766, 334);
            this.Proveedores.TabIndex = 2;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.Clientes.Location = new System.Drawing.Point(4, 25);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(766, 334);
            this.Clientes.TabIndex = 3;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // Sucursales
            // 
            this.Sucursales.Location = new System.Drawing.Point(4, 25);
            this.Sucursales.Name = "Sucursales";
            this.Sucursales.Size = new System.Drawing.Size(766, 334);
            this.Sucursales.TabIndex = 4;
            this.Sucursales.Text = "Sucursales";
            this.Sucursales.UseVisualStyleBackColor = true;
            // 
            // Folios
            // 
            this.Folios.Location = new System.Drawing.Point(4, 25);
            this.Folios.Name = "Folios";
            this.Folios.Size = new System.Drawing.Size(766, 334);
            this.Folios.TabIndex = 5;
            this.Folios.Text = "Folios";
            this.Folios.UseVisualStyleBackColor = true;
            // 
            // Boletas_Honorario
            // 
            this.Boletas_Honorario.Location = new System.Drawing.Point(4, 25);
            this.Boletas_Honorario.Name = "Boletas_Honorario";
            this.Boletas_Honorario.Size = new System.Drawing.Size(766, 334);
            this.Boletas_Honorario.TabIndex = 6;
            this.Boletas_Honorario.Text = "Boletas Honorario";
            this.Boletas_Honorario.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(823, 472);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.Configuracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SimpleFactura-Demo";
            this.tabControl2.ResumeLayout(false);
            this.Facturacion.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.otros_dte.ResumeLayout(false);
            this.Obtener_documentos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ObtenerPDF;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Configuracion;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Facturacion;
        private System.Windows.Forms.TabPage Productos;
        private System.Windows.Forms.TabPage Proveedores;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.TabPage Sucursales;
        private System.Windows.Forms.TabPage Folios;
        private System.Windows.Forms.TabPage Boletas_Honorario;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button conciliar_emitidos;
        private System.Windows.Forms.Button envio_mail;
        private System.Windows.Forms.Button listado_dte_emitido;
        private System.Windows.Forms.Button consolidado_ventas;
        private System.Windows.Forms.GroupBox otros_dte;
        private System.Windows.Forms.Button emision_nc_nd;
        private System.Windows.Forms.Button facturacion_masiva;
        private System.Windows.Forms.Button facturacion_dte;
        private System.Windows.Forms.Button facturacion_exportacion;
        private System.Windows.Forms.Button facturacion_boleta;
        private System.Windows.Forms.GroupBox Obtener_documentos;
        private System.Windows.Forms.Button obtener_sobre_xml;
        private System.Windows.Forms.Button obtener_dte;
        private System.Windows.Forms.Button obtener_xml;
        private System.Windows.Forms.Button obtener_timbre;
        private System.Windows.Forms.Button obtener_pdf;
    }
}

