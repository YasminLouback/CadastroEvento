using CadastroEventos.Models;

namespace CadastroEventos
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();

            lblNome.Text = $"Evento: {evento.Nome}";
            lblDatas.Text = $"De {evento.DataInicio:dd/MM/yyyy} até {evento.DataFim:dd/MM/yyyy}";
            lblDuracao.Text = $"Duração: {evento.DuracaoEmDias} dia(s)";
            lblParticipantes.Text = $"Participantes: {evento.NumeroParticipantes}";
            lblLocal.Text = $"Local: {evento.Local}";
            lblCusto.Text = $"Custo Total: R$ {evento.CustoTotal:N2}";
        }
    }
}
