using System;

namespace exInternet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex04();
        }

        public static void Ex01()
        {
            // Escrever um programa para exibir os números de 1 até 50 na tela.

            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }

        }

        public static void Ex02()
        {
            // Fazer um programa para encontrar todos os números pares entre 1 e 100.

            for(int i=1; i <= 100; i++)
            {
                if(i%2== 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Ex03()
        {
            // Ler um valor inteiro (aceitar somente valores entre 1 e 10) e escrever a tabuada de 1 a 10 do valor lido.


            for(int i = 0;i <= 0; i++)
            {
                Console.WriteLine("Digite o valor: ");
                int numero = int.Parse(Console.ReadLine());
                if(numero>=1 && numero <= 10)
                {
                    Console.WriteLine($"A tabuada do numero {numero} sera exibida logo abaixo: ");
                    Console.WriteLine($"{numero}x1 = {numero*1}");
                    Console.WriteLine($"{numero}x2 = {numero * 2}");
                    Console.WriteLine($"{numero}x3 = {numero * 3}");
                    Console.WriteLine($"{numero}x4 = {numero * 4}");
                    Console.WriteLine($"{numero}x5 = {numero * 5}");
                    Console.WriteLine($"{numero}x6 = {numero * 6}");
                    Console.WriteLine($"{numero}x7 = {numero * 7}");
                    Console.WriteLine($"{numero}x8 = {numero * 8}");
                    Console.WriteLine($"{numero}x9 = {numero * 9}");
                    Console.WriteLine($"{numero}x10 = {numero * 10}");

                }
                else
                {
                    Console.WriteLine("O numero digitado é menor que 1 e maior que 10");
                }
            }
        }

        public static void Ex04()
        {
            // Leia várias idades e calcule a média entre as idades (usar uma variável para idade).
            int idade = 0;
            int media = 0;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                media += idade;


            }
            Console.WriteLine($"A media de idade é {media / 3}");
        }
    }
}
