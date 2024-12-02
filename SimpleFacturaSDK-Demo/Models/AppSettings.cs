using Newtonsoft.Json;
using SimpleFacturaSDK_Demo.Models;
using System.IO;

public class AppSettings
{
    public SDKSettings SDKSettings { get; set; }

    public static AppSettings Load()
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
        return JsonConvert.DeserializeObject<AppSettings>(json);
    }

    public void Save()
    {
        var json = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText("appsettings.json", json);
    }
}
