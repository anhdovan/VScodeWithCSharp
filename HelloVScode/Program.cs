﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var s = Console.ReadLine();
        Console.WriteLine($"You entered: {s}");
        DoSomething();
    }
    private static void DoSomething()
    {
        Console.WriteLine("I am doing something");
    }
}