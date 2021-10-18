using System.Xml.Serialization;

namespace SimpleSDK.Models.LCV
{
    /// <summary>
    /// Hasta 20 repeticiones.
    /// </summary>
    public class ImpuestosPeriodo
    {
        /// <summary>
        /// Codigo del otro impuesto.
        /// Según lo informado en detalle.
        /// </summary>
        public Enum.TipoImpuesto.TipoImpuestoEnum CodigoImpuesto { get; set; }

        /// <summary>
        /// Monto total del otro impuesto.
        /// Totaliza los valores correspondiente al código por tipo de documento del detalle.
        /// </summary>
        public int TotalMontoImpuesto { get; set; }

        /// <summary>
        /// Factor impuesto adicional (LC)
        /// </summary>
        public double FactorImpuestoAdicional { get; set; }

        /// <summary>
        /// Total crédito impuesto (LC)
        /// </summary>
        public int TotalCreditoImpuesto { get; set; }
    }
}