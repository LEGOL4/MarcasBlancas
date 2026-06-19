using Xunit;
using MarcasBlancas.Models;

namespace MarcasBlancas.Tests;

public class ProductoTests
{
    [Fact]
    public void Test_Producto_EsMarcaBlanca_True()
    {
        // Arrange & Act
        var producto = new Producto { EsMarcaBlanca = true };

        // Assert
        Assert.True(producto.EsMarcaBlanca);
    }

    [Fact]
    public void Test_Producto_Precio_MenorQue_10()
    {
        // Arrange & Act
        var producto = new Producto { Precio = 5.50m };

        // Assert
        Assert.True(producto.Precio < 10);
    }

    [Fact]
    public void Test_Producto_Nombre_NoEsVacio()
    {
        // Arrange & Act
        var producto = new Producto { Nombre = "Leche Metro" };

        // Assert
        Assert.False(string.IsNullOrEmpty(producto.Nombre));
    }
}
