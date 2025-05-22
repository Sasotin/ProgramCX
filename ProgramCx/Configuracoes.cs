namespace ProgramCx
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void BtnResetarLogVendas_Click(object sender, EventArgs e)
        {
            string caminhoAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string caminhoPrograma = Path.Combine(caminhoAppData, "ProgramaCaixaDados");

            string caminhoLogVendas = Path.Combine(caminhoPrograma, "Jsons", "vendas.json");

            if (File.Exists(caminhoLogVendas))
            {
                var confirmacao = MessageBox.Show("Deseja realmente deletar? \nAo confirmar, todos as vendas registradas serão excluídas!", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(caminhoLogVendas);
                        MessageBox.Show("Log de vendas deletado com sucesso!", "AVISO");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Erro ao deletar arquivos: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Arquivo inesxitente!", "AVISO");
            }
        }

        private void BtnResetarProdutos_Click(object sender, EventArgs e)
        {
            string caminhoAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string caminhoPrograma = Path.Combine(caminhoAppData, "ProgramaCaixaDados");
            
            string caminhoProdutos = Path.Combine(caminhoPrograma, "Jsons", "produtosCadastrados.json");
            string imagemProdutos = Path.Combine(caminhoPrograma, "Imagens Produtos");

            if (File.Exists(caminhoProdutos) && Directory.Exists(imagemProdutos))
            {
                var confirmacao = MessageBox.Show("Deseja realmente deletar? \nAo confirmar, todos os produtos cadastrados serão excluídos!", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        // Libera as imagens travadas
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        // Exclui a pasta de imagens, se existir
                        if (Directory.Exists(imagemProdutos))
                        {
                            //Directory.Delete(imagemProdutos, true);
                            foreach (string arquivo in Directory.GetFiles(imagemProdutos))
                            {
                                File.Delete(arquivo);
                            }
                        }

                        // Exclui o arquivo de produtos
                        if (File.Exists(caminhoProdutos))
                        {
                            File.Delete(caminhoProdutos);
                        }

                        MessageBox.Show("Lista de produtos deletada com sucesso!", "AVISO");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Erro ao deletar arquivos: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo inesxitente!", "AVISO");
            }
        }

        private void BtnSairConfiguracoes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
