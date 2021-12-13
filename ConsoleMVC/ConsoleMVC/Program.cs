using ConsoleMVC.Controller;
using ConsoleMVC.Model;
using ConsoleMVC.View;
using System;

namespace ConsoleMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoController mostrarProdutos = new ProdutoController();
            ProdutoController logincontroller = new ProdutoController();
            ProdutoView loginVerifica = new ProdutoView();

            if (logincontroller.LoginClass())
            {
                do
                {
                    Console.WriteLine("1-Listagem de Produtos");
                    Console.WriteLine("2-Deletar um Produto");
                    Console.WriteLine("9-Sair do Programa!!");

                    Console.WriteLine("digite o numero para acessar a função: ");
                    string num = Console.ReadLine();

                    switch (num)
                    {
                        case "1":
                            mostrarProdutos.ListarProdutos();
                            break;
                        case "2":
                            mostrarProdutos.DeleteProduto();
                            break;
                        case "9":
                            Environment.Exit(0);
                            break;
                    }
                } while (true);
            }
            
            
    
        }
    }
}
