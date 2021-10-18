using System;

namespace SimpleSDK.Models.LCV
{
    public class DocumentoCAL
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// RUT del distribuidor.
        /// </summary>
        public string RutDistribuidor { get; set; }

        /// <summary>
        /// Tipo de Certificado.
        /// C = Certificación.
        /// P = Producción.
        /// </summary>
        public Enum.TipoCertificado.TipoCertificadoEnum TipoCertificado { get; set; }

        public Enum.ClaseCAL.ClaseCALEnum Clase { get; set; }

        /// <summary>
        /// Tipo de Libro Contable
        /// </summary>
        public Enum.TipoLCE.TipoLCEEnum TipoLCE { get; set; }

        /// <summary>
        /// Fecha de emisión del CAL. (AAAA-MM-DD)
        /// </summary>
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// En caso que Clase = 3; corresponde al año en que es válido hacer envíos con este CAL, de lo contrario es año de inicio para realizar envíos. (Formato AAAA)
        /// </summary>
        public int Año { get; set; }

        /// <summary>
        /// TimeStamp de generación del firma.
        /// </summary>
        public DateTime FechaFirma { get; set; }
    }
}