using System;

namespace EmpresaApp.Models
{
    public class Desenvolvedor : Funcionario
    {
        public double BonusTecnico { get; set; }

        public Desenvolvedor(string nome, double salario, double bonus)
            : base(nome, salario)
        {
            BonusTecnico = bonus;
        }

        public override void ExibirDados()
        {
            double salarioTotal = Salario + BonusTecnico;
            Console.WriteLine($"[Dev] Nome: {Nome}, Salário com bônus: {salarioTotal:C}");
        }
    }
}
