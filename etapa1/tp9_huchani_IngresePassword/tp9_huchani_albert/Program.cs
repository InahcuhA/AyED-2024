using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9_huchani_albert
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribir un programa que almacene la cadena de caracteres contraseña en una variable,
           pregunte al usuario por la contraseña e imprima por pantalla si la contraseña introducida
           por el usuario coincide con la guardada en la variable sin tener en cuenta mayúsculas y
           minúsculas. */

            string contraseña = "alumno";
            Console.WriteLine("introdusca la contraseña");

            string contraseña_introducida = Console.ReadLine();

            if (contraseña_introducida == contraseña)
            { 
                Console.WriteLine("la contraseña es correcta");
            }
            else
            {
                Console.WriteLine("la contraseña es incorrecta");
            }


            Console.ReadKey();
        }
    }
}
