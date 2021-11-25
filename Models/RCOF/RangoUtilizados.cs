using System.Xml.Serialization;

namespace SimpleSDK.Models.RCOF
{
    public class RangoUtilizados
    {
        /// <summary>
        /// Número de folio inicial del rango de folios utilizados en el período. 
        /// Debe ser mayor que el “folio utilizado final” del rango precedente.
        /// </summary>
        public long Inicial { get; set; }

        /// <summary>
        /// Número de folio final del rango de folios utilizados en el período. 
        /// Debe ser mayor que “Folio Utilizado Inicial” 
        /// </summary>
        public long Final { get; set; }
    }
}
