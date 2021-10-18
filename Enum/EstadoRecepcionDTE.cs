using System;
using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public static class EstadoRecepcionDTE
    {
        public enum EstadoRecepcionDTEEnum : int
        {
            /// <summary>
            /// 0: DTE Recibido OK.
            /// </summary>
            [XmlEnum("0")]
            Ok = 0,
            /// <summary>
            /// 1: DTE No Recibido - Error de firma.
            /// </summary>
            [XmlEnum("1")]
            ErrorFirma = 1,
            /// <summary>
            /// 2: DTE No Recibido - Error en RUT Emisor.
            /// </summary>
            [XmlEnum("2")]
            ErrorRutEmisor = 2,
            /// <summary>
            /// 3: DTE No Recibido - Error en RUT Receptor.
            /// </summary>
            [XmlEnum("3")]
            ErrorRutReceptor = 3,
            /// <summary>
            /// 4: DTE No Recibido - DTE Repetido.
            /// </summary>
            [XmlEnum("4")]
            Repetido = 4,
            /// <summary>
            /// 5: DTE No Recibido - Otra.
            /// </summary>
            [XmlEnum("99")]
            Otra = 99
        }

        public static string Motivo { get; set; }

        public static string Glosa(EstadoRecepcionDTEEnum state)
        {
            switch(state)
            {
                case EstadoRecepcionDTEEnum.Ok:
                    return "DTE Recibido OK.";
                case EstadoRecepcionDTEEnum.ErrorFirma:
                    return "DTE No Recibido - Error de firma.";
                case EstadoRecepcionDTEEnum.ErrorRutEmisor:
                    return "DTE No Recibido - Error en RUT Emisor.";
                case EstadoRecepcionDTEEnum.ErrorRutReceptor:
                    return "DTE No Recibido - Error en RUT Receptor.";
                case EstadoRecepcionDTEEnum.Repetido:
                    return "DTE No Recibido - DTE Repetido.";
                case EstadoRecepcionDTEEnum.Otra:
                    return "DTE No Recibido - Otra.";
                default:
                    throw new Exception("Invalid state.");
            }
        }
    }
}
