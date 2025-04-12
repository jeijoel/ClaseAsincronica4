using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAsincronica4
{
    public partial class ArbolBinarioDeBusqueda
    {
        private NodoArbol<int>? raiz;
        public ArbolBinarioDeBusqueda()
        {
            raiz = null;
        }
        public void Insertar(int valor)
        {
            raiz = InsertarRecursivo(raiz, valor);
        }
        private NodoArbol<int> InsertarRecursivo(NodoArbol<int> raiz, int valor)
        {
            if (raiz == null)
            {
                return new NodoArbol<int>(valor);
            }
            if (valor < raiz.Valor)
            {
                raiz.Izquierda = InsertarRecursivo(raiz.Izquierda, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecha = InsertarRecursivo(raiz.Derecha, valor);
            }
            return raiz;
        }
        public bool Busqueda(int valor)
        {
            return BusquedaRecursiva(raiz, valor);
        }
        private bool BusquedaRecursiva(NodoArbol<int> raiz, int valor)
        {
            if (raiz == null)
            {
                return false;
            }
            if (valor == raiz.Valor)
            {
                return true;
            }
            else if (valor < raiz.Valor)
            {
                return BusquedaRecursiva(raiz.Izquierda, valor);
            }
            else
            {
                return BusquedaRecursiva(raiz.Derecha, valor);
            }
        }
    }
}
