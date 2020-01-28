using System;

namespace BuscaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros =
            {
                new Carro("Ferrari", 500_000),
                new Carro("Hilux", 150_000),
                new Carro("Gol", 40_000),
                new Carro("Onix", 40_000),
                new Carro("Mobi", 30_000),
                new Carro("Strada", 45_000),
                new Carro("EcoSport", 71_000)
            };

            QuickSort.Ordena(carros, 0, carros.Length);
            ImprimeCarros(carros, "Carros Ordenados");

            int posicaoEncontrada = Busca(carros, 0, carros.Length, 45_000);
            
            if(posicaoEncontrada >= 0)
            {
                Console.WriteLine
                    ($"Carro com Preço igual à { carros[posicaoEncontrada].Preco.ToString("C") } está na posição: { posicaoEncontrada }");
            }
            else
            {
                Console.WriteLine("Preço não encontrado");
            }

            Console.ReadKey();
        }

        private static int Busca(Carro[] carros, int de, int ate, decimal preco)
        {
            int meio = (de + ate) / 2;

            if(de > ate) // Preco nao encontrado
            {
                return -1;
            }

            Carro carroMeio = carros[meio];

            if (preco == carroMeio.Preco)
            {
                return meio;
            }

            if(preco < carroMeio.Preco) // Esquerda
            {
                return Busca(carros, de, meio - 1, preco);
            }

            // Direita
            return Busca(carros, meio + 1, ate, preco);
        }

        private static void ImprimeCarros(Carro[] carros, string titulo)
        {
            Console.WriteLine(titulo);
            Console.WriteLine();
            foreach (var carro in carros)
            {
                Console.WriteLine(carro.ToString());
            }
            Console.WriteLine();
        }
    }
}
