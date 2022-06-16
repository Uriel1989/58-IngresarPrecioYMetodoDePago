using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) 
 * si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)
 */

namespace IngresarPrecioYMetodoDePago
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.WriteLine("Ingrese el precio del producto en cuestion:");
            int precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el metodo de pago, efectivo o tarjeta:");
            string MetodoDePago = Convert.ToString(Console.ReadLine());

            switch (MetodoDePago)
            {
                case"tarjeta":
                    Console.WriteLine("Ingrese el numero de cuenta:");
                    int NumeroDeCuenta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El precio es: " + precio + " y se ha pagado con la cuensta numero:" + NumeroDeCuenta);
                    break;
                case "efectivo":
                    Console.WriteLine("El producto con el precio: " + precio + " se ha pagado.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
