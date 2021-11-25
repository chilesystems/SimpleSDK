using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Enum
{
    public class TipoEnvio
    {
        public enum EnvioType : int 
        {
            NotSet = 0,
            EnvioDTE = 1,
            EnvioBoleta = 2,
            LVC = 3,
            RVD = 4
        }

        public enum ValidacionType : int
        {
            NotSet = 0,
            DTE = 1,
            EnvioDTE = 2,
            EnvioBoleta = 3,
            RVD = 4,
            LibroGuias = 5,
            LCV = 6
        }
    }
}
