using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazadaDoble
{
    internal class Lista
    {
        private Nodo primero;
        private Nodo ultimo;

        public void insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if(primero == null)
            {
                primero = nuevo;
                primero.Anterior = null;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while( actual != null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }

        public void eliminar(int num)
        {
            Nodo actual = primero;

            while( actual != null)
            {
                if( actual.Numero == num)
                {
                    if(actual == primero)
                    {
                        primero = primero.Siguiente;
                        if(primero != null)
                            primero.Anterior = null;
                    }else if(actual == ultimo)
                    {
                        ultimo = ultimo.Anterior;
                        if(ultimo != null)
                            ultimo.Siguiente = null;
                    }
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = actual.Anterior;
                    }
                    return;
                }
                actual = actual.Siguiente;
            }
        }

        
    }
}
