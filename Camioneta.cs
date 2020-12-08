using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolee
{
    class Camioneta : Carro
    {
        protected int espacio;

        public int Espacio
        {
            get
            {
                return espacio;
            }
            set
            {
                espacio = value;
            }
        }
            public Camioneta() : base ()
        {
            espacio = 0;
        }
        public override string ToString()
        {
            return espacio + " " + base.ToString();
        }

    }
}
