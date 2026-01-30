using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    internal class Arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null) // insertando raiz
            {
                return nuevo;
            }else if ((actual.izquierda != null || actual.derecha == null) & (actual.izquierda == null || actual.derecha != null))
            {
                MessageBox.Show("Nodo ocupado");
            }else if(actual.izquierda == null)
            {
                actual.izquierda = nuevo;
            }else
            {
                actual.derecha = nuevo;
            }
            return actual;
        }

        public void mostrar(Nodo actual, TreeView t, TreeNode tallo)
        {
            if (actual == null) return;

            TreeNode r = new TreeNode(actual.numero.ToString()); //raiz
            r.Tag = actual;

            if(tallo == null) t.Nodes.Add(r); //tallo
            else tallo.Nodes.Add(r); //hojas

            if(actual.izquierda != null) mostrar(actual.izquierda, t, r);
            if (actual.derecha != null) mostrar(actual.derecha, t, r);
        }
    }
}
