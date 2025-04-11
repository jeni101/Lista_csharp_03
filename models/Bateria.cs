using System;

namespace InstrumentoApp
{
    public class Bateria : InstrumentoMusical
    {
        public Bateria(string nome) : base(nome) {}

        public override void Tocar()
        {
            Console.WriteLine($"{Nome} esta tocando Metalica.");
        }
    }
}
