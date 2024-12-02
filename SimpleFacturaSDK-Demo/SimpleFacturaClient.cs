using SDKSimpleFactura;

namespace SimpleFacturaSDK_Demo
{
    public class SimpleClientSingleton
    {
        private static SimpleFacturaClient _instance;
        private static readonly object _lock = new object();

        public static SimpleFacturaClient Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        // Leer configuración desde el appsettings.json
                        var settings = AppSettings.Load();
                        _instance = new SimpleFacturaClient(); // El SDK usará automáticamente appsettings.json
                    }
                    return _instance;
                }
            }
        }
    }

}
