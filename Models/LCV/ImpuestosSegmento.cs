namespace SimpleSDK.Models.LCV
{
    /// <summary>
    /// Hasta 20 repeticiones.
    /// </summary>
    public class ImpuestosSegmento
    {
        /// <summary>
        /// Codigo del otro impuesto.
        /// </summary>
        public Enum.TipoImpuesto.TipoImpuestoEnum CodigoImpuesto { get; set; }

        /// <summary>
        /// Monto del otro impuesto
        /// </summary>
        public int TotalMontoImpuesto { get; set; }
    }
}