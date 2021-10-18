using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public enum IndicadorFacturacionExencionEnum : int
    {
        /// <summary>
        /// Aún no se ha definido un valor.
        /// </summary>
        [XmlEnum("")]
        NotSet = 0,
        /// <summary>
        /// No afecto o exento de IVA.
        /// No se usa este campo si la factura es exenta en forma global.
        /// </summary>
        [XmlEnum("1")]
        NoAfectoOExento = 1,
        /// <summary>
        /// Producto o servicio no es facturable.
        /// </summary>
        [XmlEnum("2")]
        ProductoOServicioNoFacturable = 2,
        /// <summary>
        /// Garantía de depósito por envases.
        /// (Cervezas, jugos, aguas minerales, bebidas analcohólicas u otros autorizados por resolución especial).
        /// </summary>
        [XmlEnum("3")]
        GarantiaDeposito = 3,
        /// <summary>
        /// Item no venta.
        /// Para facturas y guías de despacho (esta última con indicador de tipo de traslado de buenes = 1) y este item no será facturado.
        /// </summary>
        [XmlEnum("4")]
        ItemNoVenta = 4,
        /// <summary>
        /// Item a rebajar. Para guías de despacho NO VENTA que rebajan guía anterior.
        /// En el área de referencias se debe indicar la guía anterior.
        /// </summary>
        [XmlEnum("5")]
        ItemARebajar = 5,
        /// <summary>
        /// Producto o servicio no facturable negativo (exepto en liquidaciones-factura).
        /// </summary>
        [XmlEnum("6")]
        ProductoOServicioNoFacturableNegativo = 6
    }
}
