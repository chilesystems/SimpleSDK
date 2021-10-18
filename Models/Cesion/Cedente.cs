using System.Collections.Generic;

namespace SimpleSDK.Models.Cesion
{
    public class Cedente
    {
        public string RUT { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string eMail { get; set; }

        /// <summary>
        /// Lista de personas que firman la última cesión. Estos son autorizadas por el 
        /// cedente a firmar la cesión
        /// </summary>
        public List<RUTAutorizado> RUTsAutorizados { get; set; }
    }
}
