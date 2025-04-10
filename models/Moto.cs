namespace VeiculosApp
{
    public class Moto : Veiculo
    {
        public Moto(string marca, string modelo, int ano) : base(marca, modelo, ano)
        {
        }

        public override void Mensagem()
        {
            Console.WriteLine($"[Moto] Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
    }
}
