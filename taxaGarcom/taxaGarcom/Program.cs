using System;

namespace taxaGarcom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var taxaGarcom = 0.10;
            var valorConta = 45.35;
            var valorDaConta = valorConta * taxaGarcom + valorConta;

            Console.WriteLine($"O valor da conta é {valorDaConta:C}");
        }
    }
}
