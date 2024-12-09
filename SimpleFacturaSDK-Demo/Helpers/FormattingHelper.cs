namespace SimpleFacturaSDK_Demo.Helpers
{
    public static class FormattingHelper
    {
        /// <summary>
        /// Formatea un precio con separadores de miles y dos decimales.
        /// </summary>
        /// <param name="precio">El precio a formatear.</param>
        /// <returns>El precio formateado como string.</returns>
        public static string FormatearPrecio(decimal precio)
        {
            return precio.ToString("N2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }

}
