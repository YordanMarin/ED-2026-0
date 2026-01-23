using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazadaDobleAnalisis
{
    internal class Lista
    {
        private Nodo primero;
        private Nodo ultimo;

        public void insertar(string nom, byte ed)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;
            nuevo.Edad = ed;

            if (primero == null)
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
        public void mostrar(ListView list)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Nombre);
                item.SubItems.Add(actual.Edad.ToString());
                list.Items.Add(item);
                actual = actual.Siguiente;
            }
        }

        public Nodo buscar(string nom)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                if (actual.Nombre == nom)
                    return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        public void modificar(string actualNom, string nuevoNom, byte nuevaEd)
        {
            Nodo modi = buscar(actualNom);

            if (modi != null)
            {
                modi.Nombre = nuevoNom;
                modi.Edad = nuevaEd;
            }
        }

        public void eliminar(string nom)
        {
            Nodo eli = buscar(nom);

            if(eli != null)
            {
                if (eli == primero)
                {
                    primero = primero.Siguiente;
                    if (primero != null)
                        primero.Anterior = null;
                }
                else if (eli == ultimo)
                {
                    ultimo = ultimo.Anterior;
                    if (ultimo != null)
                        ultimo.Siguiente = null;
                }
                else
                {
                    eli.Anterior.Siguiente = eli.Siguiente;
                    eli.Siguiente.Anterior = eli.Anterior;
                }
            }
        }
    }
}
