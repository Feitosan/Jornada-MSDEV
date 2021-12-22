using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal interface Interface1
    {
        // contrato com os metodos que precisam estar dentro da classe elevador.cs

        public void entrar(int capacidadeElevador, int pessoasNoElevador, int andarAtual);
        public void sair(int pessoasNoElevador, int andarAtual);
        public void subir(int capacidadeElevador, int pessoasNoElevador, int andarAtual, int andaresPredio);
        public void descer(int capacidadeElevador, int pessoasNoElevador, int andarAtual, int andaresPredio);
    }
}
