``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                           Method |      Array |         Mean |      Error |     StdDev | Rank | Allocated |
|----------------------------------------------------------------- |----------- |-------------:|-----------:|-----------:|-----:|----------:|
| **MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeQuadratica** | **Int32[142]** | **11,047.44 ns** | **220.894 ns** | **323.784 ns** |    **8** |         **-** |
|     MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeLinear | Int32[142] |    139.49 ns |   1.107 ns |   0.924 ns |    4 |         - |
| **MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeQuadratica** |  **Int32[18]** |    **145.48 ns** |   **1.971 ns** |   **1.844 ns** |    **5** |         **-** |
|     MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeLinear |  Int32[18] |     19.37 ns |   0.406 ns |   0.556 ns |    1 |         - |
| **MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeQuadratica** |  **Int32[40]** |    **838.64 ns** |   **6.226 ns** |   **5.519 ns** |    **6** |         **-** |
|     MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeLinear |  Int32[40] |     36.37 ns |   0.354 ns |   0.331 ns |    2 |         - |
| **MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeQuadratica** |  **Int32[80]** |  **3,650.50 ns** |  **72.207 ns** | **105.840 ns** |    **7** |         **-** |
|     MedirPerformanceEncontrarDiferencaMaximaEmComplexidadeLinear |  Int32[80] |     67.70 ns |   0.855 ns |   0.800 ns |    3 |         - |
