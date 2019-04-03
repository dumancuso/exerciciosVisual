using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca
{
    class carro : veiculo
    {
        public Byte Portas { get; set; }
        public String Combustivel { get; set; }
        


        //construtor
        public carro() { }

        //metodos

        public void DarSeta() { }

        public override void freia()
        {
            throw new NotImplementedException();
            //pisa no freio
        }

        public override void acelera()
        {
            throw new NotImplementedException();
            //pisa no acelerador e troca as marchas
        }

        public override void TrocaMarcha()
        {
            throw new NotImplementedException();
            //pisa na embreagem e troca a marcha usando cambio
        }
    }
}
