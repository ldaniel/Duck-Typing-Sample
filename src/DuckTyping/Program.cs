using System;

public class Program
{
    static void Main()
    {
        Executar();
    }

    private static void Executar()
    {
        var pato = new Pato();
        var homem = new Humano();

        FazerQuack(pato);
        FazerQuack(homem);

        //var cao = new Cachorro();
        //FazerQuack(cao);  // Aqui ocorre um erro.

        Console.ReadKey();
    }

    private static void FazerQuack(dynamic ser)
    {
        ser.FazQuack();
    }
}

internal class Pato
{
    public void FazQuack()
    {
        Console.WriteLine("Quack!");
    }
}

internal class Humano
{
    public void FazQuack()
    {
        Console.WriteLine("Eu sei falar 'Quack!'");
    }
}

internal class Cachorro
{
    public void FazAu()
    {
        Console.WriteLine("Au!");
    }
}