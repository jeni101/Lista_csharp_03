using System;
using VeiculosApp;
using SeuProjeto.Models;
using EmpresaApp.Models;
using FormasApp;
using InstrumentoApp;
using EletronicoApp;
using MidiaApp;
using BancoApp.Models;



public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Cachorro dog = new Cachorro("spike", 5);
        Gato cat = new Gato("Sirius", 3);
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        dog.Mensagem();
        dog.EmitirSom();

        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        cat.Mensagem();
        cat.EmitirSom();

        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        // veiculo 

        Moto moto = new Moto("Yamaha", "mt09", 2022);
        moto.Mensagem();

        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        
        Carro carro = new Carro("Ford", "Mustang", 2021);
        carro.Mensagem();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        

        // Funcionario
        Funcionario f1 = new Funcionario("João", 3000);
        f1.ExibirDados();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Gerente g1 = new Gerente("Ana", 5000, 1200);
        g1.ExibirDados();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Desenvolvedor d1 = new Desenvolvedor("Carlos", 4000, 800);
        d1.ExibirDados();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Forma quadrado = new Quadrado(4);
        Forma triangulo = new Triangulo(6, 3);

        Console.WriteLine($"Área do quadrado: {quadrado.CalcularArea()}");
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");



        InstrumentoMusical guitarra = new Guitarra("Guitarra");
        guitarra.Tocar();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        InstrumentoMusical bateria = new Bateria("Bateria");
        bateria.Tocar();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

    
 

        Eletronico celular = new Smartphone("iPhone 15");
        celular.Ligar();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Eletronico notebook = new Notebook("Dell Inspiron");
        notebook.Ligar();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


        CD cd = new CD("Greatest Hits", "Queen", 17);
        DVD dvd = new DVD("O Senhor dos Anéis", "Peter Jackson", 210);
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.WriteLine("\nCD:");
        cd.ExibirDetalhes();

        Console.WriteLine("\nDVD:");
        dvd.ExibirDetalhes();
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");    


        ContaCorrente contaCorrente = new ContaCorrente("João", 1000);
        contaCorrente.Depositar(200);
        contaCorrente.Sacar(300);

        
        Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        ContaPoupanca contaPoupanca = new ContaPoupanca("Maria", 800);
        contaPoupanca.Depositar(100);
        contaPoupanca.Sacar(950);
        
    }
}


    