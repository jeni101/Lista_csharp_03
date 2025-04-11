using System;

namespace InstrumentoApp
{
    public class Guitarra : InstrumentoMusical
    {
        public Guitarra(string nome) : base(nome) {}

        public override void Tocar()
        {
            Console.WriteLine($"{Nome} está tocando um solo!");
        }
    }
}
