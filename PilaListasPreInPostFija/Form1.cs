using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaListasPreInPostFija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista l = new Lista();
        Conversor c = new Conversor();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            l.insertar(textInfija.Text, c.InfijaPrefija(textInfija.Text), c.InfijaPostfija(textInfija.Text));
            l.mostrar(listView1);
            textInfija.Clear();
        }
    }
}
