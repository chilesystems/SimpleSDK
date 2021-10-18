using System;
using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public static class EstadoEnvioEmpresa
    {
        public enum EstadoEnvioEmpresaEnum : int
        {
            /// <summary>
            /// 0: Envío recibido conforme.
            /// </summary>
            [XmlEnum("0")]
            OK = 0,
            /// <summary>
            /// 1: Envío rechazado - Error de Schema. 
            /// </summary>
            [XmlEnum("1")]
            ErrorSchema = 1,
            /// <summary>
            /// 2: Envío rechazado - Error de firma.
            /// </summary>
            [XmlEnum("2")]
            ErrorFirma =2,
            /// <summary>
            /// 3: Envío rechazado - Rut receptor no corresponde.
            /// </summary>
            [XmlEnum("3")]
            RUTReceptorNoCorresponde = 3,
            /// <summary>
            /// 90: Envío rechazado - Archivo repetido
            /// </summary>
            [XmlEnum("90")]
            ArchivoRepetido = 90,
            /// <summary>
            /// 91: Envío rechazado - Archivo ilegible.
            /// </summary>
            [XmlEnum("91")]
            ArchivoIlegible = 91,
            /// <summary>
            /// 99: Envío rechazado - Otra razón.
            /// </summary>
            [XmlEnum("99")]
            RechazoOtraRazon = 99
        }

        /// <summary>
        /// Se usa para glosa en caso de 99: Envío rechazado - Otra razón.
        /// </summary>
        public static string MotivoRechazo { get; set; }

        public static string Glosa(Enum.EstadoEnvioEmpresa.EstadoEnvioEmpresaEnum state)
        {
            switch(state)
            {
                case EstadoEnvioEmpresaEnum.OK:
                    return "Envío recibido conforme.";
                case EstadoEnvioEmpresaEnum.ErrorSchema:
                    return "Envío rechazado - Error de Schema. ";
                case EstadoEnvioEmpresaEnum.ErrorFirma:
                    return "Envío rechazado - Error de firma.";
                case EstadoEnvioEmpresaEnum.RUTReceptorNoCorresponde:
                    return "Envío rechazado - Rut receptor no corresponde.";
                case EstadoEnvioEmpresaEnum.ArchivoRepetido:
                    return "Envío rechazado - Archivo repetido";
                case EstadoEnvioEmpresaEnum.ArchivoIlegible:
                    return "Envío rechazado - Archivo ilegible.";
                case EstadoEnvioEmpresaEnum.RechazoOtraRazon:
                    return "Envío rechazado - Otra razón: " + MotivoRechazo;                
                default:
                    throw new Exception("Invalid state.");
            }
        }
    }
}
