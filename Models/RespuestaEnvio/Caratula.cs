namespace SimpleSDK.Models.RespuestaEnvio
{
    public class Caratula
    {        
        public string RutResponde { get; set; }

        /// <summary>
        /// RUT al que se le envia la respuesta (RUT emisor de los DTE).
        /// </summary>
        public string RutRecibe { get; set; }

        /// <summary>
        /// Número único de identificación de la respuesta.
        /// </summary>
        public int IdRespuesta { get; set; }

        /// <summary>
        /// Número de envíos en sección de recepción o número de DTE en sección de resultados.
        /// </summary>
        public int NumeroDetalles { get; set; }
        /// <summary>
        /// Persona de contacto para aclarar dudas.
        /// </summary>
        public string NombreContacto { get; set; }

        /// <summary>
        /// Teléfono de contacto.
        /// </summary>
        public string FonoContacto { get; set; }

        /// <summary>
        /// Correo electrónico de contacto.
        /// </summary>
        public string MailContacto { get; set; }
    }
}
