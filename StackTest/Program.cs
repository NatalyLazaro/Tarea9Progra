using StackTest.Clases;
using StackTest.Clases.listasEnlasadas.ObjListaOrdenada;
using System;
using System.IO;

namespace StackTest
{
    class Program
    {

        static void ejemploPilaLineal()
        {
            PilaLineal pila;
            int x;
            int Clave = -1;
            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pila = new PilaLineal();//crea la pila
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pila.insertar(x);
                    }
                } while (x != Clave);

                Console.WriteLine("Estos son los elementos de la pila:");
                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }

            } catch (Exception error)
            {
                Console.WriteLine("Error=" + error.Message);
            }
        }

        static void palindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal, cadena;

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es Palindromo");
                cadena = Console.ReadLine();
                //Para quitar espacios
                pal = cadena.Replace(" ", String.Empty);
                //creamos la pila con los chars
                for (int i = 0; i < pal.Length;)
                {
                    Char c;
                    c = pal[i++];
                    pilaChar.insertar(c);
                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c; //evalua si la pos es igual 
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }


        }

        static void EjemploPilaLista()
        {
            PilaListasEnlasadas pl = new PilaListasEnlasadas();
            pl.insertar(1);
            pl.insertar(15);
            pl.insertar(3);
            pl.insertar(4);
            pl.insertar(5);

            //pl.quitar();
            int pau;
            pau = 0;
        }

        static void EjemploListaEnlasada()
        {
            ListaOrdenada listEjemplo = new ListaOrdenada();
            PilaLista pl = new PilaLista();
            listEjemplo.insertarCabeza("A");
            listEjemplo.insertarCabeza("R");
            listEjemplo.insertarCabeza("R");
            listEjemplo.insertarCabeza("O");
            listEjemplo.insertarCabeza("Z");
            while (listEjemplo.primero != null)
            {
                pl.insertar(listEjemplo.primero.dato.ToString());
                listEjemplo.primero = listEjemplo.primero.enlace;
                Console.WriteLine(pl.quitar());
            }
        }

        static void EjemploMatematico()
        {
            PilaLista pl = new PilaLista();
            string cadena, ite;
            int aux = 0, resul = 0, mult = 0, div = 0, h;
            do
            {
                Console.WriteLine("Ingrese expresión matemática");
                cadena = Console.ReadLine();

                for (int i = 0; i < cadena.Length; i++)
                {
                    ite = cadena[i].ToString();
                    pl.insertar(ite);
                }
                for (int a = 0; a < cadena.Length; a++)
                {
                    ite = pl.quitar().ToString();
                    if (ite.Equals("+"))
                    {
                        resul += aux;
                    }
                    else if (ite.Equals("-"))
                    {
                        resul -= aux;
                    }
                    else if (ite.Equals("*"))
                    {
                        mult = aux * (int.Parse(pl.quitar().ToString()));
                        aux = 0;
                        a++;
                    }
                    else if (ite.Equals("/"))
                    {
                        div = aux * (int.Parse(pl.quitar().ToString()));
                        aux = 0;
                        a++;
                    }
                    else
                    {
                        aux = int.Parse(ite);
                    }
                    resul += mult;
                    resul += div;
                    mult = 0;
                    div = 0;

                }
                Console.WriteLine("Resultado: {0}", resul);
                Console.WriteLine("Si desea Continuar presione 1");
                h = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (h == 1);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            ///EjemploMatematico();
            //EjemploListaEnlasada();
            //EjemploPilaLista();
            //palindromo();
            //ejemploPilaLineal();

        }
    }
}
