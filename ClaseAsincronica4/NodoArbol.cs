using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAsincronica4
{
    internal class NodoArbol<Tipo>
    {
        public Tipo Valor { get; set; }
        public NodoArbol<Tipo>? Izquierda { get; set; }
        public NodoArbol<Tipo>? Derecha { get; set; }
        public NodoArbol(Tipo valor)
        {
            Valor = valor;
            Izquierda = null;
            Derecha = null;
        }
    }
}
