namespace ClaseAsincronica4Pruebas;
using ClaseAsincronica4;

[TestClass]
public class ArbolBinarioDeBusquedaPruebas
{
    [TestMethod]
    public void ConstructorArbolBinarioDeBusquedaPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        var raiz = arbol.raiz;
        // Assert
        Assert.IsNull(raiz);
    }
    [TestMethod]
    public void InsertarPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        // Assert
        Assert.IsTrue(arbol.Busqueda(5));
        Assert.IsTrue(arbol.Busqueda(3));
        Assert.IsTrue(arbol.Busqueda(7));
    }
    [TestMethod]
    public void BusquedaPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        // Assert
        Assert.IsTrue(arbol.Busqueda(5));
        Assert.IsTrue(arbol.Busqueda(3));
        Assert.IsTrue(arbol.Busqueda(7));
        Assert.IsFalse(arbol.Busqueda(10));
    }
    [TestMethod]
    public void EliminarPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Eliminar(3);
        // Assert
        Assert.IsFalse(arbol.Busqueda(3));
    }
    [TestMethod]
    public void EliminarRaizPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarHojaPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Eliminar(7);
        // Assert
        Assert.IsFalse(arbol.Busqueda(7));
    }
    [TestMethod]
    public void EliminarNodoConUnHijoPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Insertar(6);
        arbol.Eliminar(7);
        // Assert
        Assert.IsFalse(arbol.Busqueda(7));
    }
    [TestMethod]
    public void EliminarNodoConDosHijosPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Insertar(6);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYUnHijoPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYDosHijosPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYHojaPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYHojaDerechaPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYHojaIzquierdaPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYHojaDerechaYIzquierdaPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYHojaDerechaYIzquierdaYUnHijoPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void EliminarNodoConRaizYHojaDerechaYIzquierdaYDosHijosPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        // Valor esperado
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Eliminar(5);
        // Assert
        Assert.IsFalse(arbol.Busqueda(5));
    }
    [TestMethod]
    public void InOrderPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Insertar(6);
        arbol.Insertar(8);

        // Valor esperado
        arbol.InOrder();
        string valor = arbol.recorridoInOrder;
        // Assert
        Assert.AreEqual("3 5 6 7 8 ", valor);
    }
    [TestMethod]
    public void PreOrderPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Insertar(6);
        arbol.Insertar(8);
        // Valor esperado
        arbol.PreOrder();
        string valor = arbol.recorridoPreOrder;
        // Assert
        Assert.AreEqual("5 3 7 6 8 ", valor);
    }
    [TestMethod]
    public void PostOrderPruebas()
    {
        // Variables necesarias
        var arbol = new ArbolBinarioDeBusqueda();
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Insertar(6);
        arbol.Insertar(8);
        // Valor esperado
        arbol.PostOrder();
        string valor = arbol.recorridoPostOrder;
        // Assert
        Assert.AreEqual("3 6 8 7 5 ", valor);
    }
}
