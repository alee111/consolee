using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolee
{
    public class Carro 
    {
        protected int modelo;

        public int Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public Carro()
        {
            modelo = 0;
        }
        public override string ToString()
        {
            return modelo + "";
        }
            public int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

   }
}
