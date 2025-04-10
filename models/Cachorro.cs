using AnimaisApp;

namespace SeuProjeto.Models
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade) {}

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} fez: au au");
        }
    }
}
