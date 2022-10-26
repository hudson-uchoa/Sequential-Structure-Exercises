using System;
using System.Globalization;

namespace ExeciciosEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            Console.WriteLine("Digite um número inteiro:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro ao qual será somado ao anterior:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {n1 + n2}");

            //Exercicio 02
            Console.WriteLine("Digite um raio de um circulo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            Console.WriteLine("Resultado: "+ (pi * Math.Pow(raio, 2.0)).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}