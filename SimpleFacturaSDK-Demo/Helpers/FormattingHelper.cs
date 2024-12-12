namespace SimpleFacturaSDK_Demo.Helpers
{
    public static class FormattingHelper
    {
        /// <summary>
        /// Formatea un precio con separadores de miles y sin decimales.
        /// </summary>
        /// <param name="precio">El precio a formatear.</param>
        /// <returns>El precio formateado como string.</returns>
        public static string FormatearPrecio(decimal precio)
        {
            // Formato con coma como separador de miles, sin decimales
            return precio.ToString("#,##0", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
