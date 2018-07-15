using System;

namespace PatternAppState.ImpostoRendaState
{
    sealed class AliquotaPercentual27 : IImpostoRendaState
    {
        public void CalculaImpostoRenda(Salario salario) => Console.WriteLine(869.36M);
    }
}
