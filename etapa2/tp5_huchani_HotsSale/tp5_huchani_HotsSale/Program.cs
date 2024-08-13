using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5_huchani_HotsSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de productos vendidos");
            int producsVendidos = int.Parse(Console.ReadLine());
            int[] productos = new int[producsVendidos];
            for (int i = 0; i < productos.Count(); i++ )
            {
                Console.WriteLine("ingrese el precio del producto N°" + (i + 1));
                int precio = int.Parse(Console.ReadLine());
                productos[i] = precio;
            }

            for (int i = 0; i < productos.Count() - 1; i++)
            {
                for (int j = 0; j < productos.Count() - 1 - i ; i++)
                {
                    if (productos[j] < productos[j + 1])
                    {
                        int temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }


            for (int i = 0; i < productos.Count(); i++)
            {
                Console.WriteLine("     " + productos[i]+"$");
            }


            Console.WriteLine("el producto mas caro es: " + productos[0]);
            Console.WriteLine("el producto mas economico es: " + productos[productos.Count() - 1]);


            Console.ReadKey(); 



        }
    }
}
