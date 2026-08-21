class Corrente : Conta
{
    public decimal limite;

    // Construtor
    public Corrente(string nomeCliente, string numeroConta, decimal saldo, decimal limite)
        : base(nomeCliente, numeroConta, saldo)
    {
        this.limite = limite;
    }

    public bool Transfere(decimal valor, Conta conta)
    {
        if (Saca(valor))
        {
            conta.Deposita(valor);
            return true;
        }

        return false;
    }
}