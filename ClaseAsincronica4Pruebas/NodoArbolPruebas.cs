using ClaseAsincronica4;
namespace ClaseAsincronica4Pruebas
{
    [TestClass]
    public sealed class NodoArbolPruebas
    {
        [TestMethod]
        public void getValorPruebas()
        {
            // Variables necesarias
            var nodo = new NodoArbol<int>(5);
            // Valor esperado
            var valor = nodo.Valor;
            // Assert
            Assert.AreEqual(5, valor);
        }
        [TestMethod]
        public void setValorPruebas()
        {
            // Variables necesarias
            var nodo = new NodoArbol<int>(5);
            // Valor esperado
            nodo.Valor = 10;
            // Assert
            Assert.AreEqual(10, nodo.Valor);
        }
        [TestMethod]
        public void getIzquierdaPruebas()
        {
            // Variables necesarias
            var nodo = new NodoArbol<int>(5);
            // Valor esperado
            var izquierda = nodo.Izquierda;
            // Assert
            Assert.IsNull(izquierda);
        }
        [TestMethod]
        public void setIzquierdaPruebas()
        {
            // Variables necesarias
            var nodo = new NodoArbol<int>(5);
            // Valor esperado
            nodo.Izquierda = new NodoArbol<int>(3);
            // Assert
            Assert.IsNotNull(nodo.Izquierda);
            Assert.AreEqual(3, nodo.Izquierda.Valor);
        }
        [TestMethod]
        public void getDerechaPruebas()
        {
            // Variables necesarias
            var nodo = new NodoArbol<int>(5);
            // Valor esperado
            var derecha = nodo.Derecha;
            // Assert
            Assert.IsNull(derecha);
        }
        [TestMethod]
        public void setDerechaPruebas()
        {
            // Variables necesarias
            var nodo = new NodoArbol<int>(5);
            // Valor esperado
            nodo.Derecha = new NodoArbol<int>(7);
            // Assert
            Assert.IsNotNull(nodo.Derecha);
            Assert.AreEqual(7, nodo.Derecha.Valor);
        }
        [TestMethod]
        public void constructorPruebas()
        {
            // Variables necesarias
            var nodo = new NodoArbol<int>(5);
            // Valor esperado
            Assert.AreEqual(5, nodo.Valor);
            Assert.IsNull(nodo.Izquierda);
            Assert.IsNull(nodo.Derecha);
        }
    }
}
