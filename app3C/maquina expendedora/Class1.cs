using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_expendedora
{
    //justificacion
    //tipo de dato para el precio:
    //use el tipo de dato "double" para el precio porque los precios no siempre seran numeros enteros y este tipo de dato tiene 
    //puede almacenar mas decimales que el float
    //Tipo de dato para el inventario:
    //utilicé "int" porque las existencias representan cantidades enteras de productos;
    //no puede haber  2.5 refrescos o 1.7 chocolates.
    //Encapsulamiento:
    //Los atributos se declararon como privados para evitar que el menú principal
    //modifique directamente el inventario o el precio.
    //La única forma de alterar las existencias es mediante los métodos Comprar()
    //y Abastecer(), los cuales aplican validaciones de seguridad.
    internal class producto
    {
        private string nombre;
        private double precio;
        private int existencia;

        public string nombre1
        {
            get { return nombre; }
        }
        public double precio1
        {
            get { return precio; }
        }
        public int existencia1
        {
            get { return existencia; }
        }
        public producto(string nombre, double precio, int existencia)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.existencia = existencia;
        }
        public double comprar(int cantidad)
        {
            if (cantidad > existencia)
            {
                Console.WriteLine("No hay suficiente producto en existencia.");
                return -1;
            }
            else
            {
                existencia = existencia - cantidad;
                return precio * cantidad;
            }
        }
        public void abastecer(int cantidad)
        {
            existencia = existencia + cantidad;
        }
        public string mostrar()
        {
            return $"Producto: {nombre}, Precio: {precio}, Existencia: {existencia}";
        }
    }
}
