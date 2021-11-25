using System;

namespace SimpleSDK.Models.RCOF
{
    public class Caratula
    {
        /// <summary>
        /// Corresponde al Rut del contribuyente emisor con guion y dígito verificador
        /// </summary>
        public string RutEmisor { get; set; }
        /// <summary>
        /// Corresponde al Rut del usuario autorizado por el contribuyente que hace el envío al SII
        /// </summary>
        public string RutEnvia { get; set; }
        /// <summary>
        /// Número de Resolución que autoriza al contribuyente como emisor de DTE.
        /// </summary>
        public int NroResol { get; set; }
        /// <summary>
        /// Secuencia de Envío. La primera vez que se envía debe traer el número 1. 
        /// Si se desea corregir información se debe enviar el archivo completo, 
        /// pero "SecEnvio", debe aumentar en 1, es decir la segunda vez debe traer el valor 2, la tercera vez debe traer el valor 3, etc.
        /// </summary>
        public string SecEnvio { get; set; }
        public DateTime FechaEnvio { get; set; }
        /// <summary>
        /// Fecha de Resolución que autoriza al contribuyente a emitir DTE.
        /// </summary>
        public DateTime FechaResolucion { get; set; }
        /// <summary>
        /// Fecha del primer día a que corresponde el Resumen
        /// </summary>
        public DateTime FechaInicio { get; set; }
        /// <summary>
        /// Fecha del último día a que corresponde el Resumen
        /// </summary>
        public DateTime FechaFinal { get; set; }

        public Caratula()
        {
        }
    }
}
