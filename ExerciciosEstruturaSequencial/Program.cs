using System;
using System.Globalization;

namespace ExeciciosEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Exercicio 01
            //Console.WriteLine("Digite um número inteiro:");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite outro número inteiro ao qual será somado ao anterior:");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Resultado: {n1 + n2}");

            ////Exercicio 02
            //Console.WriteLine("Digite um raio de um circulo:");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double pi = 3.14159;
            //Console.WriteLine("Resultado: " + (pi * Math.Pow(raio, 2.0)).ToString("F4", CultureInfo.InvariantCulture));

            ////Exercicio 03

            //Console.WriteLine("Digite 4 números inteiros em ordem sequencial na mesma linha (A, B, C e D):");
            //string[] nums = Console.ReadLine().Split(' ');
            //int A = int.Parse(nums[0]);
            //int B = int.Parse(nums[1]);
            //int C = int.Parse(nums[2]);
            //int D = int.Parse(nums[3]);
            //Console.WriteLine($"A diferença do produto de A e B pelo produto de C e D é: {(A * B) - (C * D)}");

            ////Exercicio 04

            //Console.WriteLine("Qual o número do funcionario?");
            //int employee = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantas horas o funcionario acima trabalhou?");
            //int hours = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quanto esse funcionario recebe por horas trabalhadas?");
            //double hourlyPaycheck = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Número do funcionario: " + employee + "\nSalário do funcionario: U$" + (hours * hourlyPaycheck).ToString("F2", CultureInfo.InvariantCulture));

            ////Execicio 05

            //Console.WriteLine("Digite o código da primeira peça:");
            //int part1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite quantas desta peça irá precisar:");
            //int numOfPart1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual o valor unitário dessa peça?");
            //double priceOfPart1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite o código da segunda peça:");
            //int part2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite quantas desta peça irá precisar:");
            //int numOfPart2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual o valor unitário dessa peça?");
            //double priceOfPart2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("VALOR TOTAL A PAGAR: R$" + ((priceOfPart1 * numOfPart1) + (priceOfPart2 * numOfPart2)).ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 06

            Console.WriteLine("Digite o valor de A (tem que ser um double):");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de B (tem que ser um double):");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de C (tem que ser um double):");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área de um triângulo retângulo (base A, altura C): "+ ((a * c) / 2).ToString("F3", CultureInfo.InvariantCulture)+"\nÁrea de um círculo (raio C): "+ (3.14159 * Math.Pow(c, 2.0)).ToString("F3", CultureInfo.InvariantCulture)+"\nÁrea de um trapézio (bases A e B, altura C): "+ (((a + b) * c) /2).ToString("F3", CultureInfo.InvariantCulture)+"\nÁrea de um quadrado (lado B): "+ (b* b).ToString("F3", CultureInfo.InvariantCulture)+"\nÁrea de um retângulo (lados A e B): "+ (a*b).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}