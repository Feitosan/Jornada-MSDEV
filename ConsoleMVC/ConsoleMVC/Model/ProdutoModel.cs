using ConsoleMVC.Interface;
using ConsoleMVC.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    internal class ProdutoModel : Interface1
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }

        public string username = "vitor";
        public string password = "1234";

        private const string caminho = "Database/produto.csv";

        public void Construtor()
        {
            string pasta = caminho.Split('/')[0];

            if (!Directory.Exists(pasta))
            {

                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }         
        }

        public List<ProdutoModel> Ler()
        {
            List<ProdutoModel> ListaProdutos = new List<ProdutoModel>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string item in linhas)
            {
                string [] atributos = item.Split(';');

                ProdutoModel produtoDaLinha = new ProdutoModel();
                
                produtoDaLinha.codigo = int.Parse(atributos[0]);
                produtoDaLinha.nome = atributos[1];
                produtoDaLinha.preco = float.Parse(atributos[2]);

                ListaProdutos.Add(produtoDaLinha);
            }

            return ListaProdutos;
        }


        // identificar o codigo do produto pra fazer a comparação
        //ao identificar o codigo do produto, necessario identificar a linha daquele codigo
        // 
      
        
        public void delete()
        {
            int codigoProduto = new ProdutoView().RecebeCodigoProduto();
            //var file = new List<string>(System.IO.File.ReadAllLines("C:\\path"));
            List<string> linhas = new List<string>(File.ReadAllLines(caminho));
            int i = 1; // contador de linhas
            bool deletou = false;
            foreach (string line in linhas.ToList())
            {
               ProdutoModel ProdutoCerto = new ProdutoModel();
                string[] vs = line.Split(';');
                ProdutoCerto.codigo = int.Parse(vs[0]);
                if(codigoProduto == ProdutoCerto.codigo)
                {
                    linhas.RemoveAt(i-1);
                    File.WriteAllLines(caminho, linhas.ToArray());
                    deletou = true;
                    //Console.WriteLine("Produto deletado com Sucesso!!");
                }
                i++;
            }
            if (deletou)
            {
                Console.WriteLine("Produto deletado com Sucesso!!");
            }
            else
            {
                Console.WriteLine("Codigo invalido!!");
            }

        }

        public LoginModel Login()
        {
            LoginModel loginModel = new LoginModel {Username = username, Password = password };
            return loginModel;
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void add()
        {
            throw new NotImplementedException();
        }
    }
}
