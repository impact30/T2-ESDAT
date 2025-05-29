using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_ESDAT
{
    internal class NodoP
    {
        public Persona Dato { get; set; }
        public NodoP Izq { get; set; }
        public NodoP Der { get; set; }

        public NodoP(Persona dato)
        {
            Dato = dato;
        }

        public NodoP()
        {
        }
    }
}
