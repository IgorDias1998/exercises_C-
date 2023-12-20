using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Menu();
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
            Console.Clear();
        }
        Console.Clear();
        Console.WriteLine("Cronometro finalizado");
        Thread.Sleep(3000);
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("S - segundo | 10s == 10 segundos");
        Console.WriteLine("M - minutos | 1m => 1minuto");
        Console.WriteLine("00 => Sair");
        Console.WriteLine("Escolha uma opção");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if(type == 'm')
        {
            multiplier = 60;
        }
        if(time == 0)
        {
            System.Environment.Exit(0);
        }

        Start(time * multiplier);
    }
}

