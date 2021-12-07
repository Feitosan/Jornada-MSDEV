using System;

namespace Ex01_Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação matematica desejada: ");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("/");
            Console.WriteLine("*");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = operacao(n1, n2, op);

            Console.WriteLine($"O resultado da operação é: {resultado}");
        }


        static int operacao(int n1, int n2, char op)
        {
            int res;

            if (op == '+')
            {
                res = n1 + n2;
            }
            else if(op == '-')
            {
                res =n1 - n2;
            }
            else if(op == '/')
            {
                res = n1 / n2;
            }
            else
            {
                res =n1 * n2;
            }

            return res;
        }

    }
}
