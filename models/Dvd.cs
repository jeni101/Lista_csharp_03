using System;

namespace MidiaApp
{
    public class DVD : Midia
    {
        public double Duracao { get; set; } // em minutos

        public DVD(string titulo, string autor, double duracao) : base(titulo, autor)
        {
            Duracao = duracao;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Duração: {Duracao} minutos");
        }
    }
}
