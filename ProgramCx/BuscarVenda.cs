using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace ProgramCx
{
    public partial class BuscarVenda : Form
    {
        public BuscarVenda()
        {
            InitializeComponent();
        }

        private List<Venda> todasAsVendas = new List<Venda>();
        private BindingSource bindingSource = new BindingSource();

        private void CarregarVendas()
        {
            todasAsVendas = RepositorioVenda.Carregar();
            bindingSource.DataSource = todasAsVendas;
            DgvBuscarVendas.DataSource = bindingSource;

            DgvBuscarVendas.ReadOnly = true;
            DgvBuscarVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBuscarVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvBuscarVendas.AllowUserToAddRows = false;

            DgvBuscarVendas.CellFormatting += (s, e) =>
            {
                if (DgvBuscarVendas.Columns[e.ColumnIndex].Name == "ValorTotal" || DgvBuscarVendas.Columns[e.ColumnIndex].Name == "PrecoUnitario")
                {
                    if (e.Value is decimal valor)
                    {
                        e.Value = valor.ToString("C", new CultureInfo("pt-BR"));
                        e.FormattingApplied = true;
                    }
                }

                if (DgvBuscarVendas.Columns[e.ColumnIndex].Name == "DataHora")
                {
                    if (e.Value is DateTime data)
                    {
                        e.Value = data.ToString("dd/MM/yyyy HH:mm");
                        e.FormattingApplied = true;
                    }
                }
            };
        }

        private void InicializarControles()
        {
            TxtBuscarVenda.TextChanged += (s, e) => AplicarFiltro();
            BtnFiltrar.Click += (s, e) => AplicarFiltro();

            DtpInicio.Value = DateTime.Today.AddDays(-7);
            DtpFim.Value = DateTime.Today;
        }

        private void HistoricoVendas_Load(object sender, EventArgs e)
        {
            CarregarVendas();
            InicializarControles();
        }

        private void AplicarFiltro()
        {
            string termo = TxtBuscarVenda.Text.Trim().ToLower();
            DateTime inicio = DtpInicio.Value.Date;
            DateTime fim = DtpFim.Value.Date.AddDays(1).AddTicks(-1);


            var filtradas = todasAsVendas.Where(v => v.NomeProduto.ToLower().Contains(termo) && v.DataHora >= inicio && v.DataHora <= fim).ToList();

            bindingSource.DataSource = filtradas;
            bindingSource.ResetBindings(false);
        }
        private void BtnLimparFiltros_Click(object sender, EventArgs e)
        {
            TxtBuscarVenda.Clear();
            DtpInicio.Value = DateTime.Today.AddDays(-7);
            DtpFim.Value = DateTime.Today;
            AplicarFiltro();
        }
    }
}
