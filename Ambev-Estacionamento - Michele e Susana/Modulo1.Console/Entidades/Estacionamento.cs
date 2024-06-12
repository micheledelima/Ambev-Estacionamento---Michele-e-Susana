namespace Modulo1.Console.Entidades
{
    internal class Estacionamento
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int QuantidadeVagasMoto { get; set; }
        public int QuantidadeVagasCarro { get; set; }
        public string CNPJ { get; set; }        
    }
}
