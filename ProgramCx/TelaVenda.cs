namespace ProgramCx
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();  
        }

        private bool finalizandoVenda = false;
          
        // inicia os itens da forma de pgto
        private void TelaVenda_Load(object sender, EventArgs e)
        {                  
            CbxFormasPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxFormasPagamento.Items.Clear();
            CbxFormasPagamento.Items.Add("Dinheiro");
            CbxFormasPagamento.Items.Add("PIX");
            CbxFormasPagamento.Items.Add("Débito");
            CbxFormasPagamento.Items.Add("Crédito");                       
        }

        //carrega os dados do produto selecionado
        private Produtos produtoAtual;
        public void CarregarDadosProduto(Produtos produtos)
        {            
            if (produtos == null) return;
            produtoAtual = produtos;
            LbNomeProdutoVendas.Text = produtos.Nome;
            NudEstoqueVenda.Value = produtos.Quantidade;
            NudTotalPagamento.Value = produtos.Preco;
            string caminhoImagem = Path.Combine(PastaPrincipal.PastaImagens(), produtos.imagemProduto);

            if (!string.IsNullOrEmpty(produtos.imagemProduto) && File.Exists(caminhoImagem))
            {
                PbxImgProdutoVendas.Image = Image.FromFile(caminhoImagem);
            }
            else
            {
                PbxImgProdutoVendas.Image = null;
            }
        }

        //faz a atualizacao do valor total de acordo com a quantidade inserida
        private void NudQuantidadeProdutoVenda_ValueChanged(object sender, EventArgs e)
        {
            if (produtoAtual != null)
            {
                NudTotalPagamento.Value = produtoAtual.Preco * (decimal)NudQuantidadeProdutoVenda.Value;
                AtualizarValorRecebido();
            }
        }

        //verifica a forma de pgto e define configs
        private bool PagamentoEmDinheiro()
        {
            return CbxFormasPagamento.SelectedItem?.ToString() == "Dinheiro";
        }

        private void AtualizarLimiteRecebimento()
        {
            NudValorRecebido.Minimum = NudTotalPagamento.Value;
        }

        private void AtualizarValorRecebido()
        {
            string formaPgto = CbxFormasPagamento.SelectedItem?.ToString();
            decimal total = NudTotalPagamento.Value;

            if(formaPgto == "PIX" || formaPgto == "Débito" || formaPgto == "Crédito" || formaPgto == "Dinheiro")
            {
                AtualizarLimiteRecebimento();
                NudValorRecebido.Value = NudTotalPagamento.Value;
            }
        }

        private void CbxFormasPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorRecebido();
            AtualizarLimiteRecebimento();

            if (!PagamentoEmDinheiro())
            {                
                NudValorRecebido.Value = NudTotalPagamento.Value;
            }
            if (PagamentoEmDinheiro())
            {                
                NudValorRecebido.Enabled = true;                
                NudTroco.Value = 0;                
            }            
            else
            {                
                NudValorRecebido.Enabled = false;                
                NudTroco.Value = 0;
            }
        }

        //calcula o troco
        private void NudValorRecebido_ValueChanged(object sender, EventArgs e)
        {
            if (PagamentoEmDinheiro())
            {
                NudValorRecebido.Minimum = NudTotalPagamento.Value;
                decimal troco = NudValorRecebido.Value - NudTotalPagamento.Value;
                NudTroco.Value = troco >= 0 ? troco : 0;
            }
        }

        public Venda vendaRealizada { get; private set; }
        //finaliza e salva o registro da venda
        private void BtnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if(produtoAtual == null)
            {
                MessageBox.Show("Nenhum produto carregado!", "AVISO");
                return;
            }

            if (CbxFormasPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma forma de pagamento!", "AVISO");
                return;
            }

            int quantidadeVendida = (int)NudQuantidadeProdutoVenda.Value;

            if (quantidadeVendida > produtoAtual.Quantidade)
            {
                MessageBox.Show("Estoque insuficiente!", "AVISO");
                return;
            }

            var produtos = ProdutoRepositorio.Carregar();
            var produtoExistente = produtos.FirstOrDefault(p => p.Nome == produtoAtual.Nome);

            if(produtoExistente != null)
            {
                produtoExistente.Quantidade -= quantidadeVendida;
                ProdutoRepositorio.Salvar(produtos);
            }

            var novaVenda = new Venda
            {
                NomeProduto = produtoAtual.Nome,
                QuantidadeVendida = quantidadeVendida,
                ValorTotal = NudTotalPagamento.Value,
                FormaPagamento = CbxFormasPagamento.SelectedItem?.ToString(),
                DataHora = DateTime.Now,
                PrecoUnitario = produtoAtual.Preco
            };

            var vendas = RepositorioVenda.Carregar();
            vendas.Add(novaVenda);
            RepositorioVenda.Salvar(vendas);
            MessageBox.Show("Venda Finalizada!", "SUCESSO");
            vendaRealizada = novaVenda;
            finalizandoVenda = true;
            if (Owner is CadastroProdutos cadastro)
            {
                cadastro.RecarregarProdutos();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //cancela a venda
        private void TelaVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!finalizandoVenda) 
            {
                bool confirmar = Dialogos.ConfirmarSaida("Tem certeza que deseja fechar?");
                if (!confirmar)
                {
                    e.Cancel = true;
                }
            }    
        }
        private void BtnCancelarVenda_Click(object sender, EventArgs e)
        {                       
            produtoAtual = null;
            LbNomeProdutoVendas.Text = "";
            NudTotalPagamento.Minimum = 0;
            NudTotalPagamento.Value = 0;
            NudQuantidadeProdutoVenda.Value = 1;
            NudValorRecebido.Minimum = 0;
            NudValorRecebido.Value = 0;
            NudTroco.Value = 0;
            PbxImgProdutoVendas.Image = null;
            this.Close();            
        }
    }
}
