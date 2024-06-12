using Modulo1.Console.Enum;

namespace Modulo1.Console.Entidades
{

    /*
     
     * Carro
     Primeira hora para carro - 10,00
     Até 6 horas adicionais - 2,00
     A partir de 7 horas até 24 - diaria - 25
     Tolerancia de 10 min (sem cobrança)
     Entre 11 min e 20 min - ultimo valor / 60 * minutos excedentes
     Pernoite (entre 21 e 9) - 15,00


    * Moto
    Primeira hora para moto - 7,00
    Até 6 horas adicionais - 0,50
    A partir de 7 horas até 24 - diaria - 15
    Tolerancia de 10 min (sem cobrança)
    Entre 11 min e 20 min - ultimo valor / 60 * minutos excedentes
    Pernoite (entre 21 e 9) - 10,00

     */


    internal class Preco
    {
        public TipoVeiculo TipoVeiculo { get; set; }
        public decimal ValorPrimeiraHora { get; set; }
        public decimal ValorAdicionalHora { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorPernoite { get; set; }
    }
}
