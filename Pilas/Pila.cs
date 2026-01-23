using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    internal class Pila
    {
        private Nodo cima = null;
        int cant = 0;

        public void push(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            nuevo.Siguiente = cima;
            cima = nuevo;
            cant++;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = cima;

            while (actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string pop()
        {
            if(cima != null)
            {
                string nom = cima.Nombre;
                cima = cima.Siguiente;
                cant--;
                return nom;
            }
            return null;
        }

        public string peek()
        {
            if (cima != null)
            {
                return cima.Nombre;
            }
            return null;
        }

        public int count()
        {
            return cant;
        }

        public void clear()
        {
            cima = null;
            cant = 0;
        }

    }
}
