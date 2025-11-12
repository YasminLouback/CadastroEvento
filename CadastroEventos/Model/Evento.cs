using System;

namespace CadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; } = string.Empty;
        public double CustoPorParticipante { get; set; }

        // Calcula a duração do evento em dias
        public int DuracaoEmDias
        {
            get
            {
                TimeSpan duracao = DataFim - DataInicio;
                return Math.Max(1, duracao.Days + 1); // inclui o dia inicial
            }
        }

        // Calcula o custo total do evento
        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
