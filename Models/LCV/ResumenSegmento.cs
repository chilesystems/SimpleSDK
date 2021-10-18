using System.Collections.Generic;

namespace SimpleSDK.Models.LCV
{
    public class ResumenSegmento
    {
        /// <summary>
        /// En este resumen se deben entregar totalizados los montos por campo de cada tipo de documento, para los documentos incluidos en el detalle.
        /// Todos los montos pueden ser negativos así como también el campo “cantidad de documentos” que puede ser negativo en un envío de ajuste.
        /// 1 - 40 repeticiones.
        /// </summary>
        public List<TotalSegmento> TotalesSegmento { get; set; }

        /// <summary>
        /// Total Guias Anuladas (Anulado = 2). Dato opcional.
        /// </summary>
        public int TotalesGuiasAnuladas { get; set; }

        /// <summary>
        /// Total Folios Anulados (Anulado = 1). Dato opcional.
        /// </summary>
        public int TotalesFoliosAnulados { get; set; }

        /// <summary>
        /// Total de Guias Venta. Dato obligatorio. Cantidad de Guías en que el campo ANULADO/MODIFICADO
        /// distinto de 1 y 2 y el campo TIPO DE OPERACIÓN = 1 (que constituye venta)
        /// </summary>
        public int TotalesGuiasDeVentas { get; set; }

        /// <summary>
        /// Monto Total de Guias de Venta. Dato obligatorio. Suma del Monto Total de Guías Venta.
        /// </summary>
        public int MontoTotalVentasGuia { get; set; }

        /// <summary>
        /// Indica la cantidad y el Monto Total de los distintos tipos de Guías no Venta.
        /// Se repite hasta 6 veces, según los distintos códigos no  venta.
        /// </summary>
        public List<TotalTraslado> Traslados { get; set; }


        public ResumenSegmento()
        {
            TotalesSegmento = new List<TotalSegmento>();
            Traslados = new List<TotalTraslado>();
        }
    }
}