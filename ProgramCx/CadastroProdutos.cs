using System.ComponentModel;

namespace ProgramCx
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }
                
        BindingList<Produtos> listaDeProdutos = new BindingList<Produtos>();
        Produtos produtos = new Produtos();
        private Produtos produtoEmEdicao = null;

        //limpa os campos para inserir novos dados
        private void LimparCampos()
        {
            TxtNomeProduto.Clear();
            NudQuantidadeProduto.Value = 0;
            NudPrecoProduto.Value = 0;
            PbImagemProduto.Image = null;                        
            produtos.imagemProduto = null;                        
            produtoEmEdicao = null;
        }                

        //atualiza a datagridview
        public void AtualizarDgvProdutos()
        {
            DgvProdutos.DataSource = null;
            DgvProdutos.DataSource = listaDeProdutos;
            DgvProdutos.Columns["imagemProduto"].Visible = false;
            DgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //conversor de moeda
        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {            
            if (DgvProdutos.Columns[e.ColumnIndex].Name == "Preco" && e.Value != null)
            {
                if (e.Value is decimal preco)
                {                     
                    e.Value = preco.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
                    e.FormattingApplied = true;
                }
            }
        }

        //carrega a lista de produtos
        private void CadastroProdutos_Load(Object sender, EventArgs e)
        {
            DgvProdutos.CellFormatting += dgvProdutos_CellFormatting;
            var listaCarregada = ProdutoRepositorio.Carregar();
            listaDeProdutos = new BindingList<Produtos>(listaCarregada);
            AtualizarDgvProdutos();
        }

        //seleciona imagens
        private void BtnSelecionarImgProduto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoSelecionarImagem = new OpenFileDialog();
            dialogoSelecionarImagem.Filter = "Imagens | *.jpeg;*.jpg;*.png;*.bmp";

            if (dialogoSelecionarImagem.ShowDialog() == DialogResult.OK)
            {
                string caminhoOriginal = dialogoSelecionarImagem.FileName;
                string nomeUnico = Guid.NewGuid().ToString() + Path.GetExtension(caminhoOriginal);
                string caminhoDestino = Path.Combine(PastaPrincipal.PastaImagens(), nomeUnico);

                try
                {
                    if (!File.Exists(caminhoDestino))
                    {
                        File.Copy(caminhoOriginal, caminhoDestino);
                    }
                    produtos.imagemProduto = nomeUnico;
                    using (var imgTemp = Image.FromFile(caminhoDestino))
                    {
                        PbImagemProduto.Image = new Bitmap(imgTemp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao copiar imagem: {ex.Message}");
                }
            }
        }

        //deleta a imagem selecionada
        private void BtnDeletarImgProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(produtos.imagemProduto))
            {
                string caminhoCompleto = Path.Combine(PastaPrincipal.PastaImagens(), produtos.imagemProduto);
                PbImagemProduto.Image = null;
                produtos.imagemProduto = null;
            }
        }

        //edita o produto selecionado
        private void BtnEditarProduto_Click(object sender, EventArgs e)
        {
            if (DgvProdutos.CurrentRow == null || DgvProdutos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecione um produto para editar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            produtoEmEdicao = (Produtos)DgvProdutos.CurrentRow.DataBoundItem;

            TxtNomeProduto.Text = produtoEmEdicao.Nome;
            NudQuantidadeProduto.Value = produtoEmEdicao.Quantidade;
            NudPrecoProduto.Value = produtoEmEdicao.Preco;

            string caminhoCompleto = Path.Combine(PastaPrincipal.PastaImagens(), produtoEmEdicao.imagemProduto);
            if (!string.IsNullOrEmpty(produtoEmEdicao.imagemProduto) && File.Exists(caminhoCompleto))
            {
                using (var imagemTemp = Image.FromFile(caminhoCompleto))
                {
                    PbImagemProduto.Image = new Bitmap(imagemTemp);
                }
            }
            else
            {
                PbImagemProduto.Image = null;
            }
            produtos.imagemProduto = produtoEmEdicao.imagemProduto;
        }

        //exclui um produto
        private void BtnDeletarProduto_Click(object sender, EventArgs e)
        {
            if (DgvProdutos.CurrentRow == null)
            {
                return;
            }
            var produtoSelecionado = (Produtos)DgvProdutos.CurrentRow.DataBoundItem;
            var confirm = MessageBox.Show("Deseja excluir este produto?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                listaDeProdutos.Remove(produtoSelecionado);
                AtualizarDgvProdutos();
                ProdutoRepositorio.Salvar(listaDeProdutos.ToList());
                MessageBox.Show("Produto excluído!", "AVISO");
                LimparCampos();
            }
        }

        //salva os produtos cadastrados
        private void BtnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNomeProduto.Text))
            {
                MessageBox.Show("Preencha o nome do produto.");
                return;
            }
            if (produtoEmEdicao == null)
            {                
                var novoProduto = new Produtos
                {
                    Nome = TxtNomeProduto.Text,
                    Quantidade = (int)NudQuantidadeProduto.Value,
                    Preco = NudPrecoProduto.Value,
                    imagemProduto = produtos.imagemProduto
                };

                if (!novoProduto.ValidadorDados(out string erro))
                {
                    MessageBox.Show($"Erro: {erro}", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                listaDeProdutos.Add(novoProduto);
            }
            else
            {                
                produtoEmEdicao.Nome = TxtNomeProduto.Text;
                produtoEmEdicao.Quantidade = (int)NudQuantidadeProduto.Value;
                produtoEmEdicao.Preco = NudPrecoProduto.Value;
                if (!string.IsNullOrEmpty(produtos.imagemProduto))
                {
                    produtoEmEdicao.imagemProduto = produtos.imagemProduto;
                }

                if (!produtoEmEdicao.ValidadorDados(out string erro))
                {
                    MessageBox.Show($"Erro: {erro}", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                produtoEmEdicao = null;
            }

            AtualizarDgvProdutos();            
            ProdutoRepositorio.Salvar(listaDeProdutos.ToList());
            LimparCampos();
            MessageBox.Show("Produto salvo com sucesso!", "AVISO");
        }

        //fecha a aba de cadastro
        private void BtnSairAbaCadastro_Click(object sender, EventArgs e)
        {
            LimparCampos();
            this.Close();
        }

        //atualiza a galeria de produtos com novos dados após edicao
        public void RecarregarProdutos()
        {
            listaDeProdutos = new BindingList<Produtos>(ProdutoRepositorio.Carregar());
            AtualizarDgvProdutos();
        }
    }
}
