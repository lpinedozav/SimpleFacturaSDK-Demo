using Newtonsoft.Json;
using SDKSimpleFactura.Models.Facturacion;
using SimpleFacturaSDK_Demo.Models;
using System.IO;
using System.Collections.Generic;
using Credenciales = SDKSimpleFactura.Models.Facturacion.Credenciales;


public class AppSettings
{
    private static AppSettings _current;

    public SDKSettings SDKSettings { get; set; }
    [JsonIgnore]
    public Credenciales Credenciales { get; set; } = new Credenciales
    {
        EmailUsuario = "test@correo.com",
        RutEmisor = "76269769-6",
        RutContribuyente = "76269769-6",
        NombreSucursal = "Casa Matriz"
    };
    [JsonIgnore]
    public Emisor emisor { get; set; } = new Emisor
    {
        RUTEmisor = "76269769-6",
        RznSoc = "Chilesystems",
        GiroEmis = "Desarrollo de software",
        Telefono = new List<string> { "912345678" },
        CorreoEmisor = "mvega@chilesystems.com",
        Acteco = new List<int>{620200},
        DirOrigen = "Calle 7 numero 3",
        CmnaOrigen = "Santiago",
        CiudadOrigen = "Santiago"
    };

    public static AppSettings Current
    {
        get
        {
            if (_current == null)
                _current = Load();
            return _current;
        }
    }

    private AppSettings() { }

    private static AppSettings Load()
    {
        if (!File.Exists("appsettings.json"))
        {
            return new AppSettings
            {
                SDKSettings = new SDKSettings
                {
                    Username = "demo@chilesystems.com",
                    Password = "Rv8Il4eV",
                    BaseUrl = "https://api.simplefactura.cl"
                }
            };
        }

        var json = File.ReadAllText("appsettings.json");
        var settings = JsonConvert.DeserializeObject<AppSettings>(json);
        return settings;
    }

    public void Save()
    {
        // Clonar el objeto actual, excluyendo las credenciales adicionales (no guardadas)
        var settingsToSave = new AppSettings
        {
            SDKSettings = this.SDKSettings // Solo guardar la configuración del SDK
        };

        // Serializar y escribir en el archivo appsettings.json
        var json = JsonConvert.SerializeObject(settingsToSave, Formatting.Indented);
        File.WriteAllText("appsettings.json", json);
    }
}
