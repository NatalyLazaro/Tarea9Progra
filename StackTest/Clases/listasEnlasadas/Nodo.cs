using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest.Clases.listasEnlasadas
{
    class Nodo
    {
        public object dato;
        public Nodo enlace;

        public Nodo(object x)
        {
            dato = x;
            enlace = null;
        }

        public Nodo(object x, Nodo n)
        {
            dato = x;
            enlace = n;
        }

        public object getDato()
        {
            return dato;
        }
        public Nodo getEnlace()
        {
            return enlace;
        }

        public void setEnlace(Nodo Enlace)
        {
            this.enlace = Enlace;
        }
    }
}
