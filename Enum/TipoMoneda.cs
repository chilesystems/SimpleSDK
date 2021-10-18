using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoMoneda
    {
        public enum TipoMonedaEnum
        {
            /// <summary>
            /// No se ha definido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet,
            [XmlEnum("BOLIVAR")]
            Bolivar,
            [XmlEnum("BOLIVIANO")]
            Boliviano,
            [XmlEnum("CHELIN")]
            Chelin,
            [XmlEnum("CORONA DIN")]
            CoronaDin,
            [XmlEnum("CORONA NOR")]
            CoronaNor,
            [XmlEnum("CORONA SC")]
            CoronaSC,
            [XmlEnum("CRUZEIRO REAL")]
            CruzeiroReal,
            [XmlEnum("DIRHAM")]
            DirHam,
            [XmlEnum("DOLAR AUST")]
            DolarAustraliano,
            [XmlEnum("DOLAR CAN")]
            DolarCan,
            [XmlEnum("DOLAR HK")]
            DolarHK,
            [XmlEnum("DOLAR NZ")]
            DolarNZ,
            [XmlEnum("DOLAR SIN")]
            DolarSin,
            [XmlEnum("DOLAR TAI")]
            DolarTai,
            [XmlEnum("DOLAR USA")]
            DolarUsa,
            [XmlEnum("DRACMA")]
            Dracma,
            [XmlEnum("ESCUDO")]
            Escudo,
            [XmlEnum("EURO")]
            Euro,
            [XmlEnum("FLORIN")]
            Florin,
            [XmlEnum("FRANCO BEL")]
            FrancoBel,
            [XmlEnum("FRANCO FR")]
            FrancoFr,
            [XmlEnum("FRANCO SZ")]
            FrancoSz,
            [XmlEnum("GUARANI")]
            Guarani,
            [XmlEnum("LIBRA EST")]
            LibraEst,
            [XmlEnum("LIRA")]
            Lira,
            [XmlEnum("MARCO AL")]
            MarcoAl,
            [XmlEnum("MARCO FIN")]
            MarcoFin,
            [XmlEnum("NUEVO SOL")]
            NuevoSol,
            [XmlEnum("OTRAS MONEDAS")]
            OtrasMonedas,
            [XmlEnum("PESETA")]
            Peseta,
            [XmlEnum("PESO")]
            Peso,
            [XmlEnum("PESO CL")]
            PesoCl,
            [XmlEnum("PESO COL")]
            PesoCol,
            [XmlEnum("PESO MEX")]
            PesoMex,
            [XmlEnum("PESO URUG")]
            PesoUrug,
            [XmlEnum("RAND")]
            Rand,
            [XmlEnum("RENMINBI")]
            Renminbi,
            [XmlEnum("RUPIA")]
            Rupia,
            [XmlEnum("SUCRE")]
            Sucre,
            [XmlEnum("YEN")]
            Yen
        }
    }
}
