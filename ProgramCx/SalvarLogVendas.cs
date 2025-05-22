using OfficeOpenXml;

namespace ProgramCx
{
    public static class SalvarLogVendas
    {
        public static void SalvarVendasComoXlsx(List<Venda> vendas, string caminhoArquivo)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Sander Feitosa");

            using (var package =  new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Log_vendas");

                worksheet.Cells[1, 1].Value = "Produto";
                worksheet.Cells[1, 2].Value = "Quantidade";
                worksheet.Cells[1, 3].Value = "Preço total";
                worksheet.Cells[1, 4].Value = "Forma de pagamento";
                worksheet.Cells[1, 5].Value = "Data/Hora";

                for(int i = 0; i < vendas.Count; i++)
                {
                    var venda = vendas[i];

                    worksheet.Cells[i + 2, 1].Value = venda.NomeProduto;
                    worksheet.Cells[i + 2, 2].Value = venda.QuantidadeVendida;                    
                    worksheet.Cells[i + 2, 3].Value = venda.ValorTotal;
                    worksheet.Cells[i + 2, 4].Value = venda.FormaPagamento;
                    worksheet.Cells[i + 2, 5].Value = venda.DataHora.ToString("dd/MM/yyyy HH:mm");
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                File.WriteAllBytes(caminhoArquivo, package.GetAsByteArray());
            }
        }        
    }      
}
