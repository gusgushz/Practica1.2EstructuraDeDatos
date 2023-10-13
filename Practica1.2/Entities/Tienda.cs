using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._2.Entities
{
    internal class Tienda
    {
        public List<Producto> ProductosDisponibles = new();
        public List<Producto> ProductosRetirados = new();
        public void AgregarProducto()
        {
            Producto nuevo = new();
            Producto productoEncontrado = ProductosDisponibles.Find(x => x.Id == nuevo.Id)!;
            if (productoEncontrado == null)
            {
                ProductosDisponibles.Add(nuevo);
            }
            else
            {
                int index = ProductosDisponibles.FindIndex(x => x.Id == nuevo.Id);
                ProductosDisponibles[index].Cantidad++;
            }
        }
        public void QuitarProducto(int id)
        {
            Producto productoEncontrado = ProductosDisponibles.Find(x => x.Id == id)!;
            if (productoEncontrado == null)
            {
                //no encontro producto
            }
            else
            {
                int index = ProductosRetirados.FindIndex(p => p.Id == id);

                if (index != -1)
                {
                    ProductosRetirados[index].Cantidad++;

                    int i = ProductosDisponibles.FindIndex(x => x.Id == id);
                    ProductosDisponibles[i].Cantidad--;
                    if (ProductosDisponibles[i].Cantidad == 0)
                    {
                        ProductosDisponibles.RemoveAt(i);
                    }
                }
                else
                {
                    Producto copiaProducto = new Producto
                    {
                        Id = productoEncontrado.Id,
                        Nombre = productoEncontrado.Nombre,
                        Precio = productoEncontrado.Precio,
                        Cantidad = 1
                    };

                    ProductosRetirados.Add(copiaProducto);

                    int i = ProductosDisponibles.FindIndex(x => x.Id == id);
                    ProductosDisponibles[i].Cantidad--;

                }
            }
        }
        public void QuitarProducto(int id, int cantidad)
        {
            Producto productoEncontrado = ProductosDisponibles.Find(x => x.Id == id)!;
            if (productoEncontrado == null)
            {
                //no encontro producto
            }
            else
            {
                int index = ProductosRetirados.FindIndex(p => p.Id == id);

                if (index != -1)
                {
                    ProductosRetirados[index].Cantidad += cantidad;

                    int i = ProductosDisponibles.FindIndex(x => x.Id == id);
                    ProductosDisponibles[i].Cantidad -= cantidad;
                    if (ProductosDisponibles[i].Cantidad == 0)
                    {
                        ProductosDisponibles.RemoveAt(i);
                    }
                }
                else
                {
                    Producto copiaProducto = new Producto
                    {
                        Id = productoEncontrado.Id,
                        Nombre = productoEncontrado.Nombre,
                        Precio = productoEncontrado.Precio,
                        Cantidad = cantidad
                    };

                    ProductosRetirados.Add(copiaProducto);

                    int i = ProductosDisponibles.FindIndex(x => x.Id == id);
                    ProductosDisponibles[i].Cantidad -= cantidad;

                }
            }
        }
        public void QuitarTodoProducto(int id)
        {
            Producto productoEncontrado = ProductosDisponibles.Find(x => x.Id == id)!;
            if (productoEncontrado == null)
            {
                //no encontro producto
            }
            else
            {
                int index = ProductosRetirados.FindIndex(p => p.Id == id);

                if (index != -1)
                {
                    ProductosRetirados[index].Cantidad += productoEncontrado.Cantidad;

                    int i = ProductosDisponibles.FindIndex(x => x.Id == id);
                    ProductosDisponibles.RemoveAt(i);
                }
                else
                {
                    Producto copiaProducto = new Producto
                    {
                        Id = productoEncontrado.Id,
                        Nombre = productoEncontrado.Nombre,
                        Precio = productoEncontrado.Precio,
                        Cantidad = productoEncontrado.Cantidad
                    };

                    ProductosRetirados.Add(copiaProducto);

                    int i = ProductosDisponibles.FindIndex(x => x.Id == id);
                    ProductosDisponibles.RemoveAt(i);
                }
            }
        }
    }
}
