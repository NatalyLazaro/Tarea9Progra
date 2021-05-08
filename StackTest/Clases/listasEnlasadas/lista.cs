using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest.Clases.listasEnlasadas
{
    class lista
    {
        public Nodo primero;
        public lista()
        {
            primero = null;
        }


        public Nodo buscarPosicion(int posicion)
        {
            Nodo indice;
            int i;
            if (posicion < 0)
            {
                return null;
            }
            indice = primero;
            for (i = 1; (i < posicion) && (indice != null); i++)
            {
                indice = indice.enlace;
            }
            return indice;
        }


        public lista insertarUltimo(Nodo ultimo, object entrada)
        {
            ultimo.enlace = new Nodo(entrada);
            ultimo = ultimo.enlace;
            return this;
        }



        //Este se utiliza
        public lista insertarCabeza(object valor)
        {
            Nodo cabeza = new Nodo(valor);
            if (primero != null)
            {
                cabeza.enlace = primero;
                primero = cabeza;
            }
            else
            {
                primero = cabeza;
            }
            //cabeza = cabeza.enlace;
            return this;
        }




        public Nodo buscarLista(string destino)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.enlace)
            {
                if (destino == indice.dato)
                {
                    return indice;
                }
            }
            return null;
        }

        public void eliminar(object entrada)
        {
            Nodo actual, anterior;
            bool encontrado;
            //inicializa los apuntadores
            actual = primero;
            anterior = null;
            encontrado = false;
            //busqueda del nodo anterior
            while ((actual != null) && (encontrado))
            {
                encontrado = (actual.dato == entrada);
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }
            //enlace del nodo anterior con el siguiente
            if (actual != null)
            {
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null;
            }
        }


        public lista insertarLista(string testigo, string entrada)
        {
            Nodo nuevo, anterior;
            anterior = buscarLista(testigo);
            if (anterior != null)
            {
                nuevo = new Nodo(entrada);
                nuevo.enlace = anterior.enlace;
                anterior.enlace = nuevo;
            }
            return this;
        }

        public void visualizar()
        {
            Nodo n;
            int k = 0;
            n = primero;
            while (n != null)
            {
                Console.Write(n.dato + " ");
                n = n.enlace;
                k++;
                Console.WriteLine(k % 15 != 0 ? " " : "\n");
            }
        }
    }
}
