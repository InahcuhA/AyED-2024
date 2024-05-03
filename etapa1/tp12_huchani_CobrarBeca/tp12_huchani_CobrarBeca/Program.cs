using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp12_huchani_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {/*Para poder cobrar la beca JuanPedro se debe ser mayor de 19 años y 
           tener unos ingresos iguales o superiores a $100.000 mensuales. 
           Escribir un programa que pregunte al usuario su edad y sus ingresos mensuales 
           y muestre por pantalla si el usuario puede cobrar o no.*/

            Console.WriteLine("igrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese sus ingrsos mesuales");
            int ingre = int.Parse(Console.ReadLine());
            

            if((edad > 19) && (ingre >= 100000))
            {
                Console.WriteLine("puede cobrar la beca");

            }
            else
            {
                Console.WriteLine("no puede cobrar la beca");
            }

            Console.ReadKey();
        }
    }
}
