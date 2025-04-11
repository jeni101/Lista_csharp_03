using System;
using VeiculosApp;
using SeuProjeto.Models;
using EmpresaApp.Models;
using FormasApp;
using InstrumentoApp;
using EletronicoApp;



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

    

        
    }
}


    