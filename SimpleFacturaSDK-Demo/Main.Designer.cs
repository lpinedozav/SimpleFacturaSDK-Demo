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
            this.conciliar_emitidos = new System.Windows.Forms.Button();
            this.envio_mail = new System.Windows.Forms.Button();
            this.consolidado_ventas = new System.Windows.Forms.Button();
            this.dte_recibidos = new System.Windows.Forms.GroupBox();
            this.obtener_pdfRecibido = new System.Windows.Forms.Button();
            this.Conciliar_Recibidos = new System.Windows.Forms.Button();
            this.obtener_xmlRecibido = new System.Windows.Forms.Button();
            this.Acuse = new System.Windows.Forms.Button();
            this.listado_DteRecibido = new System.Windows.Forms.Button();
            this.emision_dte = new System.Windows.Forms.GroupBox();
            this.emision_nc_nd = new System.Windows.Forms.Button();
            this.facturacion_masiva = new System.Windows.Forms.Button();
            this.facturacion_dte = new System.Windows.Forms.Button();
            this.listado_dte_emitido = new System.Windows.Forms.Button();
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
            this.tabControl2.SuspendLayout();
            this.item_facturacion.SuspendLayout();
            this.otros.SuspendLayout();
            this.dte_recibidos.SuspendLayout();
            this.emision_dte.SuspendLayout();
            this.obtenerdte.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tabControl2.Size = new System.Drawing.Size(779, 315);
            this.tabControl2.TabIndex = 1;
            // 
            // item_facturacion
            // 
            this.item_facturacion.Controls.Add(this.otros);
            this.item_facturacion.Controls.Add(this.dte_recibidos);
            this.item_facturacion.Controls.Add(this.emision_dte);
            this.item_facturacion.Controls.Add(this.obtenerdte);
            this.item_facturacion.Location = new System.Drawing.Point(4, 25);
            this.item_facturacion.Name = "item_facturacion";
            this.item_facturacion.Padding = new System.Windows.Forms.Padding(3);
            this.item_facturacion.Size = new System.Drawing.Size(771, 286);
            this.item_facturacion.TabIndex = 0;
            this.item_facturacion.Text = "Facturación";
            this.item_facturacion.UseVisualStyleBackColor = true;
            // 
            // otros
            // 
            this.otros.Controls.Add(this.conciliar_emitidos);
            this.otros.Controls.Add(this.envio_mail);
            this.otros.Controls.Add(this.consolidado_ventas);
            this.otros.Location = new System.Drawing.Point(567, 15);
            this.otros.Name = "otros";
            this.otros.Size = new System.Drawing.Size(187, 254);
            this.otros.TabIndex = 2;
            this.otros.TabStop = false;
            this.otros.Text = "Otros";
            // 
            // conciliar_emitidos
            // 
            this.conciliar_emitidos.Location = new System.Drawing.Point(15, 117);
            this.conciliar_emitidos.Name = "conciliar_emitidos";
            this.conciliar_emitidos.Size = new System.Drawing.Size(158, 38);
            this.conciliar_emitidos.TabIndex = 13;
            this.conciliar_emitidos.Text = "Conciliar Emitidos";
            this.conciliar_emitidos.UseVisualStyleBackColor = true;
            this.conciliar_emitidos.Click += new System.EventHandler(this.conciliar_emitidos_Click);
            // 
            // envio_mail
            // 
            this.envio_mail.Location = new System.Drawing.Point(15, 27);
            this.envio_mail.Name = "envio_mail";
            this.envio_mail.Size = new System.Drawing.Size(158, 38);
            this.envio_mail.TabIndex = 11;
            this.envio_mail.Text = "Envio Mail";
            this.envio_mail.UseVisualStyleBackColor = true;
            this.envio_mail.Click += new System.EventHandler(this.envio_mail_Click);
            // 
            // consolidado_ventas
            // 
            this.consolidado_ventas.Location = new System.Drawing.Point(15, 73);
            this.consolidado_ventas.Name = "consolidado_ventas";
            this.consolidado_ventas.Size = new System.Drawing.Size(158, 38);
            this.consolidado_ventas.TabIndex = 12;
            this.consolidado_ventas.Text = "Consolidado de ventas";
            this.consolidado_ventas.UseVisualStyleBackColor = true;
            this.consolidado_ventas.Click += new System.EventHandler(this.consolidado_ventas_Click);
            // 
            // dte_recibidos
            // 
            this.dte_recibidos.Controls.Add(this.obtener_pdfRecibido);
            this.dte_recibidos.Controls.Add(this.Conciliar_Recibidos);
            this.dte_recibidos.Controls.Add(this.obtener_xmlRecibido);
            this.dte_recibidos.Controls.Add(this.Acuse);
            this.dte_recibidos.Controls.Add(this.listado_DteRecibido);
            this.dte_recibidos.Location = new System.Drawing.Point(374, 15);
            this.dte_recibidos.Name = "dte_recibidos";
            this.dte_recibidos.Size = new System.Drawing.Size(187, 254);
            this.dte_recibidos.TabIndex = 14;
            this.dte_recibidos.TabStop = false;
            this.dte_recibidos.Text = "DTE Recibidos";
            // 
            // obtener_pdfRecibido
            // 
            this.obtener_pdfRecibido.Location = new System.Drawing.Point(14, 159);
            this.obtener_pdfRecibido.Name = "obtener_pdfRecibido";
            this.obtener_pdfRecibido.Size = new System.Drawing.Size(158, 38);
            this.obtener_pdfRecibido.TabIndex = 15;
            this.obtener_pdfRecibido.Text = "Obtener PDF";
            this.obtener_pdfRecibido.UseVisualStyleBackColor = true;
            this.obtener_pdfRecibido.Click += new System.EventHandler(this.obtener_pdfRecibido_Click);
            // 
            // Conciliar_Recibidos
            // 
            this.Conciliar_Recibidos.Location = new System.Drawing.Point(14, 203);
            this.Conciliar_Recibidos.Name = "Conciliar_Recibidos";
            this.Conciliar_Recibidos.Size = new System.Drawing.Size(158, 38);
            this.Conciliar_Recibidos.TabIndex = 14;
            this.Conciliar_Recibidos.Text = "Conciliar Recibidos";
            this.Conciliar_Recibidos.UseVisualStyleBackColor = true;
            this.Conciliar_Recibidos.Click += new System.EventHandler(this.Conciliar_Recibidos_Click);
            // 
            // obtener_xmlRecibido
            // 
            this.obtener_xmlRecibido.Location = new System.Drawing.Point(14, 117);
            this.obtener_xmlRecibido.Name = "obtener_xmlRecibido";
            this.obtener_xmlRecibido.Size = new System.Drawing.Size(158, 38);
            this.obtener_xmlRecibido.TabIndex = 13;
            this.obtener_xmlRecibido.Text = "Obtener XML";
            this.obtener_xmlRecibido.UseVisualStyleBackColor = true;
            // 
            // Acuse
            // 
            this.Acuse.Location = new System.Drawing.Point(14, 29);
            this.Acuse.Name = "Acuse";
            this.Acuse.Size = new System.Drawing.Size(158, 38);
            this.Acuse.TabIndex = 11;
            this.Acuse.Text = "Aceptar o Rechazar DTE";
            this.Acuse.UseVisualStyleBackColor = true;
            this.Acuse.Click += new System.EventHandler(this.Acuse_Click);
            // 
            // listado_DteRecibido
            // 
            this.listado_DteRecibido.Location = new System.Drawing.Point(14, 73);
            this.listado_DteRecibido.Name = "listado_DteRecibido";
            this.listado_DteRecibido.Size = new System.Drawing.Size(158, 38);
            this.listado_DteRecibido.TabIndex = 12;
            this.listado_DteRecibido.Text = "Listado DTE Recibido";
            this.listado_DteRecibido.UseVisualStyleBackColor = true;
            // 
            // otros
            // 
            this.otros.Controls.Add(this.conciliar_emitidos);
            this.otros.Controls.Add(this.envio_mail);
            this.otros.Controls.Add(this.consolidado_ventas);
            this.otros.Location = new System.Drawing.Point(567, 15);
            this.otros.Name = "otros";
            this.otros.Size = new System.Drawing.Size(187, 254);
            this.otros.TabIndex = 2;
            this.otros.TabStop = false;
            this.otros.Text = "Otros";
            // 
            // Conciliar_Recibidos
            // 
            this.Conciliar_Recibidos.Location = new System.Drawing.Point(14, 203);
            this.Conciliar_Recibidos.Name = "Conciliar_Recibidos";
            this.Conciliar_Recibidos.Size = new System.Drawing.Size(158, 38);
            this.Conciliar_Recibidos.TabIndex = 14;
            this.Conciliar_Recibidos.Text = "Conciliar Recibidos";
            this.Conciliar_Recibidos.UseVisualStyleBackColor = true;
            // 
            // conciliar_emitidos
            // 
            this.conciliar_emitidos.Location = new System.Drawing.Point(15, 117);
            this.conciliar_emitidos.Name = "conciliar_emitidos";
            this.conciliar_emitidos.Size = new System.Drawing.Size(158, 38);
            this.conciliar_emitidos.TabIndex = 13;
            this.conciliar_emitidos.Text = "Conciliar Emitidos";
            this.conciliar_emitidos.UseVisualStyleBackColor = true;
            this.conciliar_emitidos.Click += new System.EventHandler(this.conciliar_emitidos_Click);
            // 
            // envio_mail
            // 
            this.envio_mail.Location = new System.Drawing.Point(15, 27);
            this.envio_mail.Name = "envio_mail";
            this.envio_mail.Size = new System.Drawing.Size(158, 38);
            this.envio_mail.TabIndex = 11;
            this.envio_mail.Text = "Envio Mail";
            this.envio_mail.UseVisualStyleBackColor = true;
            this.envio_mail.Click += new System.EventHandler(this.envio_mail_Click);
            // 
            // listado_dte_emitido
            // 
            this.listado_dte_emitido.Location = new System.Drawing.Point(14, 203);
            this.listado_dte_emitido.Name = "listado_dte_emitido";
            this.listado_dte_emitido.Size = new System.Drawing.Size(145, 38);
            this.listado_dte_emitido.TabIndex = 10;
            this.listado_dte_emitido.Text = "Listado DTE Emitido";
            this.listado_dte_emitido.UseVisualStyleBackColor = true;
            this.listado_dte_emitido.Click += new System.EventHandler(this.listado_dte_emitido_Click);
            // 
            // consolidado_ventas
            // 
            this.consolidado_ventas.Location = new System.Drawing.Point(15, 73);
            this.consolidado_ventas.Name = "consolidado_ventas";
            this.consolidado_ventas.Size = new System.Drawing.Size(158, 38);
            this.consolidado_ventas.TabIndex = 12;
            this.consolidado_ventas.Text = "Consolidado de ventas";
            this.consolidado_ventas.UseVisualStyleBackColor = true;
            this.consolidado_ventas.Click += new System.EventHandler(this.consolidado_ventas_Click);
            // 
            // emision_dte
            // 
            this.emision_dte.Controls.Add(this.emision_nc_nd);
            this.emision_dte.Controls.Add(this.facturacion_masiva);
            this.emision_dte.Controls.Add(this.facturacion_dte);
            this.emision_dte.Controls.Add(this.listado_dte_emitido);
            this.emision_dte.Controls.Add(this.facturacion_exportacion);
            this.emision_dte.Location = new System.Drawing.Point(196, 15);
            this.emision_dte.Name = "emision_dte";
            this.emision_dte.Size = new System.Drawing.Size(172, 254);
            this.emision_dte.TabIndex = 1;
            this.emision_dte.TabStop = false;
            this.emision_dte.Text = "Emision DTE";
            // 
            // emision_nc_nd
            // 
            this.emision_nc_nd.Location = new System.Drawing.Point(14, 159);
            this.emision_nc_nd.Name = "emision_nc_nd";
            this.emision_nc_nd.Size = new System.Drawing.Size(145, 38);
            this.emision_nc_nd.TabIndex = 9;
            this.emision_nc_nd.Text = "Emisión NC/ND";
            this.emision_nc_nd.UseVisualStyleBackColor = true;
            this.emision_nc_nd.Click += new System.EventHandler(this.emision_nc_nd_Click);
            // 
            // facturacion_masiva
            // 
            this.facturacion_masiva.Location = new System.Drawing.Point(14, 115);
            this.facturacion_masiva.Name = "facturacion_masiva";
            this.facturacion_masiva.Size = new System.Drawing.Size(145, 38);
            this.facturacion_masiva.TabIndex = 8;
            this.facturacion_masiva.Text = "Facturación Masiva";
            this.facturacion_masiva.UseVisualStyleBackColor = true;
            this.facturacion_masiva.Click += new System.EventHandler(this.facturacion_masiva_Click);
            // 
            // facturacion_dte
            // 
            this.facturacion_dte.Location = new System.Drawing.Point(14, 27);
            this.facturacion_dte.Name = "facturacion_dte";
            this.facturacion_dte.Size = new System.Drawing.Size(145, 38);
            this.facturacion_dte.TabIndex = 5;
            this.facturacion_dte.Text = "Facturación DTE / Boletas";
            this.facturacion_dte.UseVisualStyleBackColor = true;
            this.facturacion_dte.Click += new System.EventHandler(this.facturacion_dte_boleta_Click);
            // 
            // listado_dte_emitido
            // 
            this.listado_dte_emitido.Location = new System.Drawing.Point(14, 203);
            this.listado_dte_emitido.Name = "listado_dte_emitido";
            this.listado_dte_emitido.Size = new System.Drawing.Size(145, 38);
            this.listado_dte_emitido.TabIndex = 10;
            this.listado_dte_emitido.Text = "Listado DTE Emitido";
            this.listado_dte_emitido.UseVisualStyleBackColor = true;
            this.listado_dte_emitido.Click += new System.EventHandler(this.listado_dte_emitido_Click);
            // 
            // facturacion_exportacion
            // 
            this.facturacion_exportacion.Location = new System.Drawing.Point(14, 71);
            this.facturacion_exportacion.Name = "facturacion_exportacion";
            this.facturacion_exportacion.Size = new System.Drawing.Size(145, 38);
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
            this.obtenerdte.Text = "DTE Emitidos";
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
            this.item_productos.Location = new System.Drawing.Point(4, 25);
            this.item_productos.Name = "item_productos";
            this.item_productos.Padding = new System.Windows.Forms.Padding(3);
            this.item_productos.Size = new System.Drawing.Size(771, 286);
            this.item_productos.TabIndex = 1;
            this.item_productos.Text = "Productos";
            this.item_productos.UseVisualStyleBackColor = true;
            // 
            // item_clientes
            // 
            this.item_clientes.Location = new System.Drawing.Point(4, 25);
            this.item_clientes.Name = "item_clientes";
            this.item_clientes.Size = new System.Drawing.Size(771, 286);
            this.item_clientes.TabIndex = 3;
            this.item_clientes.Text = "Clientes";
            this.item_clientes.UseVisualStyleBackColor = true;
            // 
            // item_folios
            // 
            this.item_folios.Location = new System.Drawing.Point(4, 25);
            this.item_folios.Name = "item_folios";
            this.item_folios.Size = new System.Drawing.Size(771, 286);
            this.item_folios.TabIndex = 5;
            this.item_folios.Text = "Folios";
            this.item_folios.UseVisualStyleBackColor = true;
            // 
            // item_bh
            // 
            this.item_bh.Location = new System.Drawing.Point(4, 25);
            this.item_bh.Name = "item_bh";
            this.item_bh.Size = new System.Drawing.Size(771, 286);
            this.item_bh.TabIndex = 6;
            this.item_bh.Text = "Boletas de honorarios";
            this.item_bh.UseVisualStyleBackColor = true;
            // 
            // item_otros
            // 
            this.item_otros.Location = new System.Drawing.Point(4, 25);
            this.item_otros.Name = "item_otros";
            this.item_otros.Size = new System.Drawing.Size(771, 286);
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
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Configuracion
            // 
            this.Configuracion.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.ConfiguracionEdit16;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(136, 24);
            this.Configuracion.Text = "Configuración";
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // obtener_pdfRecibido
            // 
            this.obtener_pdfRecibido.Location = new System.Drawing.Point(14, 159);
            this.obtener_pdfRecibido.Name = "obtener_pdfRecibido";
            this.obtener_pdfRecibido.Size = new System.Drawing.Size(158, 38);
            this.obtener_pdfRecibido.TabIndex = 15;
            this.obtener_pdfRecibido.Text = "Obtener PDF";
            this.obtener_pdfRecibido.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(801, 382);
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
            this.dte_recibidos.ResumeLayout(false);
            this.emision_dte.ResumeLayout(false);
            this.obtenerdte.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button conciliar_emitidos;
        private System.Windows.Forms.Button envio_mail;
        private System.Windows.Forms.Button listado_dte_emitido;
        private System.Windows.Forms.Button consolidado_ventas;
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
        private System.Windows.Forms.GroupBox dte_recibidos;
        private System.Windows.Forms.Button obtener_xmlRecibido;
        private System.Windows.Forms.Button Acuse;
        private System.Windows.Forms.Button listado_DteRecibido;
        private System.Windows.Forms.Button Conciliar_Recibidos;
        private System.Windows.Forms.Button obtener_pdfRecibido;
    }
}

