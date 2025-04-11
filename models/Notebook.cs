using System;

namespace EletronicoApp
{
    public class Notebook : Eletronico
    {
        public Notebook(string nome) : base(nome) {}

        public override void Ligar()
        {
            Console.WriteLine($"{Nome} está inicializando o sistema operacional...");
        }
    }
}
