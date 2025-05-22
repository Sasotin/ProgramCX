namespace ProgramCx
{
    public partial class Main : Form
    {
        private GaleriaProdutos abaVendas;
        private List<Venda> listaDeVendas;
        private bool caixaAberto = false;
        private bool saindoMain = false;

        public Main()
        {
            InitializeComponent();
            listaDeVendas = new List<Venda>();
            PastaPrincipal.CriarPastas();
        }

        //abre as configurações
        private void PbxConfiguracoes_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoes = new Configuracoes();
            configuracoes.ShowDialog();
        }

        //cria as pastas e subpastas para salvar os relatorios
        private void SalvarRelatorioCompleto(List<Venda> vendas)
        {
            try
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string pastaPrincipal = Path.Combine(desktop, "Relatórios ProgramCx");
                Directory.CreateDirectory(pastaPrincipal);

                string nomeSubpasta = $"Relatorio_{DateTime.Now:yyyy-MM-dd_HH-mm}";
                string caminhoSubpasta = Path.Combine(pastaPrincipal, nomeSubpasta);
                Directory.CreateDirectory(caminhoSubpasta);

                string nomeArquivoXlsx = $"Vendas_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";
                string caminhoXlsx = Path.Combine(caminhoSubpasta, nomeArquivoXlsx);
                SalvarLogVendas.SalvarVendasComoXlsx(vendas, caminhoXlsx);
                MessageBox.Show("Relatórios salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar relatório completo: {ex.Message}");
            }            
        }

        //load inicial de alguns dados e configurações
        private void Main_Load(object sender, EventArgs e)
        {
            //logica dos botões
            caixaAberto = false;
            BtnNovaVenda.Enabled = false;
            BtnBuscarVenda.Enabled = false;
            BtnFecharCaixa.Enabled = false;
            BtnSalvarLogVendas.Enabled = false;
            
            //estado do caixa
            LbEstadoCaixa.Text = "CAIXA FECHADO";
            LbEstadoCaixa.ForeColor = Color.Red;            
        }

        //abre a aba de cadastro de produtos
        private void BtnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.ShowDialog();
        } 
               
        //abre o caixa
        private void BtnAbrirCaixa_Click(object sender, EventArgs e)
        {
            //logica dos botões
            BtnAbrirCaixa.Enabled = false;
            BtnNovaVenda.Enabled = true;
            BtnBuscarVenda.Enabled=true;
            BtnFecharCaixa.Enabled = false;
            BtnSalvarLogVendas.Enabled = false;

            //estado do caixa
            caixaAberto = true;            
            LbEstadoCaixa.Text = "CAIXA ABERTO";
            LbEstadoCaixa.ForeColor = Color.Green;            
        }

        //abre a aba de vendas
        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            if (!caixaAberto)
            {
                MessageBox.Show("Abra o caixa antes de registrar uma venda.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (abaVendas == null || abaVendas.IsDisposed)
            {
                var lista = ProdutoRepositorio.Carregar();
                abaVendas = new GaleriaProdutos(lista, listaDeVendas);
            }
            abaVendas.Show();

            //logica dos botões
            BtnFecharCaixa.Enabled = true;
        }

        private void BtnBuscarVenda_Click(object sender, EventArgs e)
        {
            BuscarVenda abaBuscarVenda = new BuscarVenda();
            abaBuscarVenda.ShowDialog();
        }

        //fecha o caixa
        private void BtnFecharCaixa_Click(object sender, EventArgs e)
        {            
            //logica dos botões
            BtnAbrirCaixa.Enabled = true;
            BtnNovaVenda.Enabled = false;
            BtnSalvarLogVendas.Enabled = true;
            
            //estado do caixa
            caixaAberto = false;
            LbEstadoCaixa.Text = "CAIXA FECHADO";
            LbEstadoCaixa.ForeColor = Color.Red;
            abaVendas.Close();
        }

        //salva o log de vendas 
        private void BtnSalvarLogVendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvando relatório completo!", "AVISO");
            SalvarRelatorioCompleto(listaDeVendas);            
        }

        //fecha o programa
        private void BtnSair_Click(object sender, EventArgs e)
        {
            saindoMain = true;
            if (Dialogos.ConfirmarSaida("Deseja sair do programa?"))
            {
                this.Close();
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saindoMain)
            {
                bool confirmar = Dialogos.ConfirmarSaida("Tem certeza que deseja fechar?");
                if (!confirmar)
                {
                    e.Cancel = true;
                }
            }
        }                            
    }
}
