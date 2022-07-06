namespace SimpleSDK.Models.BHE
{
    public static class CausaAnulacionBH
    {
        public static string GetString(this CausaAnulacionBHEnum tipo)
        {
            switch (tipo)
            {
                case CausaAnulacionBHEnum.ServicioNoPagado:
                    return "No se efectuó el pago de los servicios por parte del receptor";
                case CausaAnulacionBHEnum.ServicioNoEfectuado:
                    return "No se efectuó la prestacion de servicios";
                case CausaAnulacionBHEnum.ErrorDigitacion:
                    return "Error en la digitación";
                default: return "Sin especificar";
            }         
        }
    }
    public enum CausaAnulacionBHEnum : int
    { 
        NotSet =0,
        ServicioNoPagado = 1,
        ServicioNoEfectuado = 2,
        ErrorDigitacion = 3
    }
}