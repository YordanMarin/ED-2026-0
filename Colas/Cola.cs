using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    internal class Cola
    {
        Nodo primero = null;
        Nodo ultimo = null;
        int cant = 0;

        public void Enqueue(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            if(primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            cant++;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string Dequeue()
        {
            if (primero != null)
            {
                string nom = primero.Nombre;
                primero = primero.Siguiente;
                cant--;
                return nom;
            }
            return null;
        }

        public string peek()
        {
            if (primero != null)
            {
                return primero.Nombre;
            }
            return null;
        }

        public int count()
        {
            return cant;
        }

        public void clear()
        {
            primero = null;
            ultimo = null;
            cant = 0;
        }
    }
}
