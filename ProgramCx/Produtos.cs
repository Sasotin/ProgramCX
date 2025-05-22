namespace ProgramCx
{
    public class Produtos
    {
        //dados
        public string Nome {  get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public string  imagemProduto {  get; set; }
        
        //metodo para validar os dados
        public bool ValidadorDados (out string erro)
        {
            erro = string.Empty;
            if (string.IsNullOrEmpty(Nome))
            {
                erro = "Nome é obrigatório!";                
            }  
            else if (Quantidade < 0)
            {
                erro = "Quantidade inválida!";
            }
            else if (Preco < 0)
            {
                erro = "Preço inválido!";
            }
            else if (string.IsNullOrEmpty (imagemProduto))
            {
                erro = "Imagem é obrigatória!";
            }
                return erro == "";
        }
    }
}
