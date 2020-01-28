namespace BuscaBinaria
{
    public class Carro
    {
        public Carro(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return $"Carro: {Nome}, Valor: R$ {Preco.ToString("N2")}";
        }
    }
}
