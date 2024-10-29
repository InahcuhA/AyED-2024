using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp17_huchani_miprimermenu
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Requerimientos:
            Mostrar un mensaje de bienvenida al programa.
            Presentar un menú con al menos tres opciones numeradas.
            Permitir al usuario seleccionar una opción ingresando el número correspondiente.
            Realizar una acción diferente para cada opción seleccionada.
            Repetir el proceso hasta que el usuario elija una opción para salir del programa.


            Ejemplo de Menú:

            --- Menú ---
            1. Opción 1
            2. Opción 2
            3. Opción 3
            4. Salir*/

            
            bool console = true;

            while (console != false)
            {
                Console.WriteLine("Bienvenido al menu" + "\n" + "elija una opcion");
                Console.WriteLine("1.para resolver una suma" + "\n" + "2.para mostrar una tabla de multplicar" + "\n" + "3.para decirte cuantos años tienes o tendras en este 2024" + "\n" + "4.para salir del menu");
                int opcion = int.Parse(Console.ReadLine());



                if (opcion == 1)
                {
                    Console.WriteLine("ingrese un numero entero");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese otro numero entero");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("la suma del primer numero y el segundo es igual a " + (num1 + num2));
                    Console.ReadLine();
                    Console.Clear();
                }
                if (opcion == 2)
                {
                    Console.WriteLine("ingrese un numero entero para la tabla");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("1 x " + num + " = " + (1 * num));
                    Console.WriteLine("2 x " + num + " = " + (2 * num));
                    Console.WriteLine("3 x " + num + " = " + (3 * num));
                    Console.WriteLine("4 x " + num + " = " + (4 * num));
                    Console.WriteLine("5 x " + num + " = " + (5 * num));
                    Console.WriteLine("6 x " + num + " = " + (6 * num));
                    Console.WriteLine("7 x " + num + " = " + (7 * num));
                    Console.WriteLine("8 x " + num + " = " + (8 * num));
                    Console.WriteLine("9 x " + num + " = " + (9 * num));
                    Console.WriteLine("10 x " + num + " = " + (10 * num));
                    Console.ReadLine();
                    Console.Clear();
                }           
                if ( opcion == 3)
                {
                    Console.WriteLine("ingrese su año de nacimiento");
                    int añoN = int.Parse(Console.ReadLine());
                    Console.WriteLine("usted tendra o tiene " + (2024 - añoN) + " años");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (opcion == 4)
                {
                    console = false;
                }
            } 
               
            
        }
    }
}
