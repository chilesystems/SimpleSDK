using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class Retenedor
    {
        /// <summary>
        /// Indicador agente retenedor.
        /// Obligatorio para agentes retenedores, indica para cada transacción si es agente retenedor del producto que está vendiendo. 
        /// </summary>
        [XmlElement("IndAgente")]
        public string IndicadorAgente { get; set; }

        /// <summary>
        /// Monto base faenamiento.
        /// Sólo para transacciones realizadas por Agentes Retenedores, según códigos de retención 17.
        /// </summary>
        [XmlElement("MntBaseFaena")]
        public int MontoBaseFaenamiento { get; set; }

        /// <summary>
        /// Márgenes de comercialización.
        /// Sólo para transacciones realizadas por Agentes Retenedores, según códigos de retención 14 y 50.
        /// </summary>
        [XmlElement("MntMargComer")]
        public int MontoMargenComercializacion { get; set; }

        /// <summary>
        /// Precio unitario neto consumidor final.
        /// Sólo para transacciones realizadas por Agentes Retenedores, según códigos de retención 14, 17 y 50.
        /// </summary>
        [XmlElement("PrcConsFinal")]
        public int PrecioConsumidorFinal { get; set; }

        public Retenedor()
        {
            IndicadorAgente = string.Empty;
            MontoBaseFaenamiento = 0;
            MontoMargenComercializacion = 0;
            PrecioConsumidorFinal = 0;
        }
    }
}
