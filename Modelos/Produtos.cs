namespace ExercicioMercado.Modelos
{
    class Produtos
    {
        public Produtos(string nome, uint quantidade, double valorUnitario)
        { 
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            Nome = nome;
        }
        public string? Nome { get; set; }
        public uint? Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}