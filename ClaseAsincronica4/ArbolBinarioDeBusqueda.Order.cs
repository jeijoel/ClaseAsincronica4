using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAsincronica4
{
    public partial class ArbolBinarioDeBusqueda
    {
        internal string recorridoInOrder = "";
        internal string recorridoPreOrder = "";
        internal string recorridoPostOrder = "";
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
                recorridoInOrder += raiz.Valor + " ";
                InOrderRecursivo(raiz.Derecha);
            }
        }
        public void PreOrder()
        {
            PreOrderRecursivo(raiz);
        }
        private void PreOrderRecursivo(NodoArbol<int>? raiz)
        {
            if (raiz != null)
            {
                Console.Write(raiz.Valor + " ");
                recorridoPreOrder += raiz.Valor + " ";
                PreOrderRecursivo(raiz.Izquierda);
                PreOrderRecursivo(raiz.Derecha);
            }
        }
        public void PostOrder()
        {
            PostOrderRecursivo(raiz);
        }
        private void PostOrderRecursivo(NodoArbol<int>? raiz)
        {
            if (raiz != null)
            {
                PostOrderRecursivo(raiz.Izquierda);
                PostOrderRecursivo(raiz.Derecha);
                Console.Write(raiz.Valor + " ");
                recorridoPostOrder += raiz.Valor + " ";
            }
        }
    }
}
