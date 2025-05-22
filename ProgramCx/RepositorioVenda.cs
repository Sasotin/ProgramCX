using System.Text.Json;

namespace ProgramCx
{
    public class RepositorioVenda
    {
        private static readonly string caminhoVendas = Path.Combine(PastaPrincipal.PastaJsons(), "vendas.json");
        public static List<Venda> Carregar()
        {            
            try
            {
                if (!File.Exists(caminhoVendas))
                {
                    return new List<Venda>();
                }
                string json = File.ReadAllText(caminhoVendas);
                return JsonSerializer.Deserialize<List<Venda>>(json) ?? new List<Venda>();
            }
            catch
            {
                return new List<Venda>();   
            }
        }

        public static void Salvar (List<Venda> vendas)
        {
            try
            {
                string json = JsonSerializer.Serialize(vendas);
                File.WriteAllText(caminhoVendas, json);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro ao salvar venda: {ex.Message}");
            }
        }
    }
}
