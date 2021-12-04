using System;

namespace exProfessorSalvatore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de baterias:");
            var quantBaterias = Console.ReadLine();
            var baterias = int.Parse(quantBaterias);
            Console.WriteLine("Digite o tempo de carga da bateria:");
            var quantTempo = Console.ReadLine();
            var tempo = int.Parse(quantTempo);

            int tempoTotal = baterias * tempo;
            int pedras = tempoTotal * 300 / 75;

            Console.WriteLine($"Essa catapulta tem {baterias} baterias");
            Console.WriteLine($"Essas baterias tem {tempo} minutos de carga cada uma.");
            Console.WriteLine($"Essa catapulta atira {pedras} pedras com {baterias} baterias, com carga de {tempoTotal} minutos.");
        }
    }
}
