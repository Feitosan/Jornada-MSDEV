using System;
using System.Globalization;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio02();
        }

        public static void Exercicio01()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }

        public static void Exercicio02()
        {
            // Elabore um algoritmo que receba e calcule a idade média de 5 alunos.

            Console.WriteLine("Digite a nota do primeiro aluno: ");
            string aluno1 = Console.ReadLine();
            var pNota1 = double.Parse(aluno1);
         
            Console.WriteLine("Digite a nota do segundo aluno: ");
            string aluno2 = Console.ReadLine();
            var pNota2 = double.Parse(aluno2);
            
            Console.WriteLine("Digite a nota do terceiro aluno: ");
            string aluno3 = Console.ReadLine();
            var pNota3 = double.Parse(aluno1);
           
            Console.WriteLine("Digite a nota do quarto aluno: ");
            string aluno4 = Console.ReadLine();
            var pNota4 = double.Parse(aluno1);
            
            Console.WriteLine("Digite a nota do quinto aluno: ");
            string aluno5 = Console.ReadLine();
            var pNota5 = double.Parse(aluno5);

            double notaFinal = pNota1 + pNota2 + pNota3 + pNota4 + pNota5;
            Console.WriteLine($"A média dos 5 alunos é: {notaFinal / 5}");

        }
    }
}
