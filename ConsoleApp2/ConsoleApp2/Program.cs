using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria instancia da classe caracter - objeto
            
            caracter player = new caracter("<", ">");
            cenario cenario = new cenario("_", 60);
            cenario.Imprime(player);
            Console.ReadKey();

            //Byte num = 4;
           // player.confPosicao(num);
          //  Byte p = player.Posicao;
       
          //  player.anda();
        }
    }
}
