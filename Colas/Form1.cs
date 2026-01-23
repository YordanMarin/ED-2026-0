using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola c = new Cola();
        private void btnEncolar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            c.Enqueue(textNombre.Text);
            c.mostrar(listBox1);
            textNombre.Clear();
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            string nom = c.Dequeue();

            if (nom != null)
            {
                MessageBox.Show($"Nombre: {nom} desencolado correctamente");
                listBox1.Items.Clear();
                c.mostrar(listBox1);
            }
            else MessageBox.Show("Cola vacia");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = c.peek();

            if (nom != null)
            {
                MessageBox.Show($"Primero: {nom}");
            }
            else MessageBox.Show("Cola vacia");
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: "+ c.count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c.clear();
            listBox1.Items.Clear();
            MessageBox.Show("Datos eliminados correctamente.");
        }
    }
}
