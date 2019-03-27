using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORCA
{
    class Program
    {
        static void Main(string[] args)
        {

            Random sorteio = new Random();
            String[] linhas = File.ReadAllLines("palavras.txt");
            //ELEMENTO NA POSIÇÃO DADA, PEGA O ELEMENTO QUE ESTA NA POSICAO ATUAL
            Char[] palavraoculta = linhas.ElementAt(sorteio.Next(0,linhas.Length)).ToCharArray(); //CONVERTE PARA UM ARRAY DE CARACTERES

            Char[] palavra = new Char[palavraoculta.Length];

            for (Byte I = 0; I < palavra.Length; I++)
            {

                palavra[I] = '_';

            }

            Char letra;
            Byte letrasdapalavra = 0;
            Boolean notificaMudanca = false;
            Byte erros = 0;

            do
            {

                ImprimeJogo(palavra, erros);
                Console.WriteLine("Digite uma letra:");
                letra = (Console.ReadLine())[0];

                for (Byte i = 0; i < palavraoculta.Length; i++)
                {

                    if (palavraoculta[i] == letra)
                    {

                        palavra[i] = letra;
                        letrasdapalavra++;
                        notificaMudanca = true;

                    }
                
                }

                if (!notificaMudanca)
                {
                    erros++;
                }
                else
                {
                    notificaMudanca = false;
                }

            } while (letrasdapalavra < palavraoculta.Length && erros < 6);


            ImprimeJogo(palavra, erros);

            if (letrasdapalavra < palavraoculta.Length)
            {

                //game over
                Console.WriteLine();
                Console.WriteLine("looser!!!");
                Console.WriteLine();
                Console.WriteLine("A palavra era:");
                Console.WriteLine(palavraoculta);


            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Parabéns");

            }
            Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
            Console.ReadKey();

        }

        static void ImprimeJogo(Char[] palavra, Byte erros)
        {

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("### forca ###");
            Console.WriteLine();
            Console.WriteLine("_______ ");
            Console.WriteLine("|     | ");

            //imprime a cabeça

            if (erros > 0)
            {
                Console.WriteLine("|     O ");
            }
            else
            {
                Console.WriteLine("|       ");
            }

            //imprime corpo com braços

            if (erros > 1)
            {
                if (erros > 2)
                {
                    if (erros > 3)
                    {
                        Console.WriteLine(@"|    /|\ ");
                    }
                    else
                    {

                        Console.WriteLine("|    /| ");

                    }
                }
                else
                {
                    Console.WriteLine("|     |");
                    
                }

                Console.WriteLine("|     |");
            }
            else
            {
                Console.WriteLine("|       ");
                Console.WriteLine("|       ");
            }

            //impressao pernas

            if (erros > 4)
            {
                if (erros > 5)
                {
                    Console.WriteLine(@"|    / \");
                }
                else
                {
                    Console.WriteLine("|    /  ");
                }
            }
            else
            {
                Console.WriteLine("|       ");
            }

            Console.WriteLine("|       ");
            Console.WriteLine();
            Console.WriteLine(palavra);
            Console.WriteLine();

        }
    }
}
