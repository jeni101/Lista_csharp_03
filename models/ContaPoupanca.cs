namespace BancoApp.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string titular, double saldoInicial) : base(titular, saldoInicial) {}

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"{Titular} sacou R$ {valor} da poupança. Novo saldo: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente na poupança.");
            }
        }
    }
}
