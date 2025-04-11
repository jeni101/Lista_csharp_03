namespace EletronicoApp
{
    public class Eletronico
    {
        public string Nome { get; set; }

        public Eletronico(string nome)
        {
            Nome = nome;
        }

        public virtual void Ligar()
        {
            Console.WriteLine($"{Nome} está ligando (comportamento genérico).");
        }
    }
}
