using System;

namespace EmpresaApp.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Salário base: {Salario:C}");
        }
    }
}
