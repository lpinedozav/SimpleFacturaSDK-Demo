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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.item_facturacion = new System.Windows.Forms.TabPage();
            this.otros = new System.Windows.Forms.GroupBox();
            this.obtenerXmlRecibido = new System.Windows.Forms.Button();
            this.Acuse = new System.Windows.Forms.Button();
            this.obtener_pdfRecibido = new System.Windows.Forms.Button();
            this.listadoDteRecibido = new System.Windows.Forms.Button();
            this.emision_dte = new System.Windows.Forms.GroupBox();
            this.emision_nc_nd = new System.Windows.Forms.Button();
            this.facturacion_masiva = new System.Windows.Forms.Button();
            this.facturacion_dte = new System.Windows.Forms.Button();
            this.facturacion_exportacion = new System.Windows.Forms.Button();
            this.obtenerdte = new System.Windows.Forms.GroupBox();
            this.obtener_sobre_xml = new System.Windows.Forms.Button();
            this.obtener_dte = new System.Windows.Forms.Button();
            this.obtener_xml = new System.Windows.Forms.Button();
            this.obtener_timbre = new System.Windows.Forms.Button();
            this.obtener_pdf = new System.Windows.Forms.Button();
            this.item_productos = new System.Windows.Forms.TabPage();
            this.item_clientes = new System.Windows.Forms.TabPage();
            this.item_folios = new System.Windows.Forms.TabPage();
            this.item_bh = new System.Windows.Forms.TabPage();
            this.item_otros = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.Conciliar_Recibidos = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.item_facturacion.SuspendLayout();
            this.otros.SuspendLayout();
            this.emision_dte.SuspendLayout();
            this.obtenerdte.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.item_facturacion);
            this.tabControl2.Controls.Add(this.item_productos);
            this.tabControl2.Controls.Add(this.item_clientes);
            this.tabControl2.Controls.Add(this.item_folios);
            this.tabControl2.Controls.Add(this.item_bh);
            this.tabControl2.Controls.Add(this.item_otros);
            this.tabControl2.Location = new System.Drawing.Point(13, 55);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(809, 315);
            this.tabControl2.TabIndex = 1;
            // 
            // item_facturacion
            // 
            this.item_facturacion.Controls.Add(this.groupBox4);
            this.item_facturacion.Controls.Add(this.otros);
            this.item_facturacion.Controls.Add(this.emision_dte);
            this.item_facturacion.Controls.Add(this.obtenerdte);
            this.item_facturacion.Location = new System.Drawing.Point(4, 22);
            this.item_facturacion.Name = "item_facturacion";
            this.item_facturacion.Padding = new System.Windows.Forms.Padding(3);
            this.item_facturacion.Size = new System.Drawing.Size(801, 289);
            this.item_facturacion.TabIndex = 0;
            this.item_facturacion.Text = "Facturación";
            this.item_facturacion.UseVisualStyleBackColor = true;
            // 
            // otros
            // 
            this.otros.Controls.Add(this.Conciliar_Recibidos);
            this.otros.Controls.Add(this.obtenerXmlRecibido);
            this.otros.Controls.Add(this.Acuse);
            this.otros.Controls.Add(this.obtener_pdfRecibido);
            this.otros.Controls.Add(this.listadoDteRecibido);
            this.otros.Location = new System.Drawing.Point(402, 15);
            this.otros.Name = "otros";
            this.otros.Size = new System.Drawing.Size(187, 254);
            this.otros.TabIndex = 2;
            this.otros.TabStop = false;
            this.otros.Text = "DTE Recibido";
            // 
            // obtenerXmlRecibido
            // 
            this.obtenerXmlRecibido.Location = new System.Drawing.Point(15, 117);
            this.obtenerXmlRecibido.Name = "obtenerXmlRecibido";
            this.obtenerXmlRecibido.Size = new System.Drawing.Size(158, 38);
            this.obtenerXmlRecibido.TabIndex = 13;
            this.obtenerXmlRecibido.Text = "Obtener XML";
            this.obtenerXmlRecibido.UseVisualStyleBackColor = true;
            this.obtenerXmlRecibido.Click += new System.EventHandler(this.conciliar_emitidos_Click);
            // 
            // Acuse
            // 
            this.Acuse.Location = new System.Drawing.Point(15, 27);
            this.Acuse.Name = "Acuse";
            this.Acuse.Size = new System.Drawing.Size(158, 38);
            this.Acuse.TabIndex = 11;
            this.Acuse.Text = "Aceptar o Rechazar DTE";
            this.Acuse.UseVisualStyleBackColor = true;
            this.Acuse.Click += new System.EventHandler(this.envio_mail_Click);
            // 
            // obtener_pdfRecibido
            // 
            this.obtener_pdfRecibido.Location = new System.Drawing.Point(15, 161);
            this.obtener_pdfRecibido.Name = "obtener_pdfRecibido";
            this.obtener_pdfRecibido.Size = new System.Drawing.Size(158, 38);
            this.obtener_pdfRecibido.TabIndex = 10;
            this.obtener_pdfRecibido.Text = "Obtener PDF";
            this.obtener_pdfRecibido.UseVisualStyleBackColor = true;
            this.obtener_pdfRecibido.Click += new System.EventHandler(this.listado_dte_emitido_Click);
            // 
            // listadoDteRecibido
            // 
            this.listadoDteRecibido.Location = new System.Drawing.Point(15, 73);
            this.listadoDteRecibido.Name = "listadoDteRecibido";
            this.listadoDteRecibido.Size = new System.Drawing.Size(158, 38);
            this.listadoDteRecibido.TabIndex = 12;
            this.listadoDteRecibido.Text = "Listado DTE Recibido";
            this.listadoDteRecibido.UseVisualStyleBackColor = true;
            this.listadoDteRecibido.Click += new System.EventHandler(this.consolidado_ventas_Click);
            // 
            // emision_dte
            // 
            this.emision_dte.Controls.Add(this.emision_nc_nd);
            this.emision_dte.Controls.Add(this.facturacion_masiva);
            this.emision_dte.Controls.Add(this.button17);
            this.emision_dte.Controls.Add(this.facturacion_dte);
            this.emision_dte.Controls.Add(this.facturacion_exportacion);
            this.emision_dte.Location = new System.Drawing.Point(209, 15);
            this.emision_dte.Name = "emision_dte";
            this.emision_dte.Size = new System.Drawing.Size(187, 254);
            this.emision_dte.TabIndex = 1;
            this.emision_dte.TabStop = false;
            this.emision_dte.Text = "Emision DTE";
            // 
            // emision_nc_nd
            // 
            this.emision_nc_nd.Location = new System.Drawing.Point(7, 159);
            this.emision_nc_nd.Name = "emision_nc_nd";
            this.emision_nc_nd.Size = new System.Drawing.Size(173, 38);
            this.emision_nc_nd.TabIndex = 9;
            this.emision_nc_nd.Text = "Emisión NC/ND";
            this.emision_nc_nd.UseVisualStyleBackColor = true;
            this.emision_nc_nd.Click += new System.EventHandler(this.emision_nc_nd_Click);
            // 
            // facturacion_masiva
            // 
            this.facturacion_masiva.Location = new System.Drawing.Point(7, 115);
            this.facturacion_masiva.Name = "facturacion_masiva";
            this.facturacion_masiva.Size = new System.Drawing.Size(173, 38);
            this.facturacion_masiva.TabIndex = 8;
            this.facturacion_masiva.Text = "Facturación Masiva";
            this.facturacion_masiva.UseVisualStyleBackColor = true;
            this.facturacion_masiva.Click += new System.EventHandler(this.facturacion_masiva_Click);
            // 
            // facturacion_dte
            // 
            this.facturacion_dte.Location = new System.Drawing.Point(7, 27);
            this.facturacion_dte.Name = "facturacion_dte";
            this.facturacion_dte.Size = new System.Drawing.Size(173, 38);
            this.facturacion_dte.TabIndex = 5;
            this.facturacion_dte.Text = "Facturación DTE / Boletas";
            this.facturacion_dte.UseVisualStyleBackColor = true;
            this.facturacion_dte.Click += new System.EventHandler(this.facturacion_dte_boleta_Click);
            // 
            // facturacion_exportacion
            // 
            this.facturacion_exportacion.Location = new System.Drawing.Point(7, 71);
            this.facturacion_exportacion.Name = "facturacion_exportacion";
            this.facturacion_exportacion.Size = new System.Drawing.Size(173, 38);
            this.facturacion_exportacion.TabIndex = 7;
            this.facturacion_exportacion.Text = "Facturación Exportación";
            this.facturacion_exportacion.UseVisualStyleBackColor = true;
            this.facturacion_exportacion.Click += new System.EventHandler(this.facturacion_exportacion_Click);
            // 
            // obtenerdte
            // 
            this.obtenerdte.Controls.Add(this.obtener_sobre_xml);
            this.obtenerdte.Controls.Add(this.obtener_dte);
            this.obtenerdte.Controls.Add(this.obtener_xml);
            this.obtenerdte.Controls.Add(this.obtener_timbre);
            this.obtenerdte.Controls.Add(this.obtener_pdf);
            this.obtenerdte.Location = new System.Drawing.Point(18, 15);
            this.obtenerdte.Name = "obtenerdte";
            this.obtenerdte.Size = new System.Drawing.Size(172, 254);
            this.obtenerdte.TabIndex = 0;
            this.obtenerdte.TabStop = false;
            this.obtenerdte.Text = "DTE Emitido";
            // 
            // obtener_sobre_xml
            // 
            this.obtener_sobre_xml.Location = new System.Drawing.Point(14, 203);
            this.obtener_sobre_xml.Name = "obtener_sobre_xml";
            this.obtener_sobre_xml.Size = new System.Drawing.Size(145, 38);
            this.obtener_sobre_xml.TabIndex = 4;
            this.obtener_sobre_xml.Text = "Obtener SobreXML";
            this.obtener_sobre_xml.UseVisualStyleBackColor = true;
            this.obtener_sobre_xml.Click += new System.EventHandler(this.obtener_sobre_xml_Click);
            // 
            // obtener_dte
            // 
            this.obtener_dte.Location = new System.Drawing.Point(14, 159);
            this.obtener_dte.Name = "obtener_dte";
            this.obtener_dte.Size = new System.Drawing.Size(145, 38);
            this.obtener_dte.TabIndex = 3;
            this.obtener_dte.Text = "Obtener DTE";
            this.obtener_dte.UseVisualStyleBackColor = true;
            this.obtener_dte.Click += new System.EventHandler(this.obtener_dte_Click);
            // 
            // obtener_xml
            // 
            this.obtener_xml.Location = new System.Drawing.Point(14, 115);
            this.obtener_xml.Name = "obtener_xml";
            this.obtener_xml.Size = new System.Drawing.Size(145, 38);
            this.obtener_xml.TabIndex = 2;
            this.obtener_xml.Text = "Obtener XML";
            this.obtener_xml.UseVisualStyleBackColor = true;
            this.obtener_xml.Click += new System.EventHandler(this.obtener_xml_Click);
            // 
            // obtener_timbre
            // 
            this.obtener_timbre.Location = new System.Drawing.Point(14, 71);
            this.obtener_timbre.Name = "obtener_timbre";
            this.obtener_timbre.Size = new System.Drawing.Size(145, 38);
            this.obtener_timbre.TabIndex = 1;
            this.obtener_timbre.Text = "Obtener Timbre";
            this.obtener_timbre.UseVisualStyleBackColor = true;
            this.obtener_timbre.Click += new System.EventHandler(this.ObtenerTimbre_Click);
            // 
            // obtener_pdf
            // 
            this.obtener_pdf.Location = new System.Drawing.Point(14, 27);
            this.obtener_pdf.Name = "obtener_pdf";
            this.obtener_pdf.Size = new System.Drawing.Size(145, 38);
            this.obtener_pdf.TabIndex = 0;
            this.obtener_pdf.Text = "Obtener PDF";
            this.obtener_pdf.UseVisualStyleBackColor = true;
            this.obtener_pdf.Click += new System.EventHandler(this.obtener_pdf_Click);
            // 
            // item_productos
            // 
            this.item_productos.Location = new System.Drawing.Point(4, 22);
            this.item_productos.Name = "item_productos";
            this.item_productos.Padding = new System.Windows.Forms.Padding(3);
            this.item_productos.Size = new System.Drawing.Size(801, 289);
            this.item_productos.TabIndex = 1;
            this.item_productos.Text = "Productos";
            this.item_productos.UseVisualStyleBackColor = true;
            // 
            // item_clientes
            // 
            this.item_clientes.Location = new System.Drawing.Point(4, 22);
            this.item_clientes.Name = "item_clientes";
            this.item_clientes.Size = new System.Drawing.Size(801, 289);
            this.item_clientes.TabIndex = 3;
            this.item_clientes.Text = "Clientes";
            this.item_clientes.UseVisualStyleBackColor = true;
            // 
            // item_folios
            // 
            this.item_folios.Location = new System.Drawing.Point(4, 22);
            this.item_folios.Name = "item_folios";
            this.item_folios.Size = new System.Drawing.Size(801, 289);
            this.item_folios.TabIndex = 5;
            this.item_folios.Text = "Folios";
            this.item_folios.UseVisualStyleBackColor = true;
            // 
            // item_bh
            // 
            this.item_bh.Location = new System.Drawing.Point(4, 22);
            this.item_bh.Name = "item_bh";
            this.item_bh.Size = new System.Drawing.Size(801, 289);
            this.item_bh.TabIndex = 6;
            this.item_bh.Text = "Boletas de honorarios";
            this.item_bh.UseVisualStyleBackColor = true;
            // 
            // item_otros
            // 
            this.item_otros.Location = new System.Drawing.Point(4, 22);
            this.item_otros.Name = "item_otros";
            this.item_otros.Size = new System.Drawing.Size(801, 289);
            this.item_otros.TabIndex = 4;
            this.item_otros.Text = "Otros";
            this.item_otros.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Configuracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Configuracion
            // 
            this.Configuracion.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.ConfiguracionEdit16;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(115, 24);
            this.Configuracion.Text = "Configuración";
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Location = new System.Drawing.Point(595, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 254);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otros";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Conciliar Emitidos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(14, 29);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(158, 38);
            this.button16.TabIndex = 11;
            this.button16.Text = "Envio Mail";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 203);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(173, 38);
            this.button17.TabIndex = 10;
            this.button17.Text = "Listado DTE Emitido";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(14, 73);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(158, 38);
            this.button18.TabIndex = 12;
            this.button18.Text = "Consolidado de ventas";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // Conciliar_Recibidos
            // 
            this.Conciliar_Recibidos.Location = new System.Drawing.Point(15, 203);
            this.Conciliar_Recibidos.Name = "Conciliar_Recibidos";
            this.Conciliar_Recibidos.Size = new System.Drawing.Size(158, 38);
            this.Conciliar_Recibidos.TabIndex = 14;
            this.Conciliar_Recibidos.Text = "Conciliar Recibidos";
            this.Conciliar_Recibidos.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(832, 382);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleFactura-Demo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl2.ResumeLayout(false);
            this.item_facturacion.ResumeLayout(false);
            this.otros.ResumeLayout(false);
            this.emision_dte.ResumeLayout(false);
            this.obtenerdte.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage item_facturacion;
        private System.Windows.Forms.TabPage item_productos;
        private System.Windows.Forms.TabPage item_clientes;
        private System.Windows.Forms.TabPage item_otros;
        private System.Windows.Forms.TabPage item_folios;
        private System.Windows.Forms.TabPage item_bh;
        private System.Windows.Forms.GroupBox otros;
        private System.Windows.Forms.Button obtenerXmlRecibido;
        private System.Windows.Forms.Button Acuse;
        private System.Windows.Forms.Button obtener_pdfRecibido;
        private System.Windows.Forms.Button listadoDteRecibido;
        private System.Windows.Forms.GroupBox emision_dte;
        private System.Windows.Forms.Button emision_nc_nd;
        private System.Windows.Forms.Button facturacion_masiva;
        private System.Windows.Forms.Button facturacion_dte;
        private System.Windows.Forms.Button facturacion_exportacion;
        private System.Windows.Forms.GroupBox obtenerdte;
        private System.Windows.Forms.Button obtener_sobre_xml;
        private System.Windows.Forms.Button obtener_dte;
        private System.Windows.Forms.Button obtener_xml;
        private System.Windows.Forms.Button obtener_timbre;
        private System.Windows.Forms.Button obtener_pdf;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Configuracion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button Conciliar_Recibidos;
    }
}

