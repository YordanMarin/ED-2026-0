using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaListasPreInPostFija
{
    internal class Conversor
    {
        Pila p = new Pila();

        public int obtenerPrioridad(string operador)
        {
            if (operador == "*" || operador == "/") return 2;
            if (operador == "+" || operador == "-") return 1;
            return 0;
        }

        public bool esOperador(string c)
        {
            return c == "*" || c == "/" || c == "+" || c == "-";
        }

        public string InfijaPrefija(string infija)
        {
            StringBuilder prefija = new StringBuilder();

            for (int i = infija.Length - 1; i >= 0; i--)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    prefija.Insert(0, c);
                }
                else if (c == ")")
                {
                    p.push(c);
                }
                else if (esOperador(c))
                {
                    while (!p.estavacia() & obtenerPrioridad(p.peek()) > obtenerPrioridad(c))
                    {
                        prefija.Insert(0, p.pop());
                    }
                    p.push(c);
                }else if (c == "(")
                {
                    while (!p.estavacia() & p.peek() != ")")
                    {
                        prefija.Insert(0, p.pop());
                    }
                    p.pop();
                }
            }

            while (!p.estavacia())
            {
                prefija.Insert(0, p.pop());
            }

            return prefija.ToString();
        }

        public string InfijaPostfija(string infija)
        {
            StringBuilder postfija = new StringBuilder();

            for (int i = 0;i<infija.Length; i++)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    postfija.Append(c);
                }
                else if (c == "(")
                {
                    p.push(c);
                }
                else if (esOperador(c))
                {
                    while (!p.estavacia() & obtenerPrioridad(p.peek()) > obtenerPrioridad(c))
                    {
                        postfija.Append(p.pop());
                    }
                    p.push(c);
                }
                else if (c == ")")
                {
                    while (!p.estavacia() & p.peek() != "(")
                    {
                        postfija.Append(p.pop());
                    }
                    p.pop();
                }
            }
            while (!p.estavacia())
            {
                postfija.Append(p.pop());
            }
            return postfija.ToString();
        }
    }
}
