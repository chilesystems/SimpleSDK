using System;

namespace SimpleSDK.Helpers
{
    public class Rut
    {
        public bool IsValid { get; private set; }
        public int Numero { get; private set; }
        public string Verificador { get; private set; }

        public string ConPuntosConGuion { get { return Numero.ToString("N0") + "-" + Verificador; } }
        public string SinPuntosConGuion { get { return Numero + "-" + Verificador; } }
        
        public Rut(string rut)
        {
            var t = rut.ToLower();
            int n;
            string v;
            IsValid = Validar(t, out n, out v);
            if (IsValid)
            { 
                Numero = n;
                Verificador = v;
            }

        }

        private bool Validar(string rut, out int Numero, out string Verificador)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                Numero = rutAux;
                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
                Verificador = dv.ToString();

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
                Numero = 0;
                Verificador = "0";
            }
            return validacion;
        }
    }
}
