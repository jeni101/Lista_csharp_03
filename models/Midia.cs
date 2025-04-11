using System;

namespace MidiaApp
{
    public class Midia
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Midia(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}\nAutor: {Autor}");
        }
    }
}
