using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os valores dos lados do triângulo:");
        int lado1 = int.Parse(Console.ReadLine());
        int lado2 = int.Parse(Console.ReadLine());
        int lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado1 == lado3)
        {
            Console.WriteLine("O triângulo é equilátero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("O triângulo é isósceles.");
        }
        else
        {
            Console.WriteLine("O triângulo é escaleno.");
        }
    }
}
