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

            logincontroller.loginclass();
            //mostrarProdutos.ListarProdutos();
    
        }
    }
}
