namespace ProgramCx
{
    public static class Dialogos
    {
        //metodo para confirmar saida do programa ou abas
        public static bool ConfirmarSaida(string mensagem = "Deseja realmente sair?", string titulo = "AVISO")
        {
            DialogResult result = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}
