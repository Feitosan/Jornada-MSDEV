using System;

namespace Ex_Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //        2 - CRIAR UMA CLASSE QUE ENVOLVE ALGUM OBJETO QUE VC GOSTE

    //- DEVERA TER 3 PROPRIEDADES
    //- 2 MÉTODOS
    //- DEVERÁ TER HERANÇA E ABSTRAÇÃO.

            Computador pcnovo = new Computador();

            pcnovo.mobo = "B450 Aorus Elite V2";
            

            ComputadorAntigo pcantigo = new ComputadorAntigo();

            pcantigo.ssd = "XPG S41 TUF";
            pcantigo.Ligar();
        }


        class Computador
        {
            public string mobo;
            public string ssd;
            public string cpu;

            private void LigarLuzes()
            {

            }

            private void Overclock()
            {

            }

            public void Ligar()
            {

            }
        }

        class ComputadorAntigo : Computador
        {
            public string hd;
            
        }
    }
}
