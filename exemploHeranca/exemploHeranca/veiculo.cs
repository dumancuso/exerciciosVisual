using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca
{
    abstract class veiculo
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public Int16 Ano { get; set; }
        public Byte Marchas { get; set; }

        public veiculo() { }

            abstract public void freia() { }
            abstract public void acelera() { }
            abstract public void TrocaMarcha() { }
        

    }
}
