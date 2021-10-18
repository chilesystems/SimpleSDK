using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoImpuesto
    {
        public enum TipoImpuestoEnum : int
        {
            /// <summary>
            /// No se ha definido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// IVA de margen de comercializacion.
            /// Para facturas de venta del contribuyente.
            /// </summary>
            [XmlEnum("14")]
            IVAMargenComercializacion = 14,
            /// <summary>
            /// IVA retenido total.
            /// Corresponiente al IVA retenido en Facturas de compra del contribuyente que genera el libro.
            /// Suma de retenciones con tasa de IVA.
            /// </summary>
            [XmlEnum("15")]
            IVARetenidoTotal = 15,
            /// <summary>
            /// IVA Retenido Parcial.
            /// </summary>
            [XmlEnum("16")]
            IVARetenidoParcial = 16,
            /// <summary>
            /// Tasa de 5%.
            /// Se registra el monto de IVA anticipado cobrado al cliente.
            /// </summary>
            [XmlEnum("17")]
            IVAAnticipadoFaenamientoCarne = 17,
            /// <summary>
            /// Tasa de 5%. 
            /// Se registra el monto de IVA anticipado cobrado al cliente.
            /// </summary>
            [XmlEnum("18")]
            IVAAnticipadoCarne = 18,
            /// <summary>
            /// Tasa de 12%. 
            /// Se registra el monto de IVA anticipado cobrado al cliente.
            /// </summary>
            [XmlEnum("19")]
            IVAAnticipadoHarina = 19,
            /// <summary>
            /// Tasa del 15%.
            /// a.- Artículos de oro, platino, margil.
            /// b.- Joyas, pierdas preciosas.
            /// c.- Pieles finas.
            /// </summary>
            [XmlEnum("23")]
            ImpuestoAdicionalArticulo37_LetrasABC = 23,
            /// <summary>
            /// DL 825/74, ART. 42, letrab b).
            /// Tasa del 31.5%.
            /// Licores, piscos, whisky, aguardiente y vinos licorosos o aromatizados.
            /// </summary>
            [XmlEnum("24")]
            Licores = 24,
            /// <summary>
            /// DL 825/74, ART. 42, letra c).
            /// Tasa del 20.5%.
            /// Vinos.
            /// </summary>
            [XmlEnum("25")]
            Vinos = 25,
            /// <summary>
            /// DL 825/74, ART. 42, letrab c).
            /// Tasa el 20.5%.
            /// Cervezas y bebidas alcohólicas.
            /// </summary>
            [XmlEnum("26")]
            Cervezas = 26,
            /// <summary>
            /// DL 825/74, ART. 42, letrab a).
            /// Tasa del 10%.
            /// Bebidas analcohólicas y minerales.
            /// </summary>
            [XmlEnum("27")]
            BebidasAnalcoholicasYMinerales = 27,
            /// <summary>
            /// DL 825/74, ART. 42, letrab a) inciso segundo.
            /// Tasa del 18%.
            /// Bebidas analcohólicas y minerales con elevado contenido de azúcares. (Según indica la ley).
            /// </summary>
            [XmlEnum("271")]
            BebidasAnalcoholicasYMineralesAltaAzucar = 271,
            /// <summary>
            /// Art 6, Ley N°18.502 y artículos 1° y 3° del Decreto Supremo N°311/86.
            /// 1.5 UTM por m3.
            /// Traspasado al comprador por compra de diesel.
            /// </summary>
            [XmlEnum("28")]
            ImpuestoEspecificoDiesel = 28,
            /// <summary>
            /// Normalmente 13% retencion.
            /// 1.- Si se retuvo el 13%, el monto retenido se registra en el IEC de retención parcial.
            /// 2.- Si se retuvo el total del IVA, por ser NDF se registra también en Retención Total.
            /// </summary>
            [XmlEnum("30")]
            IVARetenidoLegumbres = 30,
            /// <summary>
            /// Total del IVA retención.
            /// El monto retenido se registra en el IEC en retención total.
            /// </summary>
            [XmlEnum("31")]
            IVARetenidoSilvestres = 31,
            /// <summary>
            /// Normalmente 8% retención.
            /// 1.- Si se retuvo el 8%, el monto retenido se registra en el IEC de retención parcial.
            /// 2.- Si se retuvo el total del IVA, por ser NDF se registra también en Retención Total.
            /// </summary>
            [XmlEnum("32")]
            IVARetenidoGanado = 32,
            /// <summary>
            /// Normalmente 8% retención.
            /// 1.- Si se retuvo el 8%, el monto retenido se registra en el IEC de retención parcial.
            /// 2.- Si se retuvo el total del IVA, por ser NDF se registra también en Retención Total.
            /// </summary>
            [XmlEnum("33")]
            IVARetenidoMadera = 33,
            /// <summary>
            /// cuando se aplica tasa de retención total en un cambio de sujeto de retención parcial
            /// </summary>
            [XmlEnum("331")]
            IVARetenidoMaderaTotal = 331,
            /// <summary>
            /// Normalmente 11% retención.
            /// 1.- Si se retuvo el 11%, el monto retenido se registra en el IEC de retención parcial.
            /// 2.- Si se retuvo el total del IVA, por ser NDF se registra también en Retención Total.
            /// </summary>
            [XmlEnum("34")]
            IVARetenidoTrigo = 34,
            /// <summary>
            /// 4.5 a 6 UTM por m3.
            /// Artículo 6, Ley N°18.502, y artículos 1° y 3° del decreto supremo N° 311/86.
            /// No da derecho a crédito.
            /// Se cionsidera rebaja transitoria del componente variable dispuesto por la Ley 20.259.
            /// </summary>
            [XmlEnum("35")]
            ImpuestoEspecificoGasolina = 35,
            /// <summary>
            /// Normalmente 10% retención.
            /// 1.- Si se retuvo el 10%, el monto retenido se registra en el IEC de retención parcial.
            /// 2.- Si se retuvo el total del IVA, por ser NDF se registra también en Retención Total.
            /// </summary>
            [XmlEnum("36")]
            IVARetenidoArroz = 36,
            /// <summary>
            /// Normalmente 10% retención.
            /// 1.- Si se retuvo el 10%, el monto retenido se registra en el IEC de retención parcial.
            /// 2.- Si se retuvo el total del IVA, por ser NDF se registra también en Retención Total.
            /// </summary>
            [XmlEnum("37")]
            IVARetenidoHidrobiologicas = 37,
            /// <summary>
            /// Total del IVA retención.
            /// El monto retenido se registra en el IEC en retención total.
            /// </summary>
            [XmlEnum("38")]
            IVARetenidoChatarra = 38,
            /// <summary>
            /// Total del IVA retención.
            /// El monto retenido se registra en el IEC en retención total.
            /// </summary>
            [XmlEnum("39")]
            IVARetenidoPPA = 39,
            /// <summary>
            /// Se retiene todo el IVA.
            /// </summary>
            [XmlEnum("41")]
            IVARetenidoConstruccion = 41,
            /// <summary>
            /// Tasa del 15% en primera venta.
            /// a) Alfombras, tapices.
            /// b) Casas rodantes
            /// c) Caviar
            /// d) Armas de aire o gas
            /// </summary>
            [XmlEnum("44")]
            ImpuestoAdicionalArticulo37_LetrasEHIL = 44,
            /// <summary>
            /// Tasa del 50% en primera venta.
            /// a) Pirotecnia.
            /// </summary>
            [XmlEnum("45")]
            ImpuestoAdicionalArticulo37_LetrasJ = 45,
            /// <summary>
            /// Retención del 100% del IVA.
            /// </summary>
            [XmlEnum("46")]
            IVARetenidoOro = 46,
            /// <summary>
            /// Retención total.
            /// </summary>
            [XmlEnum("47")]
            IVARetenidoCartones = 47,
            /// <summary>
            /// Retención 14%.
            /// </summary>
            [XmlEnum("48")]
            IVARetenidoFrambuesas = 48,
            /// <summary>
            /// FACTURA DE COMPRA SIN RETENCIÓN (hoy utilizada sólo por Bolsa de Productos de Chile, lo cual es validado por el sistema).
            /// 0% de retención.
            /// </summary>
            [XmlEnum("49")]
            FacturaCompraSinRetencion=49,
            /// <summary>
            /// IVA de margen de comercialización de instrumentos de prepago.
            /// Para facturas de venta del contribuyente.
            /// </summary>
            [XmlEnum("50")]
            IVAMargenComercializacionInstrumentosPrepago = 50,
            /// <summary>
            /// 1.93 UTM/KM3.
            /// Impuesto gas natural comprimido.
            /// Artículo 1°, Ley N°20.052.
            /// Para facturas de venta del contribuyente.
            /// </summary>
            [XmlEnum("51")]
            ImpuestoGasNaturalComprimido = 51,
            /// <summary>
            /// Impuesto gas licuado.
            /// 1.40 UTM/M3.
            /// Artículo 1°, Ley N°20.052.
            /// Para facturas de venta del contribuyente.
            /// </summary>
            [XmlEnum("52")]
            ImpuestoGasLicuado = 52,
            /// <summary>
            /// Impuesto retenido sumplementeros.
            /// Artículo 74 N°5 Ley de la renta.
            /// Para facturas de venta del contribuyente.
            /// Retención del 0.5% sobre el precio de venta al público.
            /// </summary>
            [XmlEnum("53")]
            ImpuestoRetenidoSumplementeros = 53
        }

        public enum TipoImpuestoResumido : int
        {
            /// <summary>
            /// No se ha establecido un valor aún
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// IVA
            /// </summary>
            [XmlEnum("1")]
            Iva = 1,
            /// <summary>
            /// Ley 18.211. Se usa para documentos de Zona Franca. Tipo de documento 108 (SRF)
            /// </summary>
            [XmlEnum("2")]
            Ley18211 = 2
        }
    }
}
