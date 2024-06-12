using Modulo1.Console.Common;
using Modulo1.Console.Enum;

namespace Modulo1.Console.Entidades
{
    public abstract class Veiculo : ClasseBase
    {
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public string? Cor { get; set; }

        public abstract double CalcularPreco(Ticket ticket);
    }
}
