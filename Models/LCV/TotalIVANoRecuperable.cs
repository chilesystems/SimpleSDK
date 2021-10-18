namespace SimpleSDK.Models.LCV
{
    /// <summary>
    /// Hasta 5 repeticiones.
    /// </summary>
    public class TotalIVANoRecuperable
    {
        /// <summary>
        /// Código de IVA No Recuperable
        /// </summary>
        public Enum.CodigoIVANoRecuperable .CodigoIVANoRecuperableEnum CodigoIVANoRecuperable { get; set; }

        /// <summary>
        /// Número de operaciones con IVA No Recuperable
        /// </summary>
        public int CantidadOperacionesIVANoRecuperable { get; set; }

        /// <summary>
        /// Total de IVA No Recuperable.
        /// </summary>
        public int TotalMontoIVANoRecuperable { get; set; }
    }
}