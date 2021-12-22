using ProjetoElevador.Models;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();
            // interage com o usuario pedindo que ele informe a quantidade  de andares e a capacidade maxima de pessoas do elevador.
            elevador.inicializar(elevador.andaresPredio, elevador.andarAtual, elevador.pessoasNoElevador, elevador.capacidadeElevador);
            // mostra o menu de opçoes para usuario decidir qual sera a ação.
            // caso o usuario digite uma opção invalida ele mostra que a opção não é valida e mostra novamente o menu.
            // caso o usuario não digite a quinta opção o menu ira ficar em loop até ele informar que quer sair do programa.
            bool continuar = true;
            do
            {

                Console.WriteLine(@" Escolha uma opção:
                                    1 - Entrar
                                    2 - Sair
                                    3 - Subir
                                    4 - Descer
                                    5 - Sair do Programa!!
                          ");

                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();

                // usei o switch para executar as funçoes que o usuario decidir.
                switch (opcaoEscolhida)
                {
                    case "1": elevador.entrar(elevador.capacidadeElevador, elevador.andarAtual, elevador.pessoasNoElevador); break;
                    case "2": elevador.sair(elevador.pessoasNoElevador, elevador.andarAtual); break;
                    case "3": elevador.subir(elevador.capacidadeElevador, elevador.pessoasNoElevador, elevador.andarAtual, elevador.andaresPredio); break;
                    case "4": elevador.descer(elevador.capacidadeElevador, elevador.pessoasNoElevador, elevador.andarAtual, elevador.andaresPredio); break;
                    case "5": continuar = false; break;
                    default:
                        Console.WriteLine("Escolha não válida.");
                        break;
                }


            }
            while (continuar);
        }
    }
}
