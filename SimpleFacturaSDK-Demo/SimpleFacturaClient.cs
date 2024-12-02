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
                        // El SDK leerá automáticamente las variables de entorno establecidas
                        _instance = new SimpleFacturaClient();
                    }
                    return _instance;
                }
            }
        }
    }

}
