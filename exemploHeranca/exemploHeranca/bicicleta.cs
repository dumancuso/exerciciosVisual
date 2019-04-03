using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca
{
    class bicicleta : veiculo
    {
        public Boolean Garupa { get; set; }
        public Boolean Sinalizador { get; set; }

        public bicicleta()
        {
            
        }

        public void Empinar() { }

        public override void freia()
        {
            throw new NotImplementedException();
            //colocando chinelo no pneu
        }

        public override void acelera()
        {
            throw new NotImplementedException();
            //pedalando mais forte
        }

        public override void TrocaMarcha()
        {
            throw new NotImplementedException();
            // usando cambio
        }
    }
}
