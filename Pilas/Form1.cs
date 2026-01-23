using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pila p = new Pila();
        private void btnApilar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            p.push(textNombre.Text);
            p.mostrar(listBox1);
            textNombre.Clear();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            string nom = p.pop();
            if (nom != null)
            {
                MessageBox.Show($"Nombre: {nom}- desapilado correctamente");
                listBox1.Items.Clear();
                p.mostrar(listBox1);
            }
            else MessageBox.Show("Pila vacia!");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = p.peek();
            if (nom != null)
            {
                MessageBox.Show($"Cima: {nom}");
            }
            else
            {
                MessageBox.Show("Pila vacia!");
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: "+p.count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p.clear();
            listBox1.Items.Clear();
            MessageBox.Show("Se eliminaron todos los datos de la pila");
        }
    }
}
