using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoMonedaBancoCentral
    {
        public enum TipoMonedaBancoCentralEnum : int
        {
            /// <summary>
            /// Aún no se ha definido un valor.
            /// </summary>
            [XmlEnum("")]
            NotSet,
            [XmlEnum("000")]
            NotSet2,
            [XmlEnum("143")]
            BAHT_TAlLANDÉS = 143,
            [XmlEnum("161")]
            BALBOA_PANAMEÑO = 161,
            [XmlEnum("134")]
            BOLÍVAR_FUERTE = 134,
            [XmlEnum("4")]
            BOLIVIANO = 4,
            [XmlEnum("153")]
            COLÓN_COSTARRICENSE = 153,
            [XmlEnum("51")]
            CORONA_DANESA = 51,
            [XmlEnum("96")]
            CORONA_NORUEGA = 96,
            [XmlEnum("146")]
            CORONA_REP_CHECA = 146,
            [XmlEnum("113")]
            CORONA_SUECA = 113,
            [XmlEnum("135")]
            DINAR = 135,
            [XmlEnum("139")]
            DIRHAM = 139,
            [XmlEnum("36")]
            DÓLAR_AUSTRALIANO = 36,
            [XmlEnum("6")]
            DÓLAR_CANADIENSE = 6,
            [XmlEnum("162")]
            DÓLAR_DE_BERMUDAS = 162,
            [XmlEnum("13")]
            DÓLAR_DE_ESTADOS_UNIDOS = 13,
            [XmlEnum("163")]
            DÓLAR_DE_LAS_ISLAS_CAIMÁN = 163,
            [XmlEnum("97")]
            DÓLAR_DE_NUEVA_ZELANDA = 97,
            [XmlEnum("136")]
            DÓLAR_DE_SINGAPUR = 136,
            [XmlEnum("154")]
            DÓLAR_FIYIANO = 154,
            [XmlEnum("127")]
            DÓLAR_HONG_KONG = 127,
            [XmlEnum("142")]
            EURO = 142,
            [XmlEnum("147")]
            FORINT_HUNGRÍA = 147,
            [XmlEnum("156")]
            FRANCO_POLINÉSICO = 156,
            [XmlEnum("82")]
            FRANCO_SUIZO = 82,
            [XmlEnum("23")]
            GUARANÍ = 23,
            [XmlEnum("164")]
            HRYVNIA_UCRANIANO = 164,
            [XmlEnum("165")]
            LIBRA_EGIPCIA = 165,
            [XmlEnum("102")]
            LIBRA_ESTERLINA = 102,
            [XmlEnum("149")]
            NUEVA_LIRA_TURCA = 149,
            [XmlEnum("138")]
            NUEVO_DÓLAR_TAIWANÉS = 138,
            [XmlEnum("166")]
            NUEVO_SHEKEL_ISRAELÍ = 166,
            [XmlEnum("24")]
            NUEVO_SOL = 24,
            [XmlEnum("1")]
            PESO_ARGENTINO = 1,
            [XmlEnum("999")]
            PESO_CHILENO = 999,
            [XmlEnum("129")]
            PESO_COLOMBIANO = 129,
            [XmlEnum("167")]
            PESO_DOMINICANO = 167,
            [XmlEnum("150")]
            PESO_FILlPINO = 150,
            [XmlEnum("132")]
            PESO_MEXICANO = 132,
            [XmlEnum("26")]
            PESO_URUGUAYO = 26,
            [XmlEnum("128")]
            RAND = 128,
            [XmlEnum("5")]
            REAL = 5,
            [XmlEnum("152")]
            RINGGIT_MALASIA = 152,
            [XmlEnum("155")]
            RUBLO = 155,
            [XmlEnum("137")]
            RUPIA_INDIA = 137,
            [XmlEnum("151")]
            RUPIA_INDONESIA = 151,
            [XmlEnum("169")]
            TENGE_KAZAJSTÁN = 169,
            [XmlEnum("144")]
            WON_DE_LA_REPÚBLICA_DE_COREA_DEL_SUR = 144,
            [XmlEnum("72")]
            YEN = 72,
            [XmlEnum("48")]
            YUAN = 48,
            [XmlEnum("145")]
            ZLOTY_POLONIA = 145,
            [XmlEnum("900")]
            OTRAS_NO_ESPECIFICADAS = 900,
            [XmlEnum("200")]
            OTRAS_NO_ESPECIFICADAS2 = 200,
            [XmlEnum("981")]
            ONZA_TROY_ORO = 981,
            [XmlEnum("982")]
            ONZA_TROY_PLATA = 982,
            [XmlEnum("980")]
            PESO_ORO_SELLADO_CHILENO = 980,
            [XmlEnum("141")]
            DEG_DERECHO_ESPECIAL_DE_GIRO = 141,
            [XmlEnum("2")]
            BID_UNIDAD_DE_CUENTA_ = 2,
            [XmlEnum("998")]
            UF_UNIDAD_DE_FOMENTO_ = 998
        }
    }
}
