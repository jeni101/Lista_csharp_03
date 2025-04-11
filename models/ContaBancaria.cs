namespace BancoApp.Models
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"{Titular} depositou R$ {valor}. Novo saldo: R$ {Saldo}");
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"{Titular} sacou R$ {valor}. Novo saldo: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
