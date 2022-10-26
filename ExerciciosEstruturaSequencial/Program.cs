using System;

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

        }
    }
}