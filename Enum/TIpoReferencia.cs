using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoReferencia
    {
        public enum TipoReferenciaEnum : int
        {
            /// <summary>
            /// No se ha definido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            
            /// <summary>
            /// Anula documento de referencia.
            /// </summary>
            [XmlEnum("1")]
            AnulaDocumentoReferencia = 1,
            
            /// <summary>
            /// Corrige texto de documento de referencia.
            /// </summary>
            [XmlEnum("2")]
            CorrigeTextoDocumentoReferencia = 2,
            
            /// <summary>
            /// Corrige montos de documento de referencia.
            /// </summary>
            [XmlEnum("3")]
            CorrigeMontos  = 3,

            /// <summary>
            /// Para Set de Pruebas
            /// </summary>
            [XmlEnum("SET")]
            SetPruebas = 4
        }

        public enum TipoReferenciaEnum_test
        {
            /// <summary>
            /// No se ha definido un valor aún.
            /// </summary>
            [XmlEnum("SET")]
            NotSet = '0',

            /// <summary>
            /// Anula documento de referencia.
            /// </summary>
            [XmlEnum("1")]
            AnulaDocumentoReferencia = 1,

            /// <summary>
            /// Corrige texto de documento de referencia.
            /// </summary>
            [XmlEnum("2")]
            CorrigeTextoDocumentoReferencia = 2,

            /// <summary>
            /// Corrige montos de documento de referencia.
            /// </summary>
            [XmlEnum("3")]
            CorrigeMontos = 3
        }
    }
}
