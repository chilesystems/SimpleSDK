using System;

namespace SimpleSDK.Models.Cesion
{
    public class Caratula
    {
        /// <summary>
        /// Corresponde al RUT del Cedente
        /// </summary>
        public string RutCedente { get; set; }
        /// <summary>
        /// RUT a quien va dirigido el Archivo de Cesión
        /// </summary>
        public string RutCesionario { get; set; }

        /// <summary>
        /// Persona de Contacto para aclarar dudas
        /// </summary>
        public string NombreContacto { get; set; }

        /// <summary>
        /// Teléfono de contacto
        /// </summary>
        public string FonoContacto { get; set; }

        /// <summary>
        /// Correo Electrónico de Contacto
        /// </summary>
        public string MailContacto { get; set; }

        public Caratula()
        {
        }
    }
}
