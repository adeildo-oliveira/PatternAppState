using System;

namespace PatternAppState.ImpostoRendaState
{
    sealed class AliquotaLivre : IImpostoRendaState
    {
        public void CalculaImpostoRenda(Salario salario)
        {
            if (salario.SalarioTotal() <= 1903.99M)
                Console.WriteLine(salario.SalarioTotal());
            else
                salario.EstadoImposto = new AliquotaPercentual7();
        }
    }
}
