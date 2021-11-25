using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.RCOF
{
    public class Resumen
    {
        /// <summary>
        /// Indica que el documento informado es: 
        /// 39: Boleta Electrónica.
        /// 41: Boleta No Afecta Exenta Electrónica
        /// </summary>
        public Enum.TipoDTE.DTEType TipoDocumento { get; set; }

        /// <summary>
        /// Total Monto Neto (Afecto) de documentos emitidos informados. 
        /// En caso de Boletas Electrónicas en que la cantidad de documentos emitidos sea mayor que 0, debe contener valor
        /// mayor o igual a 0. En el caso de Boletas No Afectas o Exentas Electrónicas debe ser cero.
        /// </summary>
        public int MntNeto { get; set; }
        /// <summary>
        /// Total IVA de documentos emitidos informados. En caso de Boletas Electrónicas en que la cantidad de documentos emitidos
        /// sea mayor que 0, debe contener valor mayor o igual a 0 e igual a Monto Neto* Tasa IVA.
        /// En el caso de Boletas No Afectas o Exentas Electrónicas debería ser cero
        /// </summary>
        public int MntIva { get; set; }
        public double TasaIVA { get; set; }
        /// <summary>
        /// Total Monto No Afecto o Exento de documentos emitidos informados.
        /// En el caso de Boletas No Afectas Exentas Electrónicas en que la cantidad de documentos emitidos en el día
        /// sea mayor que 0, debe contener valor mayor o igual a 0.
        /// </summary>
        public int MntExento { get; set; }
        /// <summary>
        /// Suma de totales (neto, IVA y no afecto) para cada tipo de documento
        /// </summary>
        public int MntTotal { get { return MntNeto + MntIva + MntExento; } }
        /// <summary>
        /// Cantidad de Documentos del tipo correspondiente a emitidos. Se 
        /// debe indicar la cantidad total de documentos emitidos en el
        /// período.Si no hay documentos emitidos del tipo especificado, en
        /// el período indicado en la carátula, se debe registrar 0.
        /// </summary>
        public int FoliosEmitidos { get; set; }
        /// <summary>
        /// En este campo indicar Cantidad de Folios de documentos del tipo 
        /// correspondiente anulados. Se refiere a los folios anulados en el
        /// sistema que no corresponden a documentos enviados al SII
        /// (Opción anulación de folios) y no a Documentos anulados
        /// mediante Notas de Crédito Electrónicas
        /// </summary>
        public int FoliosAnulados { get; set; }
        /// <summary>
        /// Cantidad de Documentos del tipo correspondiente a emitidos y 
        /// anulados.Si no informa folios anulados, se repite cantidad de
        /// documentos emitidos.
        /// </summary>
        public int FoliosUtilizados { get { return FoliosAnulados + FoliosEmitidos; } }
        /// <summary>
        /// Lista que contiene un rango de folios CONSECUTIVOS utilizados 
        /// (Hasta 5.000 posibles registros). La suma total de los folios
        /// utilizados debe ser igual a “Cantidad de documentos utilizados en el periodo”.
        /// </summary>
        public List<RangoUtilizados> RangoUtilizados { get; set; }
        /// <summary>
        /// Lista que contiene los folios CONSECUTIVOS anulados (Hasta 5.000 posibles registros). 
        /// La suma total de los folios anulados debe ser igual a la “Cantidad de Folios anulados en el período”
        /// </summary>
        public List<RangoAnulados> RangoAnulados { get; set; }

        public Resumen()
        {
            RangoAnulados = new List<RangoAnulados>();
            RangoUtilizados = new List<RangoUtilizados>();
        }
    }
}
