using ConsoleMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.View
{
    internal class ProdutoView
    {
        public void Listar(List<ProdutoModel> listaProdutos)
        {
            Console.WriteLine("Serviços\n");
            foreach (ProdutoModel item in listaProdutos)
            {
                if(item.codigo == 8)
                {
                    
                    Console.WriteLine("Produtos\n");
                }
                else if(item.codigo == 13)
                {
                    
                    Console.WriteLine("Bebidas\n");
                }
                Console.WriteLine($"Codigo do Produto:{item.codigo}");
                Console.WriteLine($"Nome do Produto: {item.nome}");
                Console.WriteLine($"Preço do Produto: {item.preco}");
                Console.WriteLine("---------------------------------");
            }
        }

      
        public bool Logincerto(LoginModel ret)
        {
            string[] logins = new string[2];
            Console.WriteLine("Informe Seu Login: ");
            logins[0] = Console.ReadLine();
            Console.WriteLine("Informe Sua Senha: ");
            logins[1] = Console.ReadLine();

            if (logins[0] == ret.Username && logins[1] == ret.Password)
            {
                Console.WriteLine("\nBem Vindo ao Sistema!!");
                return true;
            }
            else
            {
                Console.WriteLine("\nLogin ou Senha Incorretos!!");
                return false;
            }
            
        }

        public void deletaCodigo(int codigo)
        {
            int codProduto;
            Console.WriteLine("Digite o codigo do produto a ser deletado: ");
            codProduto = int.Parse(Console.ReadLine());


        }
    }
}
