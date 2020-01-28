namespace BuscaBinaria
{
    public static class QuickSort
    {
        public static void Ordena(Carro[] carros, int de, int ate)
        {
            int elementos = ate - de;
            int posicaoPivo;

            if (elementos > 1)
            {
                posicaoPivo = Particiona(carros, de, ate);
                Ordena(carros, de, posicaoPivo);
                Ordena(carros, posicaoPivo + 1, ate);
            }
        }

        private static int Particiona(Carro[] carros, int inicio, int termino)
        {
            int menoresEncontrados = inicio;

            Carro pivo = carros[termino - 1];
            Carro atual;

            for (int analisando = inicio; analisando < termino - 1; analisando++)
            {
                atual = carros[analisando];

                if (atual.Preco <= pivo.Preco)
                {
                    Troca(carros, analisando, menoresEncontrados);
                    menoresEncontrados++;
                }
            }

            Troca(carros, termino - 1, menoresEncontrados);

            return menoresEncontrados;
        }

        private static void Troca(Carro[] carros, int de, int para)
        {
            Carro carro1 = carros[de];
            Carro carro2 = carros[para];

            carros[para] = carro1;
            carros[de] = carro2;
        }
    }
}
