using System;
using System.Xml.Serialization;

namespace SimpleSDK.Models.Cesion
{
    public class Cesion
    {
        public string ID { get; set; }
        /// <summary>
        /// Secuencia de la cesión. Puede ser desde 1 hasta 40
        /// </summary>
        public int Secuencia { get; set; }
        public IdDTE IdentificacionDTE { get; set; }
        public Cedente Cedente { get; set; }
        public Cesionario Cesionario { get; set; }

        /// <summary>
        /// Monto del crédito cedido
        /// </summary>
        public int MontoCesion { get; set; }
        /// <summary>
        /// Fecha de último vencimiento
        /// </summary>
        public DateTime UltimoVencimiento { get; set; }
        public string OtrasCondiciones { get; set; }
        /// <summary>
        /// Correo electrónico del deudor del DTE
        /// </summary>
        public string eMailDeudor { get; set; }

        public Cesion()
        {
            IdentificacionDTE = new IdDTE();
            Cedente = new Cedente();
            Cesionario = new Cesionario();
        }
    }
}
