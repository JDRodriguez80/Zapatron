using System;

namespace Zapatron
{
    public abstract class Zapatos
    {   //atributos generales de la clase 
        private string _name;
        private string _tipo;
        private double _precio;
        private string _color;
        private int _cantidad;

        //constructor
        public Zapatos(string name, string tipo, double precio, string color, int cantidad)
        {
            _name = name;
            _tipo = tipo;
            _precio = precio;
            _color = color;
            _cantidad = cantidad;
        }

        public virtual void venta(String vendedor)
        {
            //clase virtual que sera sobreescrita por las clases hijas

        }
    }
}
