namespace SimpleSDK.Models.LCV
{
    public class ImpuestosDetalle
    {
        /// <summary>
        /// Codigo del otro impuesto.
        /// </summary>
        public Enum.TipoImpuesto.TipoImpuestoEnum CodigoImpuesto { get; set; }

        /// <summary>
        /// Tasa del impuesto o recargo.
        /// </summary>
        public double TasaImpuesto { get; set; }

        /// <summary>
        /// Monto del otro impuesto
        /// </summary>
        public int TotalMontoImpuesto { get; set; }
    }
}