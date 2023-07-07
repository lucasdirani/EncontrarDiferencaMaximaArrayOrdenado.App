namespace EncontrarDiferencaMaximaArrayOrdenado.App.Algoritmos
{
    public static class AlgoritmoDiferencaMaxima
    {
        public static int EncontrarDiferencaMaximaEmComplexidadeQuadratica(int[] arr, int n)
        {
            int diferencaMaxima = arr[1] - arr[0];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] - arr[i] > diferencaMaxima)
                    {
                        diferencaMaxima = arr[j] - arr[i];
                    }
                }
            }
            return diferencaMaxima;
        }

        public static int EncontrarDiferencaMaximaEmComplexidadeLinear(int[] arr, int n)
        {
            int diferencaMaxima = arr[1] - arr[0];
            int menorElemento = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] - menorElemento > diferencaMaxima)
                {
                    diferencaMaxima = arr[i] - menorElemento;
                }
                if (arr[i] < menorElemento)
                {
                    menorElemento = arr[i];
                }
            }
            return diferencaMaxima;
        }
    }
}