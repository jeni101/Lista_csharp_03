using System;

namespace InstrumentoApp
{
    public class InstrumentoMusical
    {
        public string Nome { get; set; }

        public InstrumentoMusical(string nome)
        {
            Nome = nome;
        }

        public virtual void Tocar()
        {
            Console.WriteLine($"{Nome} está tocando um som generico.");
        }
    }
}
