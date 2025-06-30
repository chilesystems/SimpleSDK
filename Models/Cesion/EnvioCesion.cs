using SimpleSDK.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using SimpleSDK.Models.Extras;

namespace SimpleSDK.Models.Cesion
{
    public class EnvioCesion
    {
        public class AutenticacionData
        {
            public string Rut { get; set; }
            public string Password { get; set; }
        }

        public AutenticacionData Autenticacion { get; set; }
        public string CorreoNotificacion { get; set; }
        public Ambiente.AmbienteEnum Ambiente { get; set; }
        public TipoEnvio.EnvioType Tipo { get; set; }

        public EnvioCesion()
        {
            Autenticacion = new AutenticacionData();
            Ambiente = Enum.Ambiente.AmbienteEnum.Certificacion;
            Tipo = TipoEnvio.EnvioType.Cesion;
        }
    }
}
