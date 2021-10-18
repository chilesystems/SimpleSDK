using System;
using System.Collections.Generic;

namespace SimpleSDK.Models.RespuestaEnvio
{
    public class RecepcionEnvio
    {
        /// <summary>
        /// Nombre del archivo de envío.
        /// </summary>
        public string NombreArchivoEnvio { get; set; }

        /// <summary>
        /// Fecha y hora de rececpcion del envío.
        /// </summary>
        public DateTime FechaRecepcion { get; set; }

        /// <summary>
        /// Número único (Generado por el receptor) para identificar el envío.
        /// </summary>
        public int CodigoEnvio { get; set; }

        /// <summary>
        /// Valor del atributo ID del tag &lt;EnvioDTE&gt; del envío.
        /// </summary>
        public string EnvioDTEId { get; set; }

        /// <summary>
        /// Campo DigestValue de la firma digital del envío.
        /// </summary>
        public string Digest { get; set; }

        /// <summary>
        /// RUT del emisor informado en la carátula del envío.
        /// </summary>
        public string RutEmisor { get; set; }

        /// <summary>
        /// RUT del receptor informado en la carátula del envío.
        /// </summary>
        public string RutReceptor { get; set; }

        /// <summary>
        /// Estado de recepción del envío.
        /// </summary>
        public Enum.EstadoEnvioEmpresa.EstadoEnvioEmpresaEnum EstadoRecepcionEnvio { get; set; }

        /// <summary>
        /// Número de documentos incluidos en el envio que se informan como recibidos/no recibidos.
        /// </summary>
        public int NumeroDTE { get; set; }

        /// <summary>
        /// Resultados de recepción de los documentos incluidos en el envío.
        /// </summary>
        public List<RecepcionDTE> RecepcionDTE { get; set; }
    }
}
