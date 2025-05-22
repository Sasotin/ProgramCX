namespace ProgramCx
{
    public static class PastaPrincipal
    {
        //acessa appdata
        private static readonly string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //cria a pasta principal do programa
        private static readonly string pastaDados = Path.Combine(appData, "ProgramaCaixaDados");
        //cria a pasta de jsons
        private static readonly string pastaJsons = Path.Combine(pastaDados, "Jsons");
        //cria a pasta de imagens
        private static readonly string pastaImagens = Path.Combine(pastaDados, "Imagens Produtos");

        //cria as pastas
        public static void CriarPastas()
        {
            Directory.CreateDirectory(pastaJsons);
            Directory.CreateDirectory(pastaImagens);
        }
        
        public static string PastaJsons() => pastaJsons;
        public static string PastaImagens() => pastaImagens;
    }                          
}
