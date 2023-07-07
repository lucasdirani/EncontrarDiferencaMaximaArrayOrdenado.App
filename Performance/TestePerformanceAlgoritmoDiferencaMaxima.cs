using BenchmarkDotNet.Attributes;
using EncontrarDiferencaMaximaArrayOrdenado.App.Algoritmos;

namespace EncontrarDiferencaMaximaArrayOrdenado.App.Performance
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TestePerformanceAlgoritmoDiferencaMaxima
    {
        [Params(
            new int[] { 5, 9, 3, 20, 7, 15, 90, 135, 52, 58, 60, 77, 24, 250, 1, 79, 100, 347 },
            new int[] { 5, 9, 3, 20, 7, 15, 90, 135, 52, 58, 60, 77, 24, 250, 1, 79, 100, 347, 55, 88, 12, 28, 99, 241, 100, 186, 2, 68, 20, 21, 3, 299, 76, 200, 500, 786, 29, 85, 400, 459 },
            new int[] { 5, 9, 3, 20, 7, 15, 90, 135, 52, 58, 60, 77, 24, 250, 1, 79, 100, 347, 55, 88, 12, 28, 99, 241, 100, 186, 2, 68, 20, 21, 3, 299, 76, 200, 500, 786, 29, 85, 400, 459, 700, 1000, 33, 99, 10, 76, 24, 29, 78, 88, 99, 108, 200, 345, 201, 205, 4, 81, 33, 38, 205, 903, 35, 300, 29, 46, 2, 109, 509, 568, 203, 207, 1, 1009, 500, 503, 77, 92, 100, 104 },
            new int[] { 5, 9, 3, 20, 7, 15, 90, 135, 52, 58, 60, 77, 24, 250, 1, 79, 100, 347, 55, 88, 12, 28, 99, 241, 100, 186, 2, 68, 20, 21, 3, 299, 76, 200, 500, 786, 29, 85, 400, 459, 700, 1000, 33, 99, 10, 76, 24, 29, 78, 88, 99, 108, 200, 345, 201, 205, 4, 81, 33, 38, 205, 903, 35, 300, 29, 46, 2, 109, 509, 568, 203, 207, 1, 1009, 500, 503, 77, 92, 100, 104, 8, 99, 20, 83, 75, 100, 57, 86, 200, 206, 34, 49, 81, 89, 90, 112, 25, 39, 9, 62, 35, 39, 450, 457, 1000, 2531, 27, 44, 31, 945, 99, 561, 394, 9381, 43, 87, 26, 481, 9, 99, 10, 59, 82, 254, 29, 598, 1, 42, 5, 69, 267, 400, 899, 900, 2, 39, 100, 1000, 369, 401, 55, 97 })]
        public int[] Array { get; set; }

        [Benchmark]
        public void MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeQuadratica()
        {
            _ = AlgoritmoDiferencaMaxima.EncontrarDiferencaMaximaEmComplexidadeQuadratica(Array, Array.Length);
        }

        [Benchmark]
        public void MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeLinear()
        {
            _ = AlgoritmoDiferencaMaxima.EncontrarDiferencaMaximaEmComplexidadeLinear(Array, Array.Length);
        }
    }
}