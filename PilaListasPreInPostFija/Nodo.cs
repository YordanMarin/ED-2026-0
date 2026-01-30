using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaListasPreInPostFija
{
    internal class Nodo
    {
        private string nombre;

        private string infija;
        private string prefija;
        private string postfija;

        private Nodo siguiente;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Infija { get => infija; set => infija = value; }
        public string Prefija { get => prefija; set => prefija = value; }
        public string Postfija { get => postfija; set => postfija = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
