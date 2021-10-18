using SimpleSDK.Helpers;
using System;

namespace SimpleSDK.Models.ReciboMercaderia
{
    public class Caratula
    {
        /// <summary>
        /// RUT que genera este Recibo (RUT Receptor del Documento)
        /// </summary>
        public string RutResponde { get; set; }

        /// <summary>
        /// RUT al que se le envian los Recibos (RUT Emisor de los Documento)
        /// </summary>
        public string RutRecibe { get; set; }
        /// <summary>
        /// Persona de Contacto para aclarar dudas
        /// </summary>
        public string NombreContacto { get; set; }
        /// <summary>
        /// Telefono de Contacto
        /// </summary>
        public string FonoContacto { get; set; }
        /// <summary>
        /// Correo Electronico de Contacto
        /// </summary>
        public string MailContacto { get; set; }

        /// <summary>
        /// Fecha y Hora de la Firma del Archivo de EnvioRecibo.
        /// (AAAA-MM-DDTHH:MM:SS
        /// </summary>
        public DateTime FechaHoraFirma { get; set; }

    }
}