using System;
using VeiculosApp;
using SeuProjeto.Models;


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
        

    }
}

