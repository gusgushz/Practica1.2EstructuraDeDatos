using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._2.Entities
{
    internal class Producto
    {
        Random ram = new Random();
        public Producto() 
        {
            Id = ram.Next(1, 11);
            Precio = ram.Next(50,100);
            Cantidad = ram.Next(1, 50);
            Nombre = "Producto "+Id.ToString();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
/*
Productos disponibles y retirados. Un supermercado nos pide que hagamos una pequeña aplicación que almacene 
los productos pasados por el escáner. La aplicación debe almacenar Productos (clase), cada producto al crearse 
contiene una cantidad, un precio (estos dos generados aleatoriamente). El nombre del producto será básico (producto1, 
producto2, producto3, etc.), se solicita de igual forma que la misma aplicación permita retirar elementos del mismo 
almacén de productos al igual que mostrar la cantidad de productos disponibles y retirados (Para resolver este problema 
utiliza una lista).   
 */