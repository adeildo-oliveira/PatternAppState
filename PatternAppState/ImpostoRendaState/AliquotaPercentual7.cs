using System;

namespace PatternAppState.ImpostoRendaState
{
    sealed class AliquotaPercentual7 : IImpostoRendaState
    {
        public void CalculaImpostoRenda(Salario salario)
        {
            if (salario.SalarioTotal() >= 1903.99M && salario.SalarioTotal() <= 2826.65M)
                Console.WriteLine(142.80M);
            else
                salario.EstadoImposto = new AliquotaPercentual15();
        }
    }
}
