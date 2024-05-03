using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp16_huchani_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribe un programa que muestre por consola (con un print) 
           los  números de 1 a 100 (ambos incluidos y con un salto de línea entre  
           cada impresión), sustituyendo los siguientes: 
           - Múltiplos de 3 por la palabra "fizz". 
           - Múltiplos de 5 por la palabra "buzz". 
           - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".*/
            int cont = 0;
            while (cont < 100)
            {
                
                cont += 1;

                if ((cont % 3 == 0) && (cont % 5 == 0))
                {
                    Console.WriteLine("fizzbuzz");
                }
            
                else if (cont % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (cont % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else 
                {
                    Console.WriteLine(cont);
                }
             }
            Console.ReadKey();
        }
    }
}
