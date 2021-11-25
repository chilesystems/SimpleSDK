using System.Xml.Serialization;

namespace SimpleSDK.Models.RCOF
{
    public class RangoAnulados
    {
        /// <summary>
        /// Número de folio inicial de rango de folios anulados. O folio individual anulado si no se trata de un rango(Inicial – Final).
        /// </summary>
        public int Inicial { get; set; }

        /// <summary>
        /// úmero de folio final de rango de folios anulados. Puede omitirse cuando se reporta folio individual
        /// /// </summary>
        public int Final { get; set; }

    }
}
