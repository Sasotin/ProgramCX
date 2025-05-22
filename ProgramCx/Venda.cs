namespace ProgramCx
{
    public class Venda
    {
        public string NomeProduto { get; set; }
        public int QuantidadeVendida { get; set; }
        public decimal ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime DataHora { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
