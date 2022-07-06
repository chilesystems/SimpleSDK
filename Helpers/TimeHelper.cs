namespace SimpleSDK.Helpers
{
    public class TimeHelper
    {
        public static string ObtenerNombreMes(int mes)
        {
            if (mes < 1) mes += 12;
            else if (mes > 12) mes -= 12;
            if (mes == 1) return "Enero";
            else if (mes == 2) return "Febrero";
            else if (mes == 3) return "Marzo";
            else if (mes == 4) return "Abril";
            else if (mes == 5) return "Mayo";
            else if (mes == 6) return "Junio";
            else if (mes == 7) return "Julio";
            else if (mes == 8) return "Agosto";
            else if (mes == 9) return "Septiembre";
            else if (mes == 10) return "Octubre";
            else if (mes == 11) return "Noviembre";
            else if (mes == 12) return "Diciembre";
            return "";
        }
        public static int ObtenerMes(string mes)
        {
            if (mes == "Enero") return 1;
            else if (mes == "Febrero") return 2;
            else if (mes == "Marzo") return 3;
            else if (mes == "Abril") return 4;
            else if (mes == "Mayo") return 5;
            else if (mes == "Junio") return 6;
            else if (mes == "Julio") return 7;
            else if (mes == "Agosto") return 8;
            else if (mes == "Septiembre") return 9;
            else if (mes == "Octubre") return 10;
            else if (mes == "Noviembre") return 11;
            else if (mes == "Diciembre") return 12;
            return 0;
        }
    }
}