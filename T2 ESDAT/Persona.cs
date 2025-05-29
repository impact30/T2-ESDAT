using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T2_ESDAT
{
    internal class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona(int dni)
        {
            Dni = dni;
        }
        public Persona() { }
    }
}
