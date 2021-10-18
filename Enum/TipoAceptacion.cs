using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimpleSDK.Enum
{
    public enum TipoAceptacion
    {
        [Description("Acepta Contenido del Documento")]
        ACD = 0,
        [Description("Reclamo al Contenido del Documento")]
        RCD = 1,
        [Description("Otorga Recibo de Mercaderías o Servicios")]
        ERM = 2,
        [Description("Reclamo por Falta Parcial de Mercaderías")]
        RFP = 3,
        [Description("Reclamo por Falta Total de Mercaderías")]
        RFT = 4
    }
}
