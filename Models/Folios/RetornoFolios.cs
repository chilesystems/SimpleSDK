namespace SimpleSDK.Models.Folios
{
    public class RetornoFolios
    {
        public enum Tipo : int
        {
            Exito = 0,
            AnularFolios = 1,
            Error = 2,
            SuperaLoPermitido = 3
        }

        public Tipo Respuesta { get; private set; }
        public int Folios { get; private set; }

        public string FilePath { get; private set; }

        public RetornoFolios(Tipo tipo, int folios)
        {
            Respuesta = tipo;
            Folios = folios;
        }

        public RetornoFolios(Tipo tipo, string filePath)
        {
            Respuesta = tipo;
            FilePath = filePath;
        }

        public RetornoFolios(Tipo tipo)
        {
            Respuesta = tipo;
            Folios = 0;
        }
    }
}
