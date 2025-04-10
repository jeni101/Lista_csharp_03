using System;

namespace AnimaisApp
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal faz um som.");
        }

        public void Mensagem()
        {
            Console.WriteLine($"Este é {Nome} e tem {Idade} anos.");
        }
    }
}
