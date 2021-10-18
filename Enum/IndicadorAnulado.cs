using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class IndicadorAnulado
    {
        public enum IndicadorAnuladoEnum : int
        {
            /// <summary>
            /// No se ha establecido un valor áun.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// El estado del documento es ANULADO
            /// </summary>
            [XmlEnum("A")]
            Anulado = 1,

            /// <summary>
            /// Anulado Previo a su Envio al SII. Sólo para Guias de Despacho Electrónicas
            /// </summary>
            [XmlEnum("1")]
            AnuladoPrevio = 1,

            /// <summary>
            /// Anulado Posterior a su Envio al SII. Sólo para Guias de Despacho Electrónicas
            /// </summary>
            [XmlEnum("2")]
            AnuladoPosterior = 2,

            /// <summary>
            /// Productos recibidos parcialmente. Sólo para Guias de Despacho Electrónicas
            /// </summary>
            [XmlEnum("3")]
            RecibidoParcialmente = 3
        }
    }
}