using System;

namespace Aula03
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            Ex01();
        }


        public static void Ex01()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            int numero = 0;
            double nota = 0;
            while (numero <= 4)
            {
                Console.WriteLine("Digite sua nota: ");
                nota += double.Parse(Console.ReadLine());
                numero++;

            };
            double media = nota / 5;
            if(media < 6)
            {
                Console.WriteLine("O aluno não foi aprovado");
                
            }
            else
            {
                Console.WriteLine($"O aluno {nome}, foi aprovado!!");
            }
                
        }

        public static void Ex02()
        {
            Console.WriteLine("digite o numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero > numero1 && numero > numero2)
            {
                Console.WriteLine($"O maior numero é o numero {numero}");
            }
            else if (numero2 > numero1 && numero2 > numero)
            {
                Console.WriteLine($"O maior numero é o numero {numero2}");
            }
            else
            {
                Console.WriteLine($"O maior numero é o numero {numero1}");
            }
        }

        public static void Ex03()
        {
            double salario = 1000;

            Console.WriteLine("Digite seu cargo: ");
            string cargo = Console.ReadLine();
            Console.WriteLine("Digite o numero do seu cargo: ");
            string numero = Console.ReadLine();


            switch (numero)
            {
                case "1": Console.WriteLine($"O seu salario antigo era {salario}, seu salario com o aumento é {salario * 0.1 + salario}"); break;
                case "2": Console.WriteLine($"O seu salario antigo era {salario}, seu salario com o aumento é {salario * 0.2 + salario}"); break;
                case "3": Console.WriteLine($"O seu salario antigo era {salario}, seu salario com o aumento é {salario * 0.3 + salario}"); break;
                    default: Console.WriteLine($"O seu salario antigo era {salario}, seu salario com o aumento é {salario * 0.4 + salario}"); break;
            }
        }

        

    }
}
