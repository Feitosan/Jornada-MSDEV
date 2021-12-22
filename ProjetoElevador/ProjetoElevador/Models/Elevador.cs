using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class Elevador : Interface1
    {
        // variaveis que armazena as informaçoes tecnicas do elevador.
        public int andarAtual = 1;
        public int terreo = 0;
        public int andaresPredio = 0;
        public int capacidadeElevador = 0;
        public int pessoasNoElevador = 0;

        // recebe as primeiras informaçoes do usuario, definindo os andares do predio e a capacidade de pessoas no elevador.
        public void inicializar(int andaresPredio, int andarAtual, int pessoasNoElevador, int capacidadeElevador)
        {
            Console.WriteLine("Informe o numero de andares do Prédio(Desconsiderando o Térreo) ");
            this.andaresPredio = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a capacidade maxima do elevador:  ");
            this.capacidadeElevador = int.Parse(Console.ReadLine());

            Console.WriteLine($"O elevador está no andar {this.terreo} e tem {this.pessoasNoElevador} Pessoas no elevador.");
        }
        // faz com que o elevador desça um andar e não desce caso o andarAtual for igual a 0.
        public void descer(int capacidadeElevador, int pessoasNoElevador, int andarAtual, int andaresPredio)
        {
            if (this.andarAtual == 0)
            {
                Console.WriteLine($"O elevador está no Térreo e tem {this.pessoasNoElevador} Pessoas no elevador.");
                return;
            }
            else
            {
                this.andarAtual -= 1;
                Console.WriteLine($"Voce esta no andar {this.andarAtual} e tem {this.pessoasNoElevador} Pessoas no elevador.");
                return;
            }
        }

        // sobe um andar, até o ultimo andar informado pelo usuario e caso o elevador ja esteja no ultimo andar, ele mostra que o elevador
        // esta no ultimo andar.
        public void subir(int capacidadeElevador, int pessoasNoElevador, int andarAtual, int andaresPredio)
        {
            if (this.andarAtual == this.andaresPredio)
            {
                Console.WriteLine($"O elevador está no ultimo andar e tem {this.pessoasNoElevador} Pessoas.");
                return;
            }
            else if (this.andarAtual < this.andaresPredio)
            {
                this.andarAtual += 1;
                Console.WriteLine($"Voce esta no andar {this.andarAtual} e tem {this.pessoasNoElevador} Pessoas no elevador.");
                return;
            }

        }
        // adiciona uma pessoa ao elevador e mostra quando o elevador estiver me sua capacidade maxima.
        public void entrar(int capacidadeElevador, int pessoasNoElevador, int andarAtual)
        {

            if (this.pessoasNoElevador >= this.capacidadeElevador)
            {
                Console.WriteLine($"Voce esta no andar {this.andarAtual} e a capacidade maxima do elevador é {this.capacidadeElevador} Pessoas.");
                return;
            }
            else
            {
                this.pessoasNoElevador++;
                Console.WriteLine($"Voce esta no andar {this.andarAtual} e tem {this.pessoasNoElevador} Pessoas no elevador.");
                return;
            }
        }
        // retira uma pessoa do elevador, se chegar a 0 pessoas no elevador ele mostra que o elevador esta vazio.
        public void sair(int pessoasNoElevador, int andarAtual)
        {
            if (this.pessoasNoElevador == 0)
            {
                Console.WriteLine($"O elevador esta no andar {this.andarAtual} e esta vazio.");
                return;
            }
            else
            {
                this.pessoasNoElevador -= 1;
                Console.WriteLine($"Voce esta no andar {this.andarAtual} e tem {this.pessoasNoElevador} Pessoas no elevador.");
                return;
            }
        }


    }
}
