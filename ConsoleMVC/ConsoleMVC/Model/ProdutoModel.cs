using ConsoleMVC.Interface;
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



      

        public int delete(int codigo)
        {
            return codigo;
        }

        public LoginModel Login()
        {
            LoginModel loginModel = new LoginModel {Username = username, Password = password };
            return loginModel;
        }

    }
}
