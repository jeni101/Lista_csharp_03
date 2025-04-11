namespace BancoApp.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public double Taxa { get; set; } = 2.50;

        public ContaCorrente(string titular, double saldoInicial) : base(titular, saldoInicial) {}

        public override void Sacar(double valor)
        {
            double total = valor + Taxa;

            if (total <= Saldo)
            {
                Saldo -= total;
                Console.WriteLine($"{Titular} sacou R$ {valor} com taxa de R$ {Taxa}. Novo saldo: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque com taxa.");
            }
        }
    }
}
