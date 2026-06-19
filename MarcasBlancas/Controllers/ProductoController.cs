using Microsoft.AspNetCore.Mvc;
using MarcasBlancas.Models;
using System.Collections.Generic;

namespace MarcasBlancas.Controllers;

public class ProductoController : Controller
{
    public IActionResult Index()
    {
        var productos = new List<Producto>
        {
            new Producto 
            { 
                Id = 1, 
                Nombre = "Agua Mineral sin Gas 2L", 
                Marca = "Bells", 
                Categoria = "Bebidas", 
                Precio = 1.50m, 
                EsMarcaBlanca = true 
            },
            new Producto 
            { 
                Id = 2, 
                Nombre = "Yogurt Natural 1kg", 
                Marca = "Metro", 
                Categoria = "Lácteos", 
                Precio = 5.80m, 
                EsMarcaBlanca = true 
            },
            new Producto 
            { 
                Id = 3, 
                Nombre = "Flan de Vainilla 120g", 
                Marca = "Precio Uno", 
                Categoria = "Postres", 
                Precio = 1.80m, 
                EsMarcaBlanca = true 
            },
            new Producto 
            { 
                Id = 4, 
                Nombre = "Pilas Alcalinas AA x4", 
                Marca = "Tottus", 
                Categoria = "Electrónica", 
                Precio = 7.50m, 
                EsMarcaBlanca = true 
            },
            new Producto 
            { 
                Id = 5, 
                Nombre = "Fideos Spaghetti 450g", 
                Marca = "Don Vittorio", 
                Categoria = "Alimentación", 
                Precio = 4.20m, 
                EsMarcaBlanca = false 
            }
        };

        return View(productos);
    }
}
