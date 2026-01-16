using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazadaDobleAnalisis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista l = new Lista();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textNombre.Text))
            {
                if (byte.TryParse(textEdad.Text, out byte ed) && ed >=10 && ed <= 130)
                {
                    listView1.Items.Clear();
                    l.insertar(textNombre.Text, ed);
                    l.mostrar(listView1);
                    textNombre.Clear();
                    textEdad.Clear();
                }
                else MessageBox.Show("Solo permitene edades entre 10 - 130");
            }
            else MessageBox.Show("No se permiten nombres nulos");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textNombre.Text))
            {
                Nodo buscar = l.buscar(textNombre.Text);
                if (buscar != null)
                {
                    MessageBox.Show($"Nombre:{buscar.Nombre} \nEdad: {buscar.Edad}");
                }
                else MessageBox.Show("No existe el estudiante");
            }
            else MessageBox.Show("No se permiten buscar nombres nulos");
        }
    }
}
