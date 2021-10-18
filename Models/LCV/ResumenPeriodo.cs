using System.Collections.Generic;

namespace SimpleSDK.Models.LCV
{
    public class ResumenPeriodo
    {
        /// <summary>
        /// En este resumen se deben entregar totalizados los montos por campo de cada tipo de documento de todo el período. 
        /// También es obligatorio en el caso de efectuar ajustes posteriores al cierre del período.        
        /// 1 a 40 repeticiones.
        /// </summary>
        public List<TotalPeriodo> TotalesPeriodo { get; set; }

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


        public ResumenPeriodo()
        {
            TotalesPeriodo = new List<TotalPeriodo>();
            Traslados = new List<TotalTraslado>();
        }
    }
}