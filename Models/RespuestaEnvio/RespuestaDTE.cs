using System;
using System.Collections.Generic;

namespace SimpleSDK.Models.RespuestaEnvio
{
    /// <summary>
    /// Envío de respuesta a la recepción de documentos tributarios eletrónicos.
    /// </summary>
    public class RespuestaDTE
    {

        /// <summary>
        /// Información de resultado de los proceso de recepción de envíos y documentos.
        /// </summary>
        public Resultado Resultado { get; set; }
    }
}
