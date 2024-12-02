using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFacturaSDK_Demo.Models
{
    public class Configuracion
    {
        public SDKSettings SDKSettings { get; set; } = new SDKSettings();

        public void GenerarArchivo()
        {
            // Escribe la configuración en el archivo appsettings.json
            File.WriteAllText("appsettings.json", JsonConvert.SerializeObject(this, Formatting.Indented), Encoding.UTF8);
        }

        public bool LeerArchivo()
        {
            try
            {
                // Lee la configuración desde el archivo appsettings.json
                var conf = JsonConvert.DeserializeObject<Configuracion>(File.ReadAllText("appsettings.json", Encoding.UTF8));
                this.SDKSettings = conf.SDKSettings ?? new SDKSettings();
                return true;
            }
            catch
            {
                // Si falla, inicializa con valores por defecto
                InicializarArchivo();
            }
            return false;
        }

        public void InicializarArchivo()
        {
            // Inicializa con valores por defecto
            SDKSettings = new SDKSettings
            {
                Username = "demo@chilesystems.com",
                Password = "Rv8Il4eV",
                BaseUrl = "https://api.simplefactura.cl"
            };
            GenerarArchivo();
        }
    }
}