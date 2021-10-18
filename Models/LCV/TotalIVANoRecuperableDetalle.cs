﻿namespace SimpleSDK.Models.LCV
{
    /// <summary>
    /// Hasta 5 repeticiones.
    /// </summary>
    public class TotalIVANoRecuperableDetalle
    {
        /// <summary>
        /// Código de IVA No Recuperable
        /// </summary>
        public Enum.CodigoIVANoRecuperable.CodigoIVANoRecuperableEnum CodigoIVANoRecuperable { get; set; }

        /// <summary>
        /// Total de IVA No Recuperable.
        /// </summary>
        public int TotalMontoIVANoRecuperable { get; set; }
    }
}