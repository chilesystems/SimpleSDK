using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class CodigosAduana
    {
        public enum FormaPagoExportacionEnum : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("1")]
            COB1 = 1,
            [XmlEnum("11")]
            ACRED = 11,
            [XmlEnum("12")]
            CBOF = 12,
            [XmlEnum("2")]
            COBRANZA = 2,
            [XmlEnum("21")]
            SINPAGO = 21,
            [XmlEnum("32")]
            ANTICIPO = 32,
        }

        public enum Moneda
        {
            [XmlEnum("")]
            NotSet,
            [XmlEnum("PESO")]
            PESO,
            [XmlEnum("PESO CL")]
            PESO_CHILENO,
            [XmlEnum("DOLAR USA")]
            DOLAR_ESTADOUNIDENSE,
            [XmlEnum("BOLIVAR")]
            BOLIVAR,
            [XmlEnum("BOLIVIANO")]
            BOLIVIANO,
            [XmlEnum("CHELIN")]
            CHELIN,
            [XmlEnum("CORONA DIN")]
            CORONA_DINAMARCA,
            [XmlEnum("CRUZEIRO REAL")]
            CRUZEIRO_REAL,
            [XmlEnum("DIRHAM")]
            DIRHAM,
            [XmlEnum("DOLAR AUST")]
            DOLAR_AUSTRALIANO,
            [XmlEnum("DOLAR CAN")]
            DOLAR_CANADIENSE,
            [XmlEnum("EURO")]
            EURO,
            [XmlEnum("FRANCO BEL")]
            FRANCO_BEL,
            [XmlEnum("FRANCO FR")]
            FRANCO_BR,
            [XmlEnum("FRANCO SZ")]
            FRANCO_SZ,
            [XmlEnum("GUARANI")]
            GUARANI,
            [XmlEnum("LIBRA EST")]
            LIBRA_EST,
            [XmlEnum("LIRA")]
            LIRA,
            [XmlEnum("MARCO AL")]
            MARCO_AL,
            [XmlEnum("MARCO FIN")]
            MARCO_FIN,
            [XmlEnum("NUEVO SOL")]
            NUEVO_SOL,
            [XmlEnum("OTRAS MONEDAS")]
            OTRAS_MONEDAS,
            [XmlEnum("PESETA")]
            PESETA,
            [XmlEnum("PESO CL")]
            PESO_CL,
            [XmlEnum("PESO COL")]
            PESO_COL,
            [XmlEnum("PESO MEX")]
            PESO_MEX,
            [XmlEnum("PESO URUG")]
            PESO_URUG,
            [XmlEnum("RAND")]
            RAND,
            [XmlEnum("RENMINBI")]
            RENMINBI,
            [XmlEnum("RUPIA")]
            RUPIA,
            [XmlEnum("SUCRE")]
            SUCRE,
            [XmlEnum("YEN")]
            YEN
        }

        public enum ModalidadVenta : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("1")]
            A_FIRME = 1,
            [XmlEnum("2")]
            BAJO_CONDICION = 2,
            [XmlEnum("3")]
            CONSIGNACION_LIBRE = 3,
            [XmlEnum("4")]
            CONSIGNACION_MINIMO_FIRME = 4,
            [XmlEnum("9")]
            SIN_PAGO = 9
        }

        public enum ClausulaCompraVenta : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("1")]
            CIF = 1,
            [XmlEnum("2")]
            CFR = 2,
            [XmlEnum("3")]
            EXW = 3,
            [XmlEnum("4")]
            FAS = 4,
            [XmlEnum("5")]
            FOB = 5,
            [XmlEnum("6")]
            S_CLAUSULA = 6,
            [XmlEnum("9")]
            DDP = 9,
            [XmlEnum("10")]
            FCA = 10,
            [XmlEnum("11")]
            CPT = 11,
            [XmlEnum("12")]
            CIP = 12,
            [XmlEnum("17")]
            DAT = 17,
            [XmlEnum("18")]
            DAP = 18,
            [XmlEnum("8")]
            OTROS = 8,
        }

        public enum ViasdeTransporte : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("1")]
            MARITINA_FLUVIAL_Y_LACUSTRE = 1,
            [XmlEnum("4")]
            AEREO = 4,
            [XmlEnum("15")]
            POSTAL = 5,
            [XmlEnum("6")]
            FERROVIARIO = 6,
            [XmlEnum("7")]
            CARRETERO_O_TERRESTRE = 7,
            [XmlEnum("8")]
            ELEODUCTOS_GASOCUTOS = 8,
            [XmlEnum("9")]
            TENDIDO_ELECTRICO = 9,
            [XmlEnum("10")]
            OTRA = 10,
            [XmlEnum("11")]
            COURIER_AEREO = 11
        }

        public enum UnidadMedida : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("0")]
            SUM = 0,
            [XmlEnum("1")]
            TMB = 1,
            [XmlEnum("10")]
            U = 10,
            [XmlEnum("11")]
            DOC = 11,
            [XmlEnum("12")]
            U_JGO = 12,
            [XmlEnum("13")]
            MU = 13,
            [XmlEnum("14")]
            MT = 14,
            [XmlEnum("15")]
            MT2 = 15,
            [XmlEnum("16")]
            MCUB = 16,
            [XmlEnum("17")]
            PAR = 17,
            [XmlEnum("18")]
            KNFC = 18,
            [XmlEnum("19")]
            CARTON = 19,
            [XmlEnum("2")]
            QMB = 2,
            [XmlEnum("20")]
            KWH = 20,
            [XmlEnum("23")]
            BAR = 23,
            [XmlEnum("24")]
            M2_1MM = 24,
            [XmlEnum("3")]
            MKWH = 3,
            [XmlEnum("4")]
            TMN = 4,
            [XmlEnum("5")]
            KLT = 5,
            [XmlEnum("6")]
            KN = 6,
            [XmlEnum("7")]
            GN = 7,
            [XmlEnum("8")]
            HL = 8,
            [XmlEnum("9")]
            LT = 9

        }

        public enum TipoBultoEnum : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("1")]
            POLVO = 1,
            [XmlEnum("10")]
            PIEZA = 10,
            [XmlEnum("11")]
            TUBO = 11,
            [XmlEnum("12")]
            CILINDRO = 12,
            [XmlEnum("13")]
            ROLLO = 13,
            [XmlEnum("16")]
            BARRA = 16,
            [XmlEnum("17")]
            LINGOTE = 17,
            [XmlEnum("18")]
            TRONCO = 18,
            [XmlEnum("19")]
            BLOQUE = 19,
            [XmlEnum("2")]
            GRANOS = 2,
            [XmlEnum("20")]
            ROLLIZO = 20,
            [XmlEnum("21")]
            CAJON = 21,
            [XmlEnum("22")]
            CAJA_DE_CARTON = 22,
            [XmlEnum("23")]
            FARDO = 23,
            [XmlEnum("24")]
            BAUL = 24,
            [XmlEnum("25")]
            COFRE = 25,
            [XmlEnum("26")]
            ARMAZON = 26,
            [XmlEnum("27")]
            BANDEJA = 27,
            [XmlEnum("28")]
            CAJAMADERA = 28,
            [XmlEnum("29")]
            CAJALATA = 29,
            [XmlEnum("3")]
            NODULOS = 3,
            [XmlEnum("31")]
            BOTELLAGAS = 31,
            [XmlEnum("32")]
            BOTELLA = 32,
            [XmlEnum("33")]
            JAULA = 33,
            [XmlEnum("34")]
            BIDON = 34,
            [XmlEnum("35")]
            JABA = 35,
            [XmlEnum("36")]
            CESTA = 36,
            [XmlEnum("37")]
            BARRILETE = 37,
            [XmlEnum("38")]
            TONEL = 38,
            [XmlEnum("39")]
            PIPA = 39,
            [XmlEnum("4")]
            LIQUIDO = 4,
            [XmlEnum("40")]
            CAJANOESP = 40,
            [XmlEnum("41")]
            JARRO = 41,
            [XmlEnum("42")]
            FRASCO = 42,
            [XmlEnum("43")]
            DAMAJUANA = 43,
            [XmlEnum("44")]
            BARRIL = 44,
            [XmlEnum("45")]
            TAMBOR = 45,
            [XmlEnum("46")]
            CUNETE = 46,
            [XmlEnum("47")]
            TARRO = 47,
            [XmlEnum("5")]
            GAS = 5,
            [XmlEnum("51")]
            CUBO = 51,
            [XmlEnum("61")]
            PAQUETE = 61,
            [XmlEnum("62")]
            SACO = 62,
            [XmlEnum("63")]
            MALETA = 63,
            [XmlEnum("64")]
            BOLSA = 64,
            [XmlEnum("65")]
            BALA = 65,
            [XmlEnum("66")]
            RED = 66,
            [XmlEnum("67")]
            SOBRE = 67,
            [XmlEnum("73")]
            CONT20 = 73,
            [XmlEnum("74")]
            CONT40 = 74,
            [XmlEnum("75")]
            CONTENEDOR_REFRIGERADO = 75,
            [XmlEnum("76")]
            REEFER40 = 76,
            [XmlEnum("77")]
            ESTANQUE = 77,
            [XmlEnum("78")]
            CONTNOESP = 78,
            [XmlEnum("80")]
            PALLET = 80,
            [XmlEnum("81")]
            TABLERO = 81,
            [XmlEnum("82")]
            LAMINA = 82,
            [XmlEnum("83")]
            CARRETE = 83,
            [XmlEnum("85")]
            AUTOMOTOR = 85,
            [XmlEnum("86")]
            ATAUD = 86,
            [XmlEnum("88")]
            MAQUINARIA = 88,
            [XmlEnum("89")]
            PLANCHA = 89,
            [XmlEnum("90")]
            ATADO = 90,
            [XmlEnum("91")]
            BOBINA = 91,
            [XmlEnum("93")]
            BULTONOESP = 93,
            [XmlEnum("98")]
            SIN_BULTO = 98,
            [XmlEnum("99")]
            SIN_EMBALAR = 99
        }

        public enum Paises : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("101")]
            SENEGAL = 101,
            [XmlEnum("102")]
            GAMBIA = 102,
            [XmlEnum("103")]
            GUINEA_BISSAU = 103,
            [XmlEnum("104")]
            GUINEA = 104,
            [XmlEnum("105")]
            SIERRA_LEONA = 105,
            [XmlEnum("106")]
            LIBERIA = 106,
            [XmlEnum("107")]
            COSTA_DE_MARFIL = 107,
            [XmlEnum("108")]
            GHANA = 108,
            [XmlEnum("109")]
            TOGO = 109,
            [XmlEnum("111")]
            NIGERIA = 111,
            [XmlEnum("112")]
            SUDAFRICA = 112,
            [XmlEnum("113")]
            BOTSWANA = 113,
            [XmlEnum("114")]
            LESOTHO = 114,
            [XmlEnum("115")]
            MALAWI = 115,
            [XmlEnum("116")]
            ZIMBABWE = 116,
            [XmlEnum("117")]
            ZAMBIA = 117,
            [XmlEnum("118")]
            COMORAS = 118,
            [XmlEnum("119")]
            MAURICIO = 119,
            [XmlEnum("120")]
            MADAGASCAR = 120,
            [XmlEnum("121")]
            MOZAMBIQUE = 121,
            [XmlEnum("122")]
            SWAZILANDIA = 122,
            [XmlEnum("123")]
            SUDAN = 123,
            [XmlEnum("124")]
            EGIPTO = 124,
            [XmlEnum("125")]
            LIBIA = 125,
            [XmlEnum("126")]
            TUNEZ = 126,
            [XmlEnum("127")]
            ARGELIA = 127,
            [XmlEnum("128")]
            MARRUECOS = 128,
            [XmlEnum("129")]
            CABO_VERDE = 129,
            [XmlEnum("130")]
            CHAD = 130,
            [XmlEnum("131")]
            NIGER = 131,
            [XmlEnum("133")]
            MALI = 133,
            [XmlEnum("134")]
            MAURITANIA = 134,
            [XmlEnum("135")]
            TANZANIA = 135,
            [XmlEnum("136")]
            UGANDA = 136,
            [XmlEnum("137")]
            KENIA = 137,
            [XmlEnum("138")]
            SOMALIA = 138,
            [XmlEnum("139")]
            ETIOPIA = 139,
            [XmlEnum("140")]
            ANGOLA = 140,
            [XmlEnum("141")]
            BURUNDI = 141,
            [XmlEnum("142")]
            RWANDA = 142,
            [XmlEnum("143")]
            REP_DEM__CONGO = 143,
            [XmlEnum("144")]
            CONGO = 144,
            [XmlEnum("145")]
            GABON = 145,
            [XmlEnum("146")]
            S_TOM_PRINCIPE = 146,
            [XmlEnum("147")]
            GUINEA_ECUATRL = 147,
            [XmlEnum("148")]
            REP_CENT_AFRIC_ = 148,
            [XmlEnum("149")]
            CAMERUN = 149,
            [XmlEnum("150")]
            BENIN = 150,
            [XmlEnum("151")]
            TERR_BRIT_EN_AF = 151,
            [XmlEnum("152")]
            TER_ESPAN_EN_AF = 152,
            [XmlEnum("153")]
            TERR_FRAN_EN_AF = 153,
            [XmlEnum("155")]
            DJIBOUTI = 155,
            [XmlEnum("156")]
            SEYCHELLES = 156,
            [XmlEnum("159")]
            NAMIBIA = 159,
            [XmlEnum("160")]
            SUDAN_DEL_SUR = 160,
            [XmlEnum("161")]
            BURKINA_FASO = 161,
            [XmlEnum("163")]
            ERITREA = 163,
            [XmlEnum("164")]
            ISLAS_MARSHALL = 164,
            [XmlEnum("165")]
            SAHARAUI = 165,
            [XmlEnum("201")]
            VENEZUELA = 201,
            [XmlEnum("202")]
            COLOMBIA = 202,
            [XmlEnum("203")]
            TRINID_Y_TOBAGO = 203,
            [XmlEnum("204")]
            BARBADOS = 204,
            [XmlEnum("205")]
            JAMAICA = 205,
            [XmlEnum("206")]
            REP_DOMINICANA = 206,
            [XmlEnum("207")]
            BAHAMAS = 207,
            [XmlEnum("208")]
            HAITI = 208,
            [XmlEnum("209")]
            CUBA = 209,
            [XmlEnum("210")]
            PANAMA = 210,
            [XmlEnum("211")]
            COSTA_RICA = 211,
            [XmlEnum("212")]
            NICARAGUA = 212,
            [XmlEnum("213")]
            EL_SALVADOR = 213,
            [XmlEnum("214")]
            HONDURAS = 214,
            [XmlEnum("215")]
            GUATEMALA = 215,
            [XmlEnum("216")]
            MEXICO = 216,
            [XmlEnum("217")]
            GUYANA = 217,
            [XmlEnum("218")]
            ECUADOR = 218,
            [XmlEnum("219")]
            PERU = 219,
            [XmlEnum("220")]
            BRASIL = 220,
            [XmlEnum("221")]
            BOLIVIA = 221,
            [XmlEnum("222")]
            PARAGUAY = 222,
            [XmlEnum("223")]
            URUGUAY = 223,
            [XmlEnum("224")]
            ARGENTINA = 224,
            [XmlEnum("225")]
            U_S_A_ = 225,
            [XmlEnum("226")]
            CANADA = 226,
            [XmlEnum("227")]
            TERR_BRIT_EN_AM = 227,
            [XmlEnum("228")]
            TERR_FRAN_EN_AM = 228,
            [XmlEnum("229")]
            TER_HOLAN_EN_AM = 229,
            [XmlEnum("230")]
            TERR_D_DINAMARC = 230,
            [XmlEnum("231")]
            DOMINICA = 231,
            [XmlEnum("232")]
            GRANADA = 232,
            [XmlEnum("233")]
            SANTA_LUCIA = 233,
            [XmlEnum("234")]
            S_VTE_Y_GRANAD_ = 234,
            [XmlEnum("235")]
            SURINAM = 235,
            [XmlEnum("236")]
            BELICE = 236,
            [XmlEnum("240")]
            ANTIGUA_Y_BBUDA = 240,
            [XmlEnum("241")]
            SNT_KIT_AND_NEVIS = 241,
            [XmlEnum("242")]
            ANGUILA = 242,
            [XmlEnum("243")]
            ARUBA = 243,
            [XmlEnum("244")]
            BERMUDAS = 244,
            [XmlEnum("245")]
            ISLAS_VIRG_BRIT = 245,
            [XmlEnum("246")]
            ISLAS_CAYMAN = 246,
            [XmlEnum("247")]
            ANTILLAS_NEERLA = 247,
            [XmlEnum("248")]
            TURCAS_Y_CAICOS = 248,
            [XmlEnum("249")]
            ISLAS_VIRG_EUA = 249,
            [XmlEnum("250")]
            MARTINICA = 250,
            [XmlEnum("251")]
            PUERTO_RICO = 251,
            [XmlEnum("252")]
            MONSERRAT = 252,
            [XmlEnum("253")]
            GROENLADIA = 253,
            [XmlEnum("301")]
            JORDANIA = 301,
            [XmlEnum("302")]
            ARABIA_SAUDITA = 302,
            [XmlEnum("303")]
            KUWAIT = 303,
            [XmlEnum("304")]
            OMAN = 304,
            [XmlEnum("305")]
            CHIPRE = 305,
            [XmlEnum("306")]
            ISRAEL = 306,
            [XmlEnum("307")]
            IRAK = 307,
            [XmlEnum("308")]
            AFGHANISTAN = 308,
            [XmlEnum("309")]
            IRAN = 309,
            [XmlEnum("310")]
            SIRIA = 310,
            [XmlEnum("311")]
            LIBANO = 311,
            [XmlEnum("312")]
            QATAR = 312,
            [XmlEnum("313")]
            BAHREIN = 313,
            [XmlEnum("314")]
            SRI_LANKA = 314,
            [XmlEnum("315")]
            CAMBODIA = 315,
            [XmlEnum("316")]
            LAOS = 316,
            [XmlEnum("317")]
            INDIA = 317,
            [XmlEnum("318")]
            BUTAN = 318,
            [XmlEnum("319")]
            THAILANDIA = 319,
            [XmlEnum("320")]
            NEPAL = 320,
            [XmlEnum("321")]
            BANGLADESH = 321,
            [XmlEnum("322")]
            PALESTINA = 322,
            [XmlEnum("324")]
            PAKISTAN = 324,
            [XmlEnum("325")]
            VIETNAM = 325,
            [XmlEnum("326")]
            MYANMAR_EX_BIR = 326,
            [XmlEnum("327")]
            ISLAS_MALDIVAS = 327,
            [XmlEnum("328")]
            INDONESIA = 328,
            [XmlEnum("329")]
            MALASIA = 329,
            [XmlEnum("330")]
            TAIWAN_FORMOSA = 330,
            [XmlEnum("331")]
            JAPON = 331,
            [XmlEnum("332")]
            SINGAPUR = 332,
            [XmlEnum("333")]
            COREA_DEL_SUR = 333,
            [XmlEnum("334")]
            RPD_COREA_DEL_N = 334,
            [XmlEnum("335")]
            FILIPINAS = 335,
            [XmlEnum("336")]
            CHINA = 336,
            [XmlEnum("337")]
            MONGOLIA = 337,
            [XmlEnum("341")]
            EMIR_ARAB_UNID_ = 341,
            [XmlEnum("342")]
            HONG_KONG = 342,
            [XmlEnum("343")]
            TER_PORTUG_EAS = 343,
            [XmlEnum("344")]
            BRUNEI = 344,
            [XmlEnum("345")]
            MACAO = 345,
            [XmlEnum("346")]
            REPUBLICA_DE_YE = 346,
            [XmlEnum("401")]
            FIJI = 401,
            [XmlEnum("402")]
            NAURU = 402,
            [XmlEnum("403")]
            ISLAS_TONGA = 403,
            [XmlEnum("404")]
            SAMOA_OCC_ = 404,
            [XmlEnum("405")]
            NUEVA_ZELANDIA = 405,
            [XmlEnum("406")]
            AUSTRALIA = 406,
            [XmlEnum("407")]
            TERR_BRIT_EN_OP = 407,
            [XmlEnum("408")]
            TERR_FRAN_EN_OP = 408,
            [XmlEnum("409")]
            T_NORTEAM_EN_OP = 409,
            [XmlEnum("412")]
            PPUA_NVA_GUINEA = 412,
            [XmlEnum("415")]
            VANUATU = 415,
            [XmlEnum("416")]
            KIRIBATI = 416,
            [XmlEnum("417")]
            MICRONESIA = 417,
            [XmlEnum("418")]
            ISLAS_SALOMON = 418,
            [XmlEnum("419")]
            TUVALU = 419,
            [XmlEnum("420")]
            BELAU = 420,
            [XmlEnum("421")]
            NIUE = 421,
            [XmlEnum("422")]
            POLINESIA_FRAN_ = 422,
            [XmlEnum("423")]
            NUEVA_CALEDONIA = 423,
            [XmlEnum("424")]
            ISLAS_MARIANAS = 424,
            [XmlEnum("425")]
            GUAM = 425,
            [XmlEnum("426")]
            TIMOR_ORIENTAL = 426,
            [XmlEnum("427")]
            ISLAS_COOK = 427,
            [XmlEnum("501")]
            PORTUGAL = 501,
            [XmlEnum("504")]
            ITALIA = 504,
            [XmlEnum("505")]
            FRANCIA = 505,
            [XmlEnum("506")]
            IRLANDA = 506,
            [XmlEnum("507")]
            DINAMARCA = 507,
            [XmlEnum("508")]
            SUIZA = 508,
            [XmlEnum("509")]
            AUSTRIA = 509,
            [XmlEnum("510")]
            REINO_UNIDO = 510,
            [XmlEnum("511")]
            SUECIA = 511,
            [XmlEnum("512")]
            FINLANDIA = 512,
            [XmlEnum("513")]
            NORUEGA = 513,
            [XmlEnum("514")]
            BELGICA = 514,
            [XmlEnum("515")]
            HOLANDA = 515,
            [XmlEnum("516")]
            ISLANDIA = 516,
            [XmlEnum("517")]
            ESPANA = 517,
            [XmlEnum("518")]
            ALBANIA = 518,
            [XmlEnum("519")]
            RUMANIA = 519,
            [XmlEnum("520")]
            GRECIA = 520,
            [XmlEnum("521")]
            U_R_S_S = 521,
            [XmlEnum("522")]
            TURQUIA = 522,
            [XmlEnum("523")]
            MALTA = 523,
            [XmlEnum("524")]
            SANTA_SEDE = 524,
            [XmlEnum("525")]
            ANDORRA = 525,
            [XmlEnum("527")]
            BULGARIA = 527,
            [XmlEnum("528")]
            POLONIA = 528,
            [XmlEnum("530")]
            HUNGRIA = 530,
            [XmlEnum("532")]
            LUXEMBURGO = 532,
            [XmlEnum("534")]
            LIECHTENSTEIN = 534,
            [XmlEnum("535")]
            MONACO = 535,
            [XmlEnum("536")]
            SAN_MARINO = 536,
            [XmlEnum("540")]
            ARMENIA = 540,
            [XmlEnum("541")]
            AZERBAIJAN = 541,
            [XmlEnum("542")]
            BELARUS = 542,
            [XmlEnum("543")]
            BOSNIA_HEZGVINA = 543,
            [XmlEnum("544")]
            REPUBLICA_CHECA = 544,
            [XmlEnum("545")]
            REP_ESLOVACA = 545,
            [XmlEnum("546")]
            REPUBLICA_DE_SE = 546,
            [XmlEnum("547")]
            CROACIA = 547,
            [XmlEnum("548")]
            ESLOVENIA = 548,
            [XmlEnum("549")]
            ESTONIA = 549,
            [XmlEnum("550")]
            GEORGIA = 550,
            [XmlEnum("551")]
            KASAJSTAN = 551,
            [XmlEnum("552")]
            KIRGISTAN = 552,
            [XmlEnum("553")]
            LETONIA = 553,
            [XmlEnum("554")]
            LITUANIA = 554,
            [XmlEnum("555")]
            MACEDONIA = 555,
            [XmlEnum("556")]
            MOLDOVA = 556,
            [XmlEnum("557")]
            TADJIKISTAN = 557,
            [XmlEnum("558")]
            TURKMENISTAN = 558,
            [XmlEnum("559")]
            UCRANIA = 559,
            [XmlEnum("560")]
            UZBEKISTAN = 560,
            [XmlEnum("561")]
            MONTENEGRO = 561,
            [XmlEnum("562")]
            RUSIA = 562,
            [XmlEnum("563")]
            ALEMANIA = 563,
            [XmlEnum("565")]
            GIBRALTAR = 565,
            [XmlEnum("566")]
            GUERNSEY = 566,
            [XmlEnum("567")]
            ISLAS_DE_MAN = 567,
            [XmlEnum("568")]
            JERSEY = 568,
            [XmlEnum("888")]
            LOS_DEMAS = 888,
            [XmlEnum("901")]
            COMB_Y_LUBRIC_ = 901,
            [XmlEnum("902")]
            RANCHO_DE_NAVES = 902,
            [XmlEnum("903")]
            PESCA_EXTRA = 903,
            [XmlEnum("904")]
            ORIG_O_DEST__NO = 904,
            [XmlEnum("905")]
            ZF_IQUIQUE = 905,
            [XmlEnum("906")]
            DEPOSITO_FRANCO = 906,
            [XmlEnum("907")]
            ZF_PARENAS = 907,
            [XmlEnum("910")]
            ZF_ARICA_ZF_IND = 910,
            [XmlEnum("997")]
            CHILE = 997,
            [XmlEnum("998")]
            NAC_REPUTADA = 998,
            [XmlEnum("999")]
            OTROS = 999
        }

        public enum Puertos : int
        {
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("111")]
            MONTREAL = 111,
            [XmlEnum("112")]
            COSTA_DEL_PACIFICO_1 = 112,
            [XmlEnum("113")]
            HALIFAX = 113,
            [XmlEnum("114")]
            VANCOUVER = 114,
            [XmlEnum("115")]
            SAINT_JOHN = 115,
            [XmlEnum("116")]
            TORONTO = 116,
            [XmlEnum("117")]
            OTROS_PUERTOS_CANADA = 117,
            [XmlEnum("118")]
            BAYSIDE = 118,
            [XmlEnum("120")]
            PORT_CARTIES = 120,
            [XmlEnum("121")]
            COSTA_DEL_ATLANTICO = 121,
            [XmlEnum("122")]
            PUERTOS_DEL_GOLFO_ME = 122,
            [XmlEnum("123")]
            COSTA_DEL_PACIFICO_2 = 123,
            [XmlEnum("124")]
            QUEBEC = 124,
            [XmlEnum("125")]
            PRINCE_RUPERT = 125,
            [XmlEnum("126")]
            HAMILTON = 126,
            [XmlEnum("131")]
            BOSTON = 131,
            [XmlEnum("132")]
            NEW_HAVEN = 132,
            [XmlEnum("133")]
            BRIDGEPORT = 133,
            [XmlEnum("134")]
            NEW_YORK = 134,
            [XmlEnum("135")]
            FILADELFIA = 135,
            [XmlEnum("136")]
            BALTIMORE = 136,
            [XmlEnum("137")]
            NORFOLK = 137,
            [XmlEnum("139")]
            CHARLESTON = 139,
            [XmlEnum("140")]
            SAVANAH = 140,
            [XmlEnum("141")]
            MIAMI = 141,
            [XmlEnum("142")]
            EVERGLADES = 142,
            [XmlEnum("143")]
            JACKSONVILLE = 143,
            [XmlEnum("145")]
            PALM_BEACH = 145,
            [XmlEnum("146")]
            BATON_ROUGE = 146,
            [XmlEnum("147")]
            COLUMBRES = 147,
            [XmlEnum("148")]
            PITTSBURGH = 148,
            [XmlEnum("149")]
            DULUTH = 149,
            [XmlEnum("150")]
            MILWAUKEE = 150,
            [XmlEnum("151")]
            TAMPA = 151,
            [XmlEnum("152")]
            PENSACOLA = 152,
            [XmlEnum("153")]
            MOBILE = 153,
            [XmlEnum("154")]
            NEW_ORLEANS = 154,
            [XmlEnum("155")]
            PORT_ARTHUR = 155,
            [XmlEnum("156")]
            GALVESTON = 156,
            [XmlEnum("157")]
            CORPUS_CRISTI = 157,
            [XmlEnum("158")]
            BROWNSVILLE = 158,
            [XmlEnum("159")]
            HOUSTON = 159,
            [XmlEnum("160")]
            OAKLAND = 160,
            [XmlEnum("161")]
            STOCKTON = 161,
            [XmlEnum("171")]
            SEATTLE = 171,
            [XmlEnum("172")]
            PORTLAND = 172,
            [XmlEnum("173")]
            SAN_FRANCISCO = 173,
            [XmlEnum("174")]
            LOS_ANGELES = 174,
            [XmlEnum("175")]
            LONG_BEACH = 175,
            [XmlEnum("176")]
            SAN_DIEGO = 176,
            [XmlEnum("180")]
            OTROS_PUERTOS_EE_UU_ = 180,
            [XmlEnum("199")]
            LOS_VILOS = 199,
            [XmlEnum("204")]
            PATACHE = 204,
            [XmlEnum("205")]
            CALBUCO = 205,
            [XmlEnum("206")]
            MICHILLA = 206,
            [XmlEnum("207")]
            PUERTO_ANGAMOS = 207,
            [XmlEnum("208")]
            POSEIDON = 208,
            [XmlEnum("209")]
            TRES_PUENTES = 209,
            [XmlEnum("210")]
            OTROS_PUERTOS_MEXICO = 210,
            [XmlEnum("211")]
            TAMPICO = 211,
            [XmlEnum("212")]
            COSTA_DEL_PACIFICO_3 = 212,
            [XmlEnum("213")]
            VERACRUZ = 213,
            [XmlEnum("214")]
            COATZACOALCOS = 214,
            [XmlEnum("215")]
            GUAYMAS = 215,
            [XmlEnum("216")]
            MAZATLAN = 216,
            [XmlEnum("217")]
            MANZANILLO = 217,
            [XmlEnum("218")]
            ACAPULCO = 218,
            [XmlEnum("219")]
            GOLFO_DE_MEXICO, OTRO = 219,
            [XmlEnum("220")]
            ALTAMIRA = 220,
            [XmlEnum("221")]
            CRISTOBAL = 221,
            [XmlEnum("222")]
            BALBOA = 222,
            [XmlEnum("223")]
            COLON = 223,
            [XmlEnum("224")]
            OTROS_PTOS__PANAMA = 224,
            [XmlEnum("231")]
            OTROS_PTOS__COLOMBIA = 231,
            [XmlEnum("232")]
            BUENAVENTURA = 232,
            [XmlEnum("233")]
            BARRANQUILLA = 233,
            [XmlEnum("241")]
            OTROS_PTOS__ECUADOR = 241,
            [XmlEnum("242")]
            GUAYAQUIL = 242,
            [XmlEnum("251")]
            OTROS_PTOS__DE_PERU = 251,
            [XmlEnum("252")]
            CALLAO = 252,
            [XmlEnum("253")]
            ILO = 253,
            [XmlEnum("254")]
            IQUITOS = 254,
            [XmlEnum("261")]
            OTROS_PTOS_ARGENTINA = 261,
            [XmlEnum("262")]
            BUENOS_AIRES = 262,
            [XmlEnum("263")]
            NECOCHEA = 263,
            [XmlEnum("264")]
            MENDOZA = 264,
            [XmlEnum("265")]
            CORDOBA = 265,
            [XmlEnum("266")]
            BAHIA_BLANCA = 266,
            [XmlEnum("267")]
            COMODORO_RIVADAVIA = 267,
            [XmlEnum("268")]
            PUERTO_MADRYN = 268,
            [XmlEnum("269")]
            MAR_DEL_PLATA = 269,
            [XmlEnum("270")]
            ROSARIO = 270,
            [XmlEnum("271")]
            OTROS_PTOS_URUGUAY = 271,
            [XmlEnum("272")]
            MONTEVIDEO = 272,
            [XmlEnum("281")]
            OTROS_PTOS_VENEZUELA = 281,
            [XmlEnum("282")]
            LA_GUAIRA = 282,
            [XmlEnum("285")]
            MARACAIBO = 285,
            [XmlEnum("291")]
            OTROS_PTOS_BRASIL = 291,
            [XmlEnum("292")]
            SANTOS = 292,
            [XmlEnum("293")]
            RIO_DE_JANEIRO = 293,
            [XmlEnum("294")]
            RIO_GRANDE_DEL_SUR = 294,
            [XmlEnum("295")]
            PARANAGUA = 295,
            [XmlEnum("296")]
            SAO_PAULO = 296,
            [XmlEnum("297")]
            SALVADOR = 297,
            [XmlEnum("301")]
            OTROS_ANT_HOLANDESA = 301,
            [XmlEnum("302")]
            CURAZAO = 302,
            [XmlEnum("399")]
            OTROS_PTOS_AMERICA = 399,
            [XmlEnum("411")]
            SHANGAI = 411,
            [XmlEnum("412")]
            DAIREN = 412,
            [XmlEnum("413")]
            OTROS_PTOS_DE_CHINA = 413,
            [XmlEnum("420")]
            OTROS_PUERT_COREA_N = 420,
            [XmlEnum("421")]
            NAMPO = 421,
            [XmlEnum("422")]
            BUSAN = 422,
            [XmlEnum("423")]
            OTROS_PTOS__COREA_S = 423,
            [XmlEnum("431")]
            MANILA = 431,
            [XmlEnum("432")]
            OTROS_PTOS_FILIPINAS = 432,
            [XmlEnum("441")]
            OTROS_PTOS_JAPONESES = 441,
            [XmlEnum("442")]
            OSAKA = 442,
            [XmlEnum("443")]
            KOBE = 443,
            [XmlEnum("444")]
            YOKOHAMA = 444,
            [XmlEnum("445")]
            NAGOYA = 445,
            [XmlEnum("446")]
            SHIMIZUI = 446,
            [XmlEnum("447")]
            MOJI = 447,
            [XmlEnum("448")]
            YAWATA = 448,
            [XmlEnum("449")]
            FUKUYAMA = 449,
            [XmlEnum("451")]
            KAOHSIUNG = 451,
            [XmlEnum("452")]
            KEELUNG = 452,
            [XmlEnum("453")]
            OTROS_PTOS_TAIWAN = 453,
            [XmlEnum("461")]
            KARHG_ISLAND = 461,
            [XmlEnum("462")]
            OTROS_PTO_IRAN_NO_ES = 462,
            [XmlEnum("471")]
            CALCUTA = 471,
            [XmlEnum("472")]
            OTROS_PTOS__DE_INDIA = 472,
            [XmlEnum("481")]
            CHALNA = 481,
            [XmlEnum("482")]
            OTROS_PTO_BANGLADESH = 482,
            [XmlEnum("491")]
            OTROS_PTO_SINGAPURE = 491,
            [XmlEnum("492")]
            HONG_KONG = 492,
            [XmlEnum("499")]
            OTROS_PTO_ASIATICOS = 499,
            [XmlEnum("511")]
            CONSTANZA = 511,
            [XmlEnum("512")]
            OTROS_PTO_DE_RUMANIA = 512,
            [XmlEnum("521")]
            VARNA = 521,
            [XmlEnum("522")]
            OTROS_PTOS_BULGARIA = 522,
            [XmlEnum("533")]
            BELGRADO = 533,
            [XmlEnum("534")]
            OTROS_PUERTOS_DE_SER = 534,
            [XmlEnum("535")]
            PODGORITSA = 535,
            [XmlEnum("536")]
            OTROS_PUERTOS_DE_MON = 536,
            [XmlEnum("537")]
            OTROS_PUERTOS_DE_CRO = 537,
            [XmlEnum("538")]
            RIJEKA = 538,
            [XmlEnum("541")]
            OTROS_PTOS_DE_ITALIA = 541,
            [XmlEnum("542")]
            GENOVA = 542,
            [XmlEnum("543")]
            LIORNA, LIVORNO = 543,
            [XmlEnum("544")]
            NAPOLES = 544,
            [XmlEnum("545")]
            SALERNO = 545,
            [XmlEnum("546")]
            AUGUSTA = 546,
            [XmlEnum("547")]
            SAVONA = 547,
            [XmlEnum("551")]
            OTROS_PTOS_FRANCIA = 551,
            [XmlEnum("552")]
            LA_PALLICE = 552,
            [XmlEnum("553")]
            LE_HAVRE = 553,
            [XmlEnum("554")]
            MARSELLA = 554,
            [XmlEnum("555")]
            BURDEOS = 555,
            [XmlEnum("556")]
            CALAIS = 556,
            [XmlEnum("557")]
            BREST = 557,
            [XmlEnum("558")]
            RUAN = 558,
            [XmlEnum("561")]
            OTROS_PTOS_ESPANA = 561,
            [XmlEnum("562")]
            CADIZ = 562,
            [XmlEnum("563")]
            BARCELONA = 563,
            [XmlEnum("564")]
            BILBAO = 564,
            [XmlEnum("565")]
            HUELVA = 565,
            [XmlEnum("566")]
            SEVILLA = 566,
            [XmlEnum("567")]
            TARRAGONA = 567,
            [XmlEnum("568")]
            ALGECIRAS = 568,
            [XmlEnum("569")]
            VALENCIA = 569,
            [XmlEnum("571")]
            LIVERPOOL = 571,
            [XmlEnum("572")]
            LONDRES = 572,
            [XmlEnum("573")]
            ROCHESTER = 573,
            [XmlEnum("574")]
            ETEN_SALVERRY = 574,
            [XmlEnum("576")]
            OTROS_PTOS_INGLATERR = 576,
            [XmlEnum("577")]
            DOVER = 577,
            [XmlEnum("578")]
            PLYMOUTH = 578,
            [XmlEnum("581")]
            HELSINKI = 581,
            [XmlEnum("582")]
            OTROS_PTOS_FINLANDIA = 582,
            [XmlEnum("583")]
            HANKO = 583,
            [XmlEnum("584")]
            KEMI = 584,
            [XmlEnum("585")]
            KOKKOLA = 585,
            [XmlEnum("586")]
            KOTKA = 586,
            [XmlEnum("587")]
            OULO = 587,
            [XmlEnum("588")]
            PIETARSAARI = 588,
            [XmlEnum("589")]
            PORI = 589,
            [XmlEnum("591")]
            BREMEN = 591,
            [XmlEnum("592")]
            HAMBURGO = 592,
            [XmlEnum("593")]
            NUREMBERG = 593,
            [XmlEnum("594")]
            FRANKFURT = 594,
            [XmlEnum("595")]
            DUSSELDORF = 595,
            [XmlEnum("596")]
            OTROS_PTOS_ALEMANIA = 596,
            [XmlEnum("597")]
            CUXHAVEN = 597,
            [XmlEnum("598")]
            ROSTOCK = 598,
            [XmlEnum("599")]
            OLDENBURG = 599,
            [XmlEnum("601")]
            AMBERES = 601,
            [XmlEnum("602")]
            OTROS_PTO_BELGICA = 602,
            [XmlEnum("603")]
            ZEEBRUGGE = 603,
            [XmlEnum("604")]
            GHENT = 604,
            [XmlEnum("605")]
            OOSTENDE = 605,
            [XmlEnum("611")]
            LISBOA = 611,
            [XmlEnum("612")]
            OTROSS_PTOS_PORTUGAL = 612,
            [XmlEnum("613")]
            SETUBAL = 613,
            [XmlEnum("621")]
            AMSTERDAM = 621,
            [XmlEnum("622")]
            ROTTERDAM = 622,
            [XmlEnum("623")]
            OTROS_PTOS_HOLANDA = 623,
            [XmlEnum("631")]
            GOTEMBURGO = 631,
            [XmlEnum("632")]
            OTROS_PTOS_SUECIA = 632,
            [XmlEnum("633")]
            MALMO = 633,
            [XmlEnum("634")]
            HELSIMBORG = 634,
            [XmlEnum("635")]
            KALMAR = 635,
            [XmlEnum("641")]
            AARHUS = 641,
            [XmlEnum("642")]
            COPENHAGEN = 642,
            [XmlEnum("643")]
            OTROS_PTOS_DINAMARCA = 643,
            [XmlEnum("644")]
            AALBORG = 644,
            [XmlEnum("645")]
            ODENSE = 645,
            [XmlEnum("651")]
            OSLO = 651,
            [XmlEnum("652")]
            OTROS_PTO__NORUEGA = 652,
            [XmlEnum("653")]
            STAVANGER = 653,
            [XmlEnum("699")]
            OTROS_PTOS_EUROPA = 699,
            [XmlEnum("711")]
            DURBAM = 711,
            [XmlEnum("712")]
            CIUDAD_DEL_CABO = 712,
            [XmlEnum("713")]
            OTROS_PTO_SUDAFFRICA = 713,
            [XmlEnum("714")]
            SALDANHA = 714,
            [XmlEnum("715")]
            PORT_ELIZABETH = 715,
            [XmlEnum("716")]
            MOSSEL_BAY = 716,
            [XmlEnum("717")]
            EAST_LONDON = 717,
            [XmlEnum("799")]
            OTROS_PTO_DE_AFRICA = 799,
            [XmlEnum("811")]
            SIDNEY = 811,
            [XmlEnum("812")]
            FREMANTLE = 812,
            [XmlEnum("813")]
            OTROS_PTOS_AUSTRALIA = 813,
            [XmlEnum("814")]
            ADELAIDA = 814,
            [XmlEnum("815")]
            DARWIN = 815,
            [XmlEnum("816")]
            GERALDTON = 816,
            [XmlEnum("899")]
            OTROS_PTOS__OCEANIA = 899,
            [XmlEnum("900")]
            LUBRIC_ = 900,
            [XmlEnum("901")]
            ARICA = 901,
            [XmlEnum("902")]
            IQUIQUE = 902,
            [XmlEnum("903")]
            ANTOFAGASTA = 903,
            [XmlEnum("904")]
            COQUIMBO = 904,
            [XmlEnum("905")]
            VALPARAISO = 905,
            [XmlEnum("906")]
            SAN_ANTONIO = 906,
            [XmlEnum("907")]
            TALCAHUANO = 907,
            [XmlEnum("908")]
            SAN_VICENTE = 908,
            [XmlEnum("909")]
            LIRQUEN = 909,
            [XmlEnum("910")]
            PUERTO_MONTT = 910,
            [XmlEnum("911")]
            CHACABUCO_PTO_AYSEN = 911,
            [XmlEnum("912")]
            PUNTA_ARENAS = 912,
            [XmlEnum("913")]
            PATILLOS = 913,
            [XmlEnum("914")]
            TOCOPILLA = 914,
            [XmlEnum("915")]
            MEJILLONES = 915,
            [XmlEnum("916")]
            TALTAL = 916,
            [XmlEnum("917")]
            CHANARAL_BARQUITO = 917,
            [XmlEnum("918")]
            CALDERA = 918,
            [XmlEnum("919")]
            CALDERILLA = 919,
            [XmlEnum("920")]
            HUASCO_GUACOLDA = 920,
            [XmlEnum("921")]
            QUINTERO = 921,
            [XmlEnum("922")]
            JUAN_FERNANDEZ = 922,
            [XmlEnum("923")]
            CONSTUTUCION = 923,
            [XmlEnum("924")]
            TOME = 924,
            [XmlEnum("925")]
            PENCO = 925,
            [XmlEnum("926")]
            CORONEL = 926,
            [XmlEnum("927")]
            LOTA = 927,
            [XmlEnum("928")]
            LEBU = 928,
            [XmlEnum("929")]
            ISLA_DE_PASCUA = 929,
            [XmlEnum("930")]
            CORRAL = 930,
            [XmlEnum("931")]
            ANCUD = 931,
            [XmlEnum("932")]
            CASTRO = 932,
            [XmlEnum("933")]
            QUELLON = 933,
            [XmlEnum("934")]
            CHAITEN = 934,
            [XmlEnum("935")]
            TORTEL = 935,
            [XmlEnum("936")]
            NATALES = 936,
            [XmlEnum("937")]
            GUARELLO = 937,
            [XmlEnum("938")]
            PUERTO_ANDINO = 938,
            [XmlEnum("939")]
            PERCY = 939,
            [XmlEnum("940")]
            CLARENCIA = 940,
            [XmlEnum("941")]
            GREGORIO = 941,
            [XmlEnum("942")]
            CABO_NEGRO = 942,
            [XmlEnum("943")]
            PUERTO_WILLIAMS = 943,
            [XmlEnum("944")]
            TER_ANTARTICO_CHILEN = 944,
            [XmlEnum("945")]
            AEROP__CARRIEL_SUR = 945,
            [XmlEnum("946")]
            GUAYACAN = 946,
            [XmlEnum("947")]
            PASO_PEHUENCHE = 947,
            [XmlEnum("948")]
            VENTANAS = 948,
            [XmlEnum("949")]
            PINO_HACHADO = 949,
            [XmlEnum("950")]
            CALETA_COLOSO = 950,
            [XmlEnum("951")]
            AGUAS_NEGRAS = 951,
            [XmlEnum("952")]
            ZONA_FRANCA_IQUIQUE = 952,
            [XmlEnum("953")]
            ZONA_FRANCA_PTA_AREN = 953,
            [XmlEnum("954")]
            RIO_MAYER = 954,
            [XmlEnum("955")]
            RIO_MOSCO = 955,
            [XmlEnum("956")]
            VISVIRI = 956,
            [XmlEnum("957")]
            CHACALLUTA = 957,
            [XmlEnum("958")]
            CHUNGARA = 958,
            [XmlEnum("959")]
            COLCHANE = 959,
            [XmlEnum("960")]
            ABRA_DE_NAPA = 960,
            [XmlEnum("961")]
            OLLAGUE = 961,
            [XmlEnum("962")]
            SAN_PEDRO_DE_ATACAMA = 962,
            [XmlEnum("963")]
            SOCOMPA = 963,
            [XmlEnum("964")]
            SAN_FRANCISCO_2 = 964,
            [XmlEnum("965")]
            LOS_LIBERTADORES = 965,
            [XmlEnum("966")]
            MAHUIL_MALAL = 966,
            [XmlEnum("967")]
            CARDENAL_SAMORE = 967,
            [XmlEnum("968")]
            PEREZ_ROSALES = 968,
            [XmlEnum("969")]
            FUTALEUFU = 969,
            [XmlEnum("970")]
            PALENA_CARRENLEUFU = 970,
            [XmlEnum("971")]
            PANGUIPULLI = 971,
            [XmlEnum("972")]
            HUAHUM = 972,
            [XmlEnum("973")]
            LAGO_VERDE = 973,
            [XmlEnum("974")]
            APPELEG = 974,
            [XmlEnum("975")]
            PAMPA_ALTA = 975,
            [XmlEnum("976")]
            HUEMULES = 976,
            [XmlEnum("977")]
            CHILE_CHICO = 977,
            [XmlEnum("978")]
            BAKER = 978,
            [XmlEnum("979")]
            DOROTEA = 979,
            [XmlEnum("980")]
            CASAS_VIEJAS = 980,
            [XmlEnum("981")]
            MONTE_AYMOND = 981,
            [XmlEnum("982")]
            SAN_SEBASTIAN = 982,
            [XmlEnum("983")]
            COYHAIQUE_ALTO = 983,
            [XmlEnum("984")]
            TRIANA = 984,
            [XmlEnum("985")]
            IBANEZ_PALAVICINI = 985,
            [XmlEnum("986")]
            VILLA_OHIGGINS = 986,
            [XmlEnum("987")]
            AEROP_CHACALLUTA = 987,
            [XmlEnum("988")]
            AEROP_DIEGO_ARACENA = 988,
            [XmlEnum("989")]
            AEROP_CERRO_MORENO = 989,
            [XmlEnum("990")]
            AEROP_EL_TEPUAL = 990,
            [XmlEnum("991")]
            AEROP_C_I_DEL_CAMPO = 991,
            [XmlEnum("992")]
            AEROP_A_M_BENITEZ = 992,
            [XmlEnum("994")]
            ARICA_TACNA = 994,
            [XmlEnum("995")]
            ARICA_LA_PAZ = 995,
            [XmlEnum("997")]
            OTROS_PTOS__CHILENOS = 997,
            [XmlEnum("998")]
            PASO_JAMA = 998,

        }
    }
}
