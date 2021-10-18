using System;

namespace SimpleSDK.Models.Envios
{
    public class Caratula
    {
        /// <summary>
        /// Rut emisor de los DTE.
        /// </summary>
        public string RutEmisor { get; set; }

        /// <summary>
        /// Rut al que se le envían los DTE. Si es al SII, debe ir "60803000-K". Si es al cliente, el rut del cliente
        /// </summary>
        public string RutReceptor { get; set; }
        
        /// <summary>
        /// Fecha de resolución que autoriza el envío del DTE. (AAAA-MM-DD).
        /// </summary>
        public DateTime FechaResolucion { get; set; }
        
        /// <summary>
        /// Número de resolución que autoriza el envío del DTE.
        /// </summary>
        public int NumeroResolucion { get; set; }
        

        public Caratula()
        {
        }
    }
}
