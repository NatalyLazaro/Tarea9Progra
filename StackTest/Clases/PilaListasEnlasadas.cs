using StackTest.Clases.listasEnlasadas;
using StackTest.Clases.listasEnlasadas.ObjListaOrdenada;
using System;

namespace StackTest.Clases
{
    class PilaListasEnlasadas
    {
        private static int Tampila = 49;
        private int cima;
        ListaOrdenada listaOrden;

        public PilaListasEnlasadas()
        {
            cima = -1;
            listaOrden = new ListaOrdenada();
        }

        public void insertar(object elemento)
        {
            cima++;
            listaOrden.insertarCabeza(elemento);
        }

        public object quitar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            aux = listaOrden.buscarPosicion(cima).dato;
            listaOrden.eliminar(cima);
            cima--;
            return aux;
        }

        public object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            return listaOrden.buscarPosicion(cima);
        }


        public bool pilaVacia()
        {
            return cima == -1;
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }
    }
}
