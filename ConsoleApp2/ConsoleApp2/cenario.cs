using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class cenario
    {

        public String Chao { set; get; }
        public Byte Tamanho{ set; get; }

       public cenario(String chao, Byte tamanho)
        {
            Chao = chao;
            Tamanho = tamanho;
        }

        public void Imprime(caracter c)
        {
            Console.Clear();
            Console.WriteLine();

            //imprimir a primeira linha

            if (c.Pulando)
            {
                for (Byte i=0; i < c.Posicao; i++)
                {
                    Console.Write(" ");

                }

                Console.WriteLine(c.Aparencia);
            }
            else
            {
                Console.WriteLine();

            }

            //imprime segunda linha
            for (Byte i = 0; i < c.Posicao; i++)
            {
                Console.WriteLine(Chao);

            }

            if (c.Pulando)
            {
                Console.Write(Chao);
            }

            else
            {
                Console.Write(c.Aparencia);
            }

            for (Byte I = 0; I < (Tamanho - c.Posicao); I++)
            {
                Console.Write(Chao);

            }
        }
    }
}
