using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_huchani_SistemaDeConversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir una función que convierta un número decimal en binario y 
             * luego otra que convierta un número binario en decimal.*/
            bool band = true;
            while (band != false)
            {
                Console.WriteLine("1. convertir de decimal a binario");
                Console.WriteLine("2. convertir de binario a decimal");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese un numero entero positivo");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine(bin(num));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("ingrese un numero en binario");
                        string num1 = Console.ReadLine();
                        Console.WriteLine(deci(num1));
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }
            }

            
            
        }

        static string bin (int number)
        {
           string resultado = "";
           while(number > 0)
            {
                int cociente = number % 2;
                number = number / 2;
                resultado = cociente.ToString() + resultado;
            }
           return resultado;
        } 

        static int deci (string x)
        {
             return Convert.ToInt32(x, 2);
        }
    }
}
