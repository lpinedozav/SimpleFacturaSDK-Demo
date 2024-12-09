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
            this.conciliar_emitidos_Recibidos = new System.Windows.Forms.Button();
            this.Acuse = new System.Windows.Forms.Button();
            this.envio_mail = new System.Windows.Forms.Button();
            this.consolidado_ventas = new System.Windows.Forms.Button();
            this.emision_dte = new System.Windows.Forms.GroupBox();
            this.emision_nc_nd = new System.Windows.Forms.Button();
            this.facturacion_masiva = new System.Windows.Forms.Button();
            this.facturacion_dte = new System.Windows.Forms.Button();
            this.listado_dte_emitido_Recibido = new System.Windows.Forms.Button();
            this.facturacion_exportacion = new System.Windows.Forms.Button();
            this.obtenerdte = new System.Windows.Forms.GroupBox();
            this.obtener_sobre_xml = new System.Windows.Forms.Button();
            this.obtener_dte = new System.Windows.Forms.Button();
            this.obtener_xml = new System.Windows.Forms.Button();
            this.obtener_timbre = new System.Windows.Forms.Button();
            this.obtener_pdf = new System.Windows.Forms.Button();
            this.item_otros = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.consultarFolios = new System.Windows.Forms.Button();
            this.FoliosSinUso = new System.Windows.Forms.Button();
            this.FoliosDisponibles = new System.Windows.Forms.Button();
            this.solicitarFolios = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Listado_BHE_Emitidas_Recibidas = new System.Windows.Forms.Button();
            this.obtenerPdf_Emitidas_Recibidas = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listar_productos = new System.Windows.Forms.Button();
            this.agregar_productos = new System.Windows.Forms.Button();
            this.Configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listarClientes = new System.Windows.Forms.Button();
            this.agregarClientes = new System.Windows.Forms.Button();
            this.datosEmpresa = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button24 = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.item_facturacion.SuspendLayout();
            this.otros.SuspendLayout();
            this.emision_dte.SuspendLayout();
            this.obtenerdte.SuspendLayout();
            this.item_otros.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.item_facturacion);
            this.tabControl2.Controls.Add(this.item_otros);
            this.tabControl2.Location = new System.Drawing.Point(12, 42);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(623, 311);
            this.tabControl2.TabIndex = 1;
            // 
            // item_facturacion
            // 
            this.item_facturacion.Controls.Add(this.otros);
            this.item_facturacion.Controls.Add(this.emision_dte);
            this.item_facturacion.Controls.Add(this.obtenerdte);
            this.item_facturacion.Location = new System.Drawing.Point(4, 22);
            this.item_facturacion.Name = "item_facturacion";
            this.item_facturacion.Padding = new System.Windows.Forms.Padding(3);
            this.item_facturacion.Size = new System.Drawing.Size(615, 285);
            this.item_facturacion.TabIndex = 0;
            this.item_facturacion.Text = "Facturación";
            this.item_facturacion.UseVisualStyleBackColor = true;
            // 
            // otros
            // 
            this.otros.Controls.Add(this.conciliar_emitidos_Recibidos);
            this.otros.Controls.Add(this.Acuse);
            this.otros.Controls.Add(this.envio_mail);
            this.otros.Controls.Add(this.consolidado_ventas);
            this.otros.Location = new System.Drawing.Point(412, 15);
            this.otros.Name = "otros";
            this.otros.Size = new System.Drawing.Size(191, 254);
            this.otros.TabIndex = 2;
            this.otros.TabStop = false;
            this.otros.Text = "Otros";
            // 
            // conciliar_emitidos_Recibidos
            // 
            this.conciliar_emitidos_Recibidos.Location = new System.Drawing.Point(15, 117);
            this.conciliar_emitidos_Recibidos.Name = "conciliar_emitidos_Recibidos";
            this.conciliar_emitidos_Recibidos.Size = new System.Drawing.Size(164, 38);
            this.conciliar_emitidos_Recibidos.TabIndex = 13;
            this.conciliar_emitidos_Recibidos.Text = "Conciliar Emitido / Recibido";
            this.conciliar_emitidos_Recibidos.UseVisualStyleBackColor = true;
            this.conciliar_emitidos_Recibidos.Click += new System.EventHandler(this.conciliar_emitidos_Recibidos_Click);
            // 
            // Acuse
            // 
            this.Acuse.Location = new System.Drawing.Point(15, 161);
            this.Acuse.Name = "Acuse";
            this.Acuse.Size = new System.Drawing.Size(164, 38);
            this.Acuse.TabIndex = 11;
            this.Acuse.Text = "Aceptar o Recharzar DTE";
            this.Acuse.UseVisualStyleBackColor = true;
            this.Acuse.Click += new System.EventHandler(this.Acuse_Click);
            // 
            // envio_mail
            // 
            this.envio_mail.Location = new System.Drawing.Point(15, 27);
            this.envio_mail.Name = "envio_mail";
            this.envio_mail.Size = new System.Drawing.Size(164, 38);
            this.envio_mail.TabIndex = 11;
            this.envio_mail.Text = "Envio Mail";
            this.envio_mail.UseVisualStyleBackColor = true;
            this.envio_mail.Click += new System.EventHandler(this.envio_mail_Click);
            // 
            // consolidado_ventas
            // 
            this.consolidado_ventas.Location = new System.Drawing.Point(15, 73);
            this.consolidado_ventas.Name = "consolidado_ventas";
            this.consolidado_ventas.Size = new System.Drawing.Size(164, 38);
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
            this.emision_dte.Controls.Add(this.listado_dte_emitido_Recibido);
            this.emision_dte.Controls.Add(this.facturacion_exportacion);
            this.emision_dte.Location = new System.Drawing.Point(215, 15);
            this.emision_dte.Name = "emision_dte";
            this.emision_dte.Size = new System.Drawing.Size(191, 254);
            this.emision_dte.TabIndex = 1;
            this.emision_dte.TabStop = false;
            this.emision_dte.Text = "Emision DTE";
            // 
            // emision_nc_nd
            // 
            this.emision_nc_nd.Location = new System.Drawing.Point(14, 159);
            this.emision_nc_nd.Name = "emision_nc_nd";
            this.emision_nc_nd.Size = new System.Drawing.Size(164, 38);
            this.emision_nc_nd.TabIndex = 9;
            this.emision_nc_nd.Text = "Emisión NC/ND";
            this.emision_nc_nd.UseVisualStyleBackColor = true;
            this.emision_nc_nd.Click += new System.EventHandler(this.emision_nc_nd_Click);
            // 
            // facturacion_masiva
            // 
            this.facturacion_masiva.Location = new System.Drawing.Point(14, 115);
            this.facturacion_masiva.Name = "facturacion_masiva";
            this.facturacion_masiva.Size = new System.Drawing.Size(164, 38);
            this.facturacion_masiva.TabIndex = 8;
            this.facturacion_masiva.Text = "Facturación Masiva";
            this.facturacion_masiva.UseVisualStyleBackColor = true;
            this.facturacion_masiva.Click += new System.EventHandler(this.facturacion_masiva_Click);
            // 
            // facturacion_dte
            // 
            this.facturacion_dte.Location = new System.Drawing.Point(14, 27);
            this.facturacion_dte.Name = "facturacion_dte";
            this.facturacion_dte.Size = new System.Drawing.Size(164, 38);
            this.facturacion_dte.TabIndex = 5;
            this.facturacion_dte.Text = "Facturación DTE / Boletas";
            this.facturacion_dte.UseVisualStyleBackColor = true;
            this.facturacion_dte.Click += new System.EventHandler(this.facturacion_dte_boleta_Click);
            // 
            // listado_dte_emitido_Recibido
            // 
            this.listado_dte_emitido_Recibido.Location = new System.Drawing.Point(14, 203);
            this.listado_dte_emitido_Recibido.Name = "listado_dte_emitido_Recibido";
            this.listado_dte_emitido_Recibido.Size = new System.Drawing.Size(164, 38);
            this.listado_dte_emitido_Recibido.TabIndex = 10;
            this.listado_dte_emitido_Recibido.Text = "Listado DTE Emitido / Recibido";
            this.listado_dte_emitido_Recibido.UseVisualStyleBackColor = true;
            this.listado_dte_emitido_Recibido.Click += new System.EventHandler(this.listado_dte_emitido_Recibido_Click);
            // 
            // facturacion_exportacion
            // 
            this.facturacion_exportacion.Location = new System.Drawing.Point(14, 71);
            this.facturacion_exportacion.Name = "facturacion_exportacion";
            this.facturacion_exportacion.Size = new System.Drawing.Size(164, 38);
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
            this.obtenerdte.Size = new System.Drawing.Size(191, 254);
            this.obtenerdte.TabIndex = 0;
            this.obtenerdte.TabStop = false;
            this.obtenerdte.Text = "Obtener DTE";
            // 
            // obtener_sobre_xml
            // 
            this.obtener_sobre_xml.Location = new System.Drawing.Point(14, 203);
            this.obtener_sobre_xml.Name = "obtener_sobre_xml";
            this.obtener_sobre_xml.Size = new System.Drawing.Size(164, 38);
            this.obtener_sobre_xml.TabIndex = 4;
            this.obtener_sobre_xml.Text = "Obtener SobreXML";
            this.obtener_sobre_xml.UseVisualStyleBackColor = true;
            this.obtener_sobre_xml.Click += new System.EventHandler(this.obtener_sobre_xml_Click);
            // 
            // obtener_dte
            // 
            this.obtener_dte.Location = new System.Drawing.Point(14, 159);
            this.obtener_dte.Name = "obtener_dte";
            this.obtener_dte.Size = new System.Drawing.Size(164, 38);
            this.obtener_dte.TabIndex = 3;
            this.obtener_dte.Text = "Obtener DTE";
            this.obtener_dte.UseVisualStyleBackColor = true;
            this.obtener_dte.Click += new System.EventHandler(this.obtener_dte_Click);
            // 
            // obtener_xml
            // 
            this.obtener_xml.Location = new System.Drawing.Point(14, 115);
            this.obtener_xml.Name = "obtener_xml";
            this.obtener_xml.Size = new System.Drawing.Size(164, 38);
            this.obtener_xml.TabIndex = 2;
            this.obtener_xml.Text = "Obtener XML";
            this.obtener_xml.UseVisualStyleBackColor = true;
            this.obtener_xml.Click += new System.EventHandler(this.obtener_xml_Click);
            // 
            // obtener_timbre
            // 
            this.obtener_timbre.Location = new System.Drawing.Point(14, 71);
            this.obtener_timbre.Name = "obtener_timbre";
            this.obtener_timbre.Size = new System.Drawing.Size(164, 38);
            this.obtener_timbre.TabIndex = 1;
            this.obtener_timbre.Text = "Obtener Timbre";
            this.obtener_timbre.UseVisualStyleBackColor = true;
            this.obtener_timbre.Click += new System.EventHandler(this.ObtenerTimbre_Click);
            // 
            // obtener_pdf
            // 
            this.obtener_pdf.Location = new System.Drawing.Point(14, 27);
            this.obtener_pdf.Name = "obtener_pdf";
            this.obtener_pdf.Size = new System.Drawing.Size(164, 38);
            this.obtener_pdf.TabIndex = 0;
            this.obtener_pdf.Text = "Obtener PDF";
            this.obtener_pdf.UseVisualStyleBackColor = true;
            this.obtener_pdf.Click += new System.EventHandler(this.obtener_pdf_Click);
            // 
            // item_otros
            // 
            this.item_otros.Controls.Add(this.groupBox9);
            this.item_otros.Controls.Add(this.groupBox7);
            this.item_otros.Controls.Add(this.groupBox4);
            this.item_otros.Controls.Add(this.groupBox5);
            this.item_otros.Controls.Add(this.groupBox6);
            this.item_otros.Location = new System.Drawing.Point(4, 22);
            this.item_otros.Name = "item_otros";
            this.item_otros.Size = new System.Drawing.Size(615, 285);
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
            this.menuStrip1.Size = new System.Drawing.Size(644, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.consultarFolios);
            this.groupBox4.Controls.Add(this.FoliosSinUso);
            this.groupBox4.Controls.Add(this.FoliosDisponibles);
            this.groupBox4.Controls.Add(this.solicitarFolios);
            this.groupBox4.Location = new System.Drawing.Point(409, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 250);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Folios";
            // 
            // consultarFolios
            // 
            this.consultarFolios.Location = new System.Drawing.Point(15, 107);
            this.consultarFolios.Name = "consultarFolios";
            this.consultarFolios.Size = new System.Drawing.Size(164, 38);
            this.consultarFolios.TabIndex = 13;
            this.consultarFolios.Text = "Consultar Folios";
            this.consultarFolios.UseVisualStyleBackColor = true;
            // 
            // FoliosSinUso
            // 
            this.FoliosSinUso.Location = new System.Drawing.Point(15, 151);
            this.FoliosSinUso.Name = "FoliosSinUso";
            this.FoliosSinUso.Size = new System.Drawing.Size(164, 38);
            this.FoliosSinUso.TabIndex = 11;
            this.FoliosSinUso.Text = "Folios Sin Uso";
            this.FoliosSinUso.UseVisualStyleBackColor = true;
            // 
            // FoliosDisponibles
            // 
            this.FoliosDisponibles.Location = new System.Drawing.Point(15, 19);
            this.FoliosDisponibles.Name = "FoliosDisponibles";
            this.FoliosDisponibles.Size = new System.Drawing.Size(164, 38);
            this.FoliosDisponibles.TabIndex = 11;
            this.FoliosDisponibles.Text = "Consulta Folios Disponibles";
            this.FoliosDisponibles.UseVisualStyleBackColor = true;
            // 
            // solicitarFolios
            // 
            this.solicitarFolios.Location = new System.Drawing.Point(15, 63);
            this.solicitarFolios.Name = "solicitarFolios";
            this.solicitarFolios.Size = new System.Drawing.Size(164, 38);
            this.solicitarFolios.TabIndex = 12;
            this.solicitarFolios.Text = "Solicitar Folios";
            this.solicitarFolios.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Listado_BHE_Emitidas_Recibidas);
            this.groupBox5.Controls.Add(this.obtenerPdf_Emitidas_Recibidas);
            this.groupBox5.Location = new System.Drawing.Point(15, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 122);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Boletas de Honorarios";
            // 
            // Listado_BHE_Emitidas_Recibidas
            // 
            this.Listado_BHE_Emitidas_Recibidas.Location = new System.Drawing.Point(14, 67);
            this.Listado_BHE_Emitidas_Recibidas.Name = "Listado_BHE_Emitidas_Recibidas";
            this.Listado_BHE_Emitidas_Recibidas.Size = new System.Drawing.Size(164, 38);
            this.Listado_BHE_Emitidas_Recibidas.TabIndex = 9;
            this.Listado_BHE_Emitidas_Recibidas.Text = "Listado BHE";
            this.Listado_BHE_Emitidas_Recibidas.UseVisualStyleBackColor = true;
            // 
            // obtenerPdf_Emitidas_Recibidas
            // 
            this.obtenerPdf_Emitidas_Recibidas.Location = new System.Drawing.Point(14, 23);
            this.obtenerPdf_Emitidas_Recibidas.Name = "obtenerPdf_Emitidas_Recibidas";
            this.obtenerPdf_Emitidas_Recibidas.Size = new System.Drawing.Size(164, 38);
            this.obtenerPdf_Emitidas_Recibidas.TabIndex = 8;
            this.obtenerPdf_Emitidas_Recibidas.Text = "Obtener PDF BHE";
            this.obtenerPdf_Emitidas_Recibidas.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listar_productos);
            this.groupBox6.Controls.Add(this.agregar_productos);
            this.groupBox6.Location = new System.Drawing.Point(15, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(191, 122);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Productos";
            // 
            // listar_productos
            // 
            this.listar_productos.Location = new System.Drawing.Point(14, 67);
            this.listar_productos.Name = "listar_productos";
            this.listar_productos.Size = new System.Drawing.Size(164, 38);
            this.listar_productos.TabIndex = 1;
            this.listar_productos.Text = "Listar Productos";
            this.listar_productos.UseVisualStyleBackColor = true;
            this.listar_productos.Click += new System.EventHandler(this.listar_productos_Click);
            // 
            // agregar_productos
            // 
            this.agregar_productos.Location = new System.Drawing.Point(14, 23);
            this.agregar_productos.Name = "agregar_productos";
            this.agregar_productos.Size = new System.Drawing.Size(164, 38);
            this.agregar_productos.TabIndex = 0;
            this.agregar_productos.Text = "Agregar Productos";
            this.agregar_productos.UseVisualStyleBackColor = true;
            this.agregar_productos.Click += new System.EventHandler(this.agregar_productos_Click);
            // 
            // Configuracion
            // 
            this.Configuracion.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.ConfiguracionEdit16;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(115, 24);
            this.Configuracion.Text = "Configuración";
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listarClientes);
            this.groupBox7.Controls.Add(this.agregarClientes);
            this.groupBox7.Location = new System.Drawing.Point(212, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(191, 122);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Clientes";
            // 
            // listarClientes
            // 
            this.listarClientes.Location = new System.Drawing.Point(13, 67);
            this.listarClientes.Name = "listarClientes";
            this.listarClientes.Size = new System.Drawing.Size(164, 38);
            this.listarClientes.TabIndex = 1;
            this.listarClientes.Text = "Listar Clientes";
            this.listarClientes.UseVisualStyleBackColor = true;
            // 
            // agregarClientes
            // 
            this.agregarClientes.Location = new System.Drawing.Point(13, 23);
            this.agregarClientes.Name = "agregarClientes";
            this.agregarClientes.Size = new System.Drawing.Size(164, 38);
            this.agregarClientes.TabIndex = 0;
            this.agregarClientes.Text = "Agregar Clientes";
            this.agregarClientes.UseVisualStyleBackColor = true;
            // 
            // datosEmpresa
            // 
            this.datosEmpresa.Location = new System.Drawing.Point(14, 67);
            this.datosEmpresa.Name = "datosEmpresa";
            this.datosEmpresa.Size = new System.Drawing.Size(164, 38);
            this.datosEmpresa.TabIndex = 0;
            this.datosEmpresa.Text = "Datos de Empresa";
            this.datosEmpresa.UseVisualStyleBackColor = true;
            this.datosEmpresa.Click += new System.EventHandler(this.datosEmpresa_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.datosEmpresa);
            this.groupBox9.Controls.Add(this.button24);
            this.groupBox9.Location = new System.Drawing.Point(212, 145);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(191, 122);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Otros";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(14, 23);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(164, 38);
            this.button24.TabIndex = 0;
            this.button24.Text = "Listado Sucursales";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(644, 369);
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
            this.item_otros.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage item_otros;
        private System.Windows.Forms.GroupBox otros;
        private System.Windows.Forms.Button conciliar_emitidos_Recibidos;
        private System.Windows.Forms.Button envio_mail;
        private System.Windows.Forms.Button listado_dte_emitido_Recibido;
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
        private System.Windows.Forms.Button Acuse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button consultarFolios;
        private System.Windows.Forms.Button FoliosSinUso;
        private System.Windows.Forms.Button FoliosDisponibles;
        private System.Windows.Forms.Button solicitarFolios;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Listado_BHE_Emitidas_Recibidas;
        private System.Windows.Forms.Button obtenerPdf_Emitidas_Recibidas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button listar_productos;
        private System.Windows.Forms.Button agregar_productos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button listarClientes;
        private System.Windows.Forms.Button agregarClientes;
        private System.Windows.Forms.Button datosEmpresa;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button24;
    }
}

