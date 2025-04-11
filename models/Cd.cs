using System;

namespace MidiaApp
{
    public class CD : Midia
    {
        public int Faixas { get; set; }

        public CD(string titulo, string autor, int faixas) : base(titulo, autor)
        {
            Faixas = faixas;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Número de Faixas: {Faixas}");
        }
    }
}
