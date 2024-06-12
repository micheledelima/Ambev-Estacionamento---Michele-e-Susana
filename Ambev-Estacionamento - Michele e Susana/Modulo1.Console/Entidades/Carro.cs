namespace Modulo1.Console.Entidades
{
    public class Carro : Veiculo
    {
        public override double CalcularPreco(Ticket ticket)
        {
            //Carro
            //Primeira hora para carro -10,00
            //Até 6 horas adicionais -2,00 - //dps das 6, acontece o que?
            //A partir de 7 horas até 24 - diaria - 25
            //Tolerancia de 10 min(sem cobrança)
            //Entre 11 min e 20 min - ultimo valor / 60 * minutos excedentes
            //Pernoite(entre 21 e 9) - 15,00

            var valorPrimeiraHora = 10.00;
            var valorHoraAdicional = 2.00;
            var valorDiaria = 25.00;
            var valorPernoite = 15.00;

            //convertendo horas em minutos de tempo estacionado
            var totalMinutos = (ticket.DataHoraSaida.Value - ticket.DataHoraEntrada).TotalMinutes;

            //tolerancia de 10min
            if (totalMinutos <= 10)
                return 0;

            if (totalMinutos <= 60) //primeira hora
                return valorPrimeiraHora;

            else if (totalMinutos < 420)  //menor que 7 horas, porque dps das 7 ate 24 é diaria
                //ex:  10 + 2 * ((300 - 60) / 60)) = 42
                return valorPrimeiraHora + valorHoraAdicional * ((int)((totalMinutos - 60) / 60));

            else if (totalMinutos <= 1440 && ticket.DataHoraEntrada.TimeOfDay.Hours < 21) //diaria
                return valorDiaria;

            if (ticket.DataHoraEntrada.TimeOfDay.Hours >= 21 || ticket.DataHoraSaida.Value.TimeOfDay.Hours <= 9) //pernoite
                return valorPernoite;

            return 0;
        }
    }
}
