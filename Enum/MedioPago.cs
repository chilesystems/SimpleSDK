namespace SimpleSDK.Enum
{
    public class MedioPago
    {
        /// <summary>
        /// Indica las modalidades de pago posibles
        /// </summary>
        public enum MedioPagoEnum
        {
            /// <summary>
            /// No se ha definido un valor aún.
            /// </summary>
            NotSet,
            /// <summary>
            /// Cheque
            /// </summary>
            CH, 
            /// <summary>
            /// Cheque a fecha
            /// </summary>
            CF, 
            /// <summary>
            /// Letra
            /// </summary>
            LT, 
            /// <summary>
            /// Efectivo
            /// </summary>
            EF,
            /// <summary>
            /// Pago a cuenta corriente
            /// </summary>
            PE,
            /// <summary>
            /// Tarjeta de credito
            /// </summary>
            TC,
            /// <summary>
            /// Otro
            /// </summary>
            OT
        }
    }
}
