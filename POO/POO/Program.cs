using System;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da primeira pessoa: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            string n2 = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa : ");
            int idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da terceira pessoa: ");
            string n3 = Console.ReadLine();
            Console.WriteLine("Digite a idade da terceira pessoa: ");
            int idade3 = int.Parse(Console.ReadLine());

        }


        class Pessoa
        {
            string nome;
            int idade;

        }
            
       }

    }

