using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbIzquierda.Checked = true;
        }
        Arbol a = new Arbol();
        Nodo raiz;
        Nodo seleccionado;
        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            raiz = a.insertar(null, int.Parse(textNumero.Text));
            a.mostrar(raiz,treeView1, null);
            treeView1.ExpandAll();
            textNumero.Clear();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccionado = (Nodo)e.Node.Tag;
        }

        private void btnInsertarRamas_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                if (rbIzquierda.Checked)
                    seleccionado.izquierda = a.insertar(seleccionado.izquierda, int.Parse(textNumero.Text));
                if (rbDerecha.Checked)
                    seleccionado.derecha = a.insertar(seleccionado.derecha, int.Parse(textNumero.Text));

                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else MessageBox.Show("Seleccione un número del árbol");
        }
    }
}
