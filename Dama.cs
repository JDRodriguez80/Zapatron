using System;
using System.Linq;

namespace Zapatron
{
    public class Dama : Zapatos

    {   //atributos de la clase
        string name;
        string tipo;
        double precio;
        int talla;
        string color;
        int cantidad;
        //constructor
        public Dama(string name, string tipo, double precio, int talla, string color, int cantidad) : base(name, tipo, precio, color, cantidad)
        {
            this.name = name;
            this.tipo = tipo;
            this.precio = precio;
            this.talla = talla;
            this.color = color;
            this.cantidad = cantidad;


        }

        //metodo que sobreescribe al metodo virtual de la clase padre, este recibe un parametro por lo que se puede decir
        //que se trata de un polimorfismo de sobrecarga y parametrico.
        public override void venta(string vendedor)
        {
            if (Enumerable.Range(22, 26).Contains(talla)) //rango para verificar tallas


         

            {
                var total = precio * cantidad;
                var porcentaje = total * .10;
                
                Console.WriteLine(" Vendedor:{0}          Comisión:$ {1}",vendedor,porcentaje);
                Console.WriteLine(" ┌───────────────┬──────────────────────────────────────");
                Console.WriteLine(" │ concepto      │     Valor       ");
                Console.WriteLine(" ├───────────────┼──────────────────────────────────────");
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Cantidad     │     {0}         ",cantidad);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Tipo         │     {0}         ",tipo);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Descripcion  │     {0}            ",name);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Color        │     {0}         ",color);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" │  Precio pz.   │     {0}           ",precio);
                Console.WriteLine(" │               │                 ");
                Console.WriteLine(" └───────────────┼───────────────────────────────────────");
                Console.WriteLine("           Total │   $ {0}           ",total);


            }
            else { Console.WriteLine("Lo sentimos, no tenemos existencia en esa talla"); }
        }
    }
}
