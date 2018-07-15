using System;

namespace PatternAppState.ImpostoRendaState
{
    sealed class AliquotaPercentual15 : IImpostoRendaState
    {
        public void CalculaImpostoRenda(Salario salario)
        {
            if (salario.SalarioTotal() >= 2826.66M && salario.SalarioTotal() <= 3751.05M)
                Console.WriteLine(354.80M);
            else
                salario.EstadoImposto = new AliquotaPercentual22();
        }
    }
}
