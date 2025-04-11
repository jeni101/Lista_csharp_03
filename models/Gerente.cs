using System;

namespace EmpresaApp.Models
{
    public class Gerente : Funcionario
    {
        public double BonusGerencial { get; set; }

        public Gerente(string nome, double salario, double bonus)
            : base(nome, salario)
        {
            BonusGerencial = bonus;
        }

        public override void ExibirDados()
        {
            double salarioTotal = Salario + BonusGerencial;
            Console.WriteLine($"[Gerente] Nome: {Nome}, Salário com bônus: {salarioTotal:C}");
        }
    }
}
