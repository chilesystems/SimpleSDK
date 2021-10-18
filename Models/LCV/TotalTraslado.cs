namespace SimpleSDK.Models.LCV
{
    public class TotalTraslado
    {

        /// <summary>
        /// Indicador de Tipo de Traslado. 
        /// 1. Operación constituye venta
        /// 2. Venta por efectuar
        /// 3. Consignaciones
        /// 4. Productos en Demostración
        /// 5. Traslados Internos
        /// 6. Otros Traslados No Venta
        /// </summary>
        public Enum.TipoTraslado.TipoTrasladoEnum TipoTraslado { get; set; }

        /// <summary>
        /// Cantidad de Guias del Período
        /// </summary>
        public int CantidadGuia { get; set; }

        /// <summary>
        /// Monto de Guias del Período. Indicar Monto, en caso que se hayan valorizado 
        /// </summary>

        public int MontoGuia { get; set; }
    }
}