using System;
using System.Collections.Generic;

namespace SimpleSDK.Models.RespuestaEnvio
{
    public class Resultado
    {
        public string Id { get; set; }

        /// <summary>
        /// Información de identificación del envío de resultados.
        /// </summary>
        public Caratula Caratula { get; set; }

        /// <summary>
        /// Restultados de la recepción de envíos de documentos.
        /// </summary>
        public List<RecepcionEnvio> RecepcionEnvio { get; set; }

        /// <summary>
        /// Resultados de la aprobación comercial de documentos.
        /// </summary>
        public List<ResultadoDTE> ResultadoDTE { get; set; }
    }
}
