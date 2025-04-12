using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAsincronica4
{
    public partial class ArbolBinarioDeBusqueda
    {
        public void InOrder()
        {
            InOrderRecursivo(raiz);
        }
        private void InOrderRecursivo(NodoArbol<int>? raiz)
        {
            if (raiz != null)
            {
                InOrderRecursivo(raiz.Izquierda);
                Console.Write(raiz.Valor + " ");
                InOrderRecursivo(raiz.Derecha);
            }
        }
        public void preOrder()
        {
            preOrderRecursivo(raiz);
        }
        private void preOrderRecursivo(NodoArbol<int>? raiz)
        {
            if (raiz != null)
            {
                Console.Write(raiz.Valor + " ");
                preOrderRecursivo(raiz.Izquierda);
                preOrderRecursivo(raiz.Derecha);
            }
        }
        public void postOrder()
        {
            postOrderRecursivo(raiz);
        }
        private void postOrderRecursivo(NodoArbol<int>? raiz)
        {
            if (raiz != null)
            {
                postOrderRecursivo(raiz.Izquierda);
                postOrderRecursivo(raiz.Derecha);
                Console.Write(raiz.Valor + " ");
            }
        }
    }
}
