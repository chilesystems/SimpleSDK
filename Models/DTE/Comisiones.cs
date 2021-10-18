using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class Comisiones
    {
        /// <summary>
        /// Valor neto comisiones y otros cargos.
        /// Suma de detalle de Valores de Comisiones y Otros Cargos 
        /// </summary>
        [XmlElement("ValComNeto")]
        public int ValorNeto { get; set; }
        public bool ShouldSerializeValorNeto() { return ValorNeto != 0; }

        /// <summary>
        /// Valor comisión y otros cargos no afectos o exentos.
        /// Suma de detalles de valores de comisiones y otros cargos no afectos o exentos.
        /// </summary>
        [XmlElement("ValComExe")]
        public int ValorExento { get; set; }
        public bool ShouldSerializeValorExento() { return ValorExento != 0; }

        /// <summary>
        /// Valor IVA comisiones y otros cargos
        /// Suma de detalle de IVA de Valor de Comisiones y Otros Cargos.
        /// </summary>
        [XmlElement("ValComIVA")]
        public int ValorIVA { get; set; }
        public bool ShouldSerializeValorIVA() { return ValorIVA != 0; }

        public Comisiones()
        {
            ValorNeto = 0;
            ValorExento = 0;
            ValorIVA = 0;
        }
    }
}
