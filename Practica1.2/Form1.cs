using Practica1._2.Entities;

namespace Practica1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tienda gus = new();
        private void buttonAgregarP_Click(object sender, EventArgs e)
        {
            listBoxDisponibles.Items.Clear();
            gus.AgregarProducto();
            foreach (Producto producto in gus.ProductosDisponibles)
            {
                listBoxDisponibles.Items.Add($"ID:{producto.Id}, {producto.Nombre}, Precio: ${producto.Precio}, cantidad: {producto.Cantidad}");
            }
        }

        private void buttonEliminarP_Click(object sender, EventArgs e)
        {
            listBoxRetirados.Items.Clear();
            listBoxDisponibles.Items.Clear();

            int Id = int.Parse(textBoxId.Text);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                gus.QuitarProducto(Id);
            }
            else
            {
                int cantidad = int.Parse(textBox1.Text);
                gus.QuitarProducto(Id, cantidad);
            }

            foreach (Producto producto in gus.ProductosDisponibles)
            {
                listBoxDisponibles.Items.Add($"ID:{producto.Id}, {producto.Nombre}, Precio: ${producto.Precio}, cantidad: {producto.Cantidad}");
            }
            foreach (Producto producto in gus.ProductosRetirados)
            {
                listBoxRetirados.Items.Add($"ID:{producto.Id}, {producto.Nombre}, Precio: ${producto.Precio}, cantidad: {producto.Cantidad}");
            }
            textBoxId.Clear();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxRetirados.Items.Clear();
            listBoxDisponibles.Items.Clear();

            int Id = int.Parse(textBox2.Text);
            gus.QuitarTodoProducto(Id);

            foreach (Producto producto in gus.ProductosRetirados)
            {
                listBoxRetirados.Items.Add($"ID:{producto.Id}, {producto.Nombre}, Precio: ${producto.Precio}, cantidad: {producto.Cantidad}");
            }
            foreach (Producto producto in gus.ProductosDisponibles)
            {
                listBoxDisponibles.Items.Add($"ID:{producto.Id}, {producto.Nombre}, Precio: ${producto.Precio}, cantidad: {producto.Cantidad}");
            }
            textBox2.Clear();
        }
    }
}