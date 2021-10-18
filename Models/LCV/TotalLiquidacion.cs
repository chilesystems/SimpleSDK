namespace SimpleSDK.Models.LCV
{
    public class TotalLiquidacion
    {
        /// <summary>
        /// Valor neto comisiones y otros cargos (LV).
        /// Puede ser negativo.
        /// </summary>
        public int TotalNetoComisionesYOtrosCargos { get; set; }

        /// <summary>
        /// Valor comisiones y otros cargos no afectos o exentos (LV).
        /// Puede ser negativo.
        /// </summary>
        public int TotalExentoComisionesYOtrosCargos { get; set; }

        /// <summary>
        /// Valor IVA comisiones y otros cargos (LV).
        /// Puede ser negativo.
        /// </summary>
        public int TotalIVAComisionesYOtrosCargos { get; set; }
    }
}