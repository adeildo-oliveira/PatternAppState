using System;

namespace PatternAppState.ImpostoRendaState
{
    sealed class AliquotaPercentual22 : IImpostoRendaState
    {
        public void CalculaImpostoRenda(Salario salario)
        {
            if (salario.SalarioTotal() >= 3751.06M && salario.SalarioTotal() <= 4664.68M)
                Console.WriteLine(636.13M);
            else
                salario.EstadoImposto = new AliquotaPercentual27();
        }
    }
}
