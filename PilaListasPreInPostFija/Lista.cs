using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaListasPreInPostFija
{
    internal class Lista
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(string inf, string pre, string pos)
        {
            Nodo nuevo = new Nodo();
            nuevo.Infija = inf;
            nuevo.Prefija = pre;
            nuevo.Postfija = pos;

            if (primero == null)
            {
                primero = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView list)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Infija);
                item.SubItems.Add(actual.Prefija);
                item.SubItems.Add(actual.Postfija);
                list.Items.Add(item);
                actual = actual.Siguiente;
            }
        }
    }
}
