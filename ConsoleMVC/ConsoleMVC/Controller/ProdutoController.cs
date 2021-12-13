using ConsoleMVC.Model;
using ConsoleMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controller
{
    internal class ProdutoController
    {
        ProdutoModel produto = new ProdutoModel();
        ProdutoView produtoview = new ProdutoView();
        

        public bool LoginClass()
        {
           return produtoview.Logincerto(produto.Login());
        }

        public void ListarProdutos()
        {
            produtoview.Listar(produto.Ler());
        }
    }
}
