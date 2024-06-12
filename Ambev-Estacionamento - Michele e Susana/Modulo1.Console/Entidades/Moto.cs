namespace Modulo1.Console.Entidades
{
    public class Moto : Veiculo
    {
        public override double CalcularPreco(Ticket ticket)
        {
            //Moto
            //Primeira hora para moto -7,00
            //Até 6 horas adicionais -0,50
            //A partir de 7 horas até 24 - diaria - 15
            //Tolerancia de 10 min(sem cobrança)
            //Entre 11 min e 20 min - ultimo valor / 60 * minutos excedentes
            //Pernoite(entre 21 e 9) - 10,00

            var valorPrimeiraHora = 7.00;
            var valorHoraAdicional = 0.50;
            var valorDiaria = 15.00;
            var valorPernoite = 10.00;

            //convertendo horas em minutos de tempo estacionado
            var totalMinutos = (ticket.DataHoraSaida.Value - ticket.DataHoraEntrada).TotalMinutes;

            //tolerancia de 10min
            if (totalMinutos <= 10)
                return 0;

            if (totalMinutos <= 60) //primeira hora
                return valorPrimeiraHora;

            else if (totalMinutos < 420) //menor que 7 horas, porque dps das 7 ate 24 é diaria
                return valorPrimeiraHora + valorHoraAdicional * ((int)((totalMinutos - 60) / 60));

            else if (totalMinutos <= 1440 && ticket.DataHoraEntrada.TimeOfDay.Hours < 21) //diaria
                return valorDiaria;

            if (ticket.DataHoraEntrada.TimeOfDay.Hours >= 21 || ticket.DataHoraSaida.Value.TimeOfDay.Hours <= 9) //pernoite
                return valorPernoite;

            return 0;
        }
    }
}
