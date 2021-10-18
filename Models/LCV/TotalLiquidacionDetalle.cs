namespace SimpleSDK.Models.LCV
{
    public class TotalLiquidacionDetalle
    {
        /// <summary>
        /// Rut Emisor (LV).
        /// </summary>
        public string RutEmisor { get; set; }

        /// <summary>
        /// Valor neto comisiones y otros cargos (LV).
        /// </summary>
        public int NetoComisionesYOtrosCargos { get; set; }

        /// <summary>
        /// Valor comisiones y otros cargos no afectos o exentos (LV).
        /// </summary>
        public int ExentoComisionesYOtrosCargos { get; set; }

        /// <summary>
        /// Valor IVA comisiones y otros cargos (LV).
        /// </summary>
        public int IVAComisionesYOtrosCargos { get; set; }
    }
}