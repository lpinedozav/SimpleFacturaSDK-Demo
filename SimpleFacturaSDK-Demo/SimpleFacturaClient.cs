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
        public static void ResetClient()
        {
            lock (_lock)
            {
                _instance = new SimpleFacturaClient(); // Crear una nueva instancia con las credenciales actualizadas
            }
        }
    }

}
