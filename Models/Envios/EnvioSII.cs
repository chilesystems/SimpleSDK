using SimpleSDK.Models.Extras;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.Envios
{
    public class EnvioSII
    {
        /// <summary>
        /// Corresponde a los datos del certificado digital. Se debe indicar la ruta del archivo pfx y su contraseña.
        /// </summary>
        public CertificadoDigital Certificado { get; set; }
        /// <summary>
        /// Indica si el sobre corresponde a boletas u los otros DTE.
        /// </summary>
        public Enum.TipoEnvio.EnvioType Tipo { get; set; }

        /// <summary>
        /// Indica si se enviará a certificación (pruebas) o producción.
        /// </summary>
        public Enum.Ambiente.AmbienteEnum Ambiente { get; set; }

        public EnvioSII()
        {
            Certificado = new CertificadoDigital();
            Tipo = Enum.TipoEnvio.EnvioType.NotSet;
            Ambiente = Enum.Ambiente.AmbienteEnum.Certificacion;
        }
    }
}
