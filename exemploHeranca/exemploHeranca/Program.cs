using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            carro gol = new carro();

            gol.Marca = "Volkswagen";
            gol.acelera();

        }
    }
}
