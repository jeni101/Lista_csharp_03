using System;

namespace EletronicoApp
{
    public class Smartphone : Eletronico
    {
        public Smartphone(string nome) : base(nome) {}

        public override void Ligar()
        {
            Console.WriteLine($"{Nome} está ligando: Bem-vindo ao seu smartphone!");
        }
    }
}
