using PatternAppState.ImpostoRendaState;
using System;

namespace PatternAppState
{
    class Program
    {
        static void Main(string[] args)
        {
            var salario = new Salario(1500M, 1600M);
            salario.AplicaAliquota();
            salario.AplicaAliquota();
            salario.AplicaAliquota();

            Console.ReadKey();
        }
    }
}
