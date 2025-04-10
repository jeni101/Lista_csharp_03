namespace VeiculosApp
{
    public class Carro : Veiculo
    {
        public Carro(string marca, string modelo, int ano) : base(marca, modelo, ano)
        {
        }

        public override void Mensagem()
        {
            Console.WriteLine($"[Carro] Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
    }
}
