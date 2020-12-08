using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolee 
{
    class Camion : Carro
    {
        protected int asientos;

        public int Asientos
        {
            get { return asientos; }
            set { asientos = value; }
        }
        public Camion() : base()
        {
            asientos = 0;
        }
        public override string ToString()
        {
            return asientos + " " + base.ToString();
        }

    }
}
