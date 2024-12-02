using Newtonsoft.Json;
using SimpleFacturaSDK_Demo.Models;
using System.IO;

public class AppSettings
{
    private static AppSettings _current;

    public SDKSettings SDKSettings { get; set; }
    public Credenciales Credenciales { get; set; } = new Credenciales // Valores predeterminados
    {
        EmailUsuario = "default@correo.com",
        RutEmisor = "11111111-1",
        RutContribuyente = "22222222-2",
        NombreSucursal = "Sucursal Principal"
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

        if (settings.Credenciales == null)
        {
            settings.Credenciales = new Credenciales
            {
                EmailUsuario = "default@correo.com",
                RutEmisor = "11111111-1",
                RutContribuyente = "22222222-2",
                NombreSucursal = "Sucursal Principal"
            };
        }

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
