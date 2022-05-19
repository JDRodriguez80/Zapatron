using System;
using System.Linq;

namespace Zapatron
{
    public class Bebes : Zapatos
    {
        string name;
        string tipo;
        double precio;
        int talla;
        string color;
        int cantidad;
        public Bebes(string name, string tipo, double precio, int talla, string color, int cantidad) : base(name, tipo, precio, color, cantidad)
        {
            this.name = name;
            this.tipo = tipo;
            this.precio = precio;
            this.talla = talla;
            this.color = color;
            this.cantidad = cantidad;


        }


        public override void venta(string vendedor)
        {
            if (Enumerable.Range(10, 14).Contains(talla))

            {
                var total = precio * cantidad;
                var porcentaje = total * .05;

                Console.WriteLine(" Vendedor:{0}          Comisión:$ {1}", vendedor, porcentaje);
                Console.WriteLine(" ┌───────────────┬──────────────────────────────────────");
                Console.WriteLine(" │ concepto      │     Valor       ");
                Console.WriteLine(" ├───────────────┼──────────────────────────────────────");
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Cantidad     │     {0}         ", cantidad);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Tipo         │     {0}         ", tipo);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Descripcion  │     {0}            ", name);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Color        │     {0}         ", color);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Precio pz.   │     {0}           ", precio);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" └───────────────┼───────────────────────────────────────");
                Console.WriteLine("           Total │   $ {0}           ", total);

            }
            else { Console.WriteLine("Lo sentimos, no tenemos existencia en esa talla"); }
        }


    }
}
