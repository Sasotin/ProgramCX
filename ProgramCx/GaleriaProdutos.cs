using System.Windows.Forms;

namespace ProgramCx
{
    public partial class GaleriaProdutos : Form
    {
        private List<Produtos> listaDeProdutos;
        private List<Venda> listaDeVendas;
        private bool saindoGaleriaProdutos;
        public GaleriaProdutos(List<Produtos> produtos, List<Venda> vendas)
        {
            InitializeComponent();
            listaDeProdutos = produtos;
            listaDeVendas = vendas;
        }

        //carrega os produtos na galeria
        private void GaleriaProdutos_Load(object sender, EventArgs e)
        {
            GaleriaDeProdutos(listaDeProdutos);
        }       

        //cria a galeria de produtos e inicia a tela de vendas
        private void GaleriaDeProdutos(List<Produtos> produtos)
        {
            FlpGaleriaProdutos.Controls.Clear();

            foreach (var produto in produtos)
            {
                var pic = new PictureBox
                {
                    Width = 250,
                    Height = 250,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Margin = new Padding(20),
                    Cursor = Cursors.Hand
                };
                string caminhoImagem = Path.Combine(PastaPrincipal.PastaImagens(), produto.imagemProduto);

                if (!string.IsNullOrEmpty(produto.imagemProduto) && File.Exists(caminhoImagem))
                {
                    using (var imagemTemp = Image.FromFile(caminhoImagem))
                    {
                        pic.Image = new Bitmap(imagemTemp);
                    }
                }
                else
                {
                    pic.Image = null;
                }
                pic.Click += (s, e) =>
                {                    
                    TelaVenda telaVenda = new TelaVenda(); 
                    telaVenda.CarregarDadosProduto(produto);
                    if (telaVenda.ShowDialog() == DialogResult.OK)
                    {
                        if(telaVenda.vendaRealizada != null)
                        {
                            listaDeVendas.Add(telaVenda.vendaRealizada);
                        }
                        listaDeProdutos = ProdutoRepositorio.Carregar(); 
                        GaleriaDeProdutos(listaDeProdutos); 
                    }
                };

                FlpGaleriaProdutos.Controls.Add(pic);            
            }
        }

        //fecha o caixa
        private void GaleriaProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saindoGaleriaProdutos)
            {
                bool confirmar = Dialogos.ConfirmarSaida();
                if (!confirmar)
                {
                    e.Cancel = true;
                }
            }
        }
        private void BtnSairGaleria_Click(object sender, EventArgs e)
        {
            saindoGaleriaProdutos = true;
            if (Dialogos.ConfirmarSaida("Tem certeza que deseja sair?"))
            {
                this.Close();
            }
        }
    }
}
