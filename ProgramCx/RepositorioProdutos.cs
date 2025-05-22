using System.Text.Json;

namespace ProgramCx
{
    public class ProdutoRepositorio
    {
        private static readonly string caminhoProdutos = Path.Combine(PastaPrincipal.PastaJsons(), "produtosCadastrados.json");
        public static List<Produtos> Carregar()
        {            
            try
            {
                if (!File.Exists(caminhoProdutos))
                    return new List<Produtos>();

                string json = File.ReadAllText(caminhoProdutos);
                return JsonSerializer.Deserialize<List<Produtos>>(json) ?? new List<Produtos>();
            }
            catch 
            {
                return new List<Produtos>();
            }
        }

        public static void Salvar(List<Produtos> produtos)
        {
            try
            {
                string json = JsonSerializer.Serialize(produtos);
                File.WriteAllText(caminhoProdutos, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }
    }
}
