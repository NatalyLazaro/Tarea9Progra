﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest.Clases.listasEnlasadas.ObjListaOrdenada
{
    class ListaOrdenada:lista
    {
        public ListaOrdenada insertaOrden(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (primero == null)
            {
                primero = nuevo;
            }
            else if (entrada.CompareTo(primero.getDato()) < 0)
            {
                nuevo.setEnlace(primero);
                primero = nuevo;
            }
            else
            {
                //busqueda del nodo anterior, a partir de aqui se hara la insercion
                Nodo anterior, p;
                anterior = p = primero;
                while ((p.getEnlace() != null) && (entrada.CompareTo(p.getDato())) > 0)
                {
                    anterior = p;
                    p = p.getEnlace();
                }
                if (entrada.CompareTo(p.getDato()) > 0)
                {
                    anterior = p;
                }
                nuevo.setEnlace(anterior.getEnlace());
                anterior.setEnlace(nuevo);

            }
            return this;

        }
    }
}
