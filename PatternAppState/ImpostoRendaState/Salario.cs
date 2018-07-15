namespace PatternAppState.ImpostoRendaState
{
    public class Salario
    {
        public decimal Pagamento { get; private set; }
        public decimal Adiantamento { get; private set; }
        public IImpostoRendaState EstadoImposto { get; set; }

        public Salario(decimal pagamento, decimal adiantamento)
        {
            Pagamento = pagamento;
            Adiantamento = adiantamento;

            EstadoImposto = new AliquotaLivre();
        }

        public virtual decimal SalarioTotal() => Pagamento + Adiantamento;

        public virtual void AplicaAliquota() => EstadoImposto.CalculaImpostoRenda(this);
    }
}
