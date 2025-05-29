using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_ESDAT
{
    internal class ArbolBBP
    {

        public NodoP Raiz;

        public ArbolBBP()
        {
            Raiz = null;
        }
        public void Agrega(Persona persona)
        {
            Raiz = AgregaRec(Raiz, persona);
        }

        private NodoP AgregaRec(NodoP nodo, Persona persona)
        {
            if (nodo == null)
                return new NodoP(persona);

            if (persona.Dni < nodo.Dato.Dni)
                nodo.Izq = AgregaRec(nodo.Izq, persona);
            else
                nodo.Der = AgregaRec(nodo.Der, persona);

            return nodo;
        }

        public void ImprimePre()
        {
            ImprimePre(Raiz);
        }

        private void ImprimePre(NodoP nodo)
        {
            if (nodo == null) return;
            Console.WriteLine(nodo.Dato);
            ImprimePre(nodo.Izq);
            ImprimePre(nodo.Der);
        }

        public int CantidadMayores(int edad)
        {
            return CantidadMayores(Raiz, edad);
        }

        private int CantidadMayores(NodoP nodo, int edad)
        {
            if (nodo == null) return 0;

            int count = nodo.Dato.Edad > edad ? 1 : 0;
            count += CantidadMayores(nodo.Izq, edad);
            count += CantidadMayores(nodo.Der, edad);

            return count;
        }

        public string Antepenultimo()
        {
            List<Persona> personas = new List<Persona>();
            InOrden(Raiz, personas);

            if (personas.Count < 3)
                return "No hay suficientes personas en el árbol.";

            Persona antepenultimo = personas[personas.Count - 3];
            return antepenultimo.ToString();
        }

        private void InOrden(NodoP nodo, List<Persona> lista)
        {
            if (nodo == null) return;
            InOrden(nodo.Izq, lista);
            lista.Add(nodo.Dato);
            InOrden(nodo.Der, lista);
        }
    }

}
