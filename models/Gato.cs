using  AnimaisApp;

namespace SeuProjeto.Models
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade) {}

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} fez : Miau ");
        }
    }
}
