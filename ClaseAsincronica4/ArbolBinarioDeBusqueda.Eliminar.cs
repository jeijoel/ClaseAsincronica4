using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAsincronica4
{
    public partial class ArbolBinarioDeBusqueda
    {
        public void Eliminar(int valor)
        {
            raiz = eliminarRecursivo(raiz, valor);
        }
        private NodoArbol<int> eliminarRecursivo(NodoArbol<int> raiz, int valor)
        {
            if (raiz == null)
            {
                return raiz;
            }
            if (valor < raiz.Valor)
            {
                raiz.Izquierda = eliminarRecursivo(raiz.Izquierda, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecha = eliminarRecursivo(raiz.Derecha, valor);
            }
            else
            {
                // Se encontró el nodo a eliminar
                if (raiz.Izquierda == null)
                {
                    return raiz.Derecha;
                }
                else if (raiz.Derecha == null)
                {
                    return raiz.Izquierda;
                }
                // Nodo con dos hijos: obtener el sucesor inorden
                raiz.Valor = ObtenerMinimo(raiz.Derecha).Valor;
                raiz.Derecha = eliminarRecursivo(raiz.Derecha, raiz.Valor);
            }
            return raiz;
        }
        private NodoArbol<int> ObtenerMinimo(NodoArbol<int> raiz)
        {
            int minimo = raiz.Valor;
            while (raiz.Izquierda != null)
            {
                minimo = raiz.Izquierda.Valor;
                raiz = raiz.Izquierda;
            }
            return raiz;
        }
    }
}
