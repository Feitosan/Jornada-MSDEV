using System;

namespace primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite qualquer numero:");
            var numero = Console.ReadLine();
            var numero1 = double.Parse(numero);
            var numero2 = 2;
            double resultado = numero1 % numero2;
            if (resultado == 0)
            {
                System.Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
        }
    }
}
