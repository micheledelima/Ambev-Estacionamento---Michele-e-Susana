using Modulo1.Console.Enum;

namespace Modulo1.Console.Entidades
{
    public class Ticket
    {
        public Veiculo Veiculo { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime? DataHoraSaida { get; set; }
        public Usuario Usuario { get; set; }
        public decimal ValorTotal { get; set; }
        public string Observacao { get; set; }
        public StatusTicket StatusTicket { get; set; }
    }
}
