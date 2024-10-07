using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.DTE
{
    public class ManejoMadera
    {
        public int ComunaRolOrigen { get; set; }

        public int MnzRolOrigen { get; set; }

        public int PrdRolOrigen { get; set; }

        public string CodPlanConaf { get; set; }

        public string LatitudOrigenMadera { get; set; }

        public string LongitudOrigenMadera { get; set; }

        public int SistemareferenciaMadera { get; set; }
    }
}
