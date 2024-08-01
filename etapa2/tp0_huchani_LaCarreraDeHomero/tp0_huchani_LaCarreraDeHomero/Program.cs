using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp0_huchani_LaCarreraDeHomero
{
    class Program
    {
        static void Main(string[] args)
        {/* Homero Simpson está participando en una carrera de obstáculos. 
            Cada obstáculo tiene una dificultad diferente (representada por un número entero). 
            Ayuda a Homero a calcular su puntaje total.
            
            El usuario ingresa la cantidad de obstáculos.
            
            Homero debe superar cada obstáculo y sumar los puntos correspondientes, cada obstáculo superado
            suma 10 puntos, cada obstáculo NO superado resta 5.
            
            (Debe aparecer un mensaje por cada obstáculo diciendo "OBSTACULO X, lo supera?" y 
            el usuario debe responder si o no)*/
            Console.WriteLine("ingrese una cantidad de obstaculo ");
            int obts = int.Parse(Console.ReadLine());
            int[] cantobts = new int[obts];

            for (int cont = 0; cont < cantobts.Count(); cont++)

            {

                Console.WriteLine("obstaculo " + (cont + 1) + " lo supera?");
                string resp = Console.ReadLine();


                if (resp == "si")
                {
                    cantobts[cont] = 10;
                    Console.WriteLine(cantobts[cont]);
                }
                else if (resp == "no")
                {
                    cantobts[cont] -= 5;
                    Console.WriteLine(cantobts[cont]);
                }
                else
                {
                    Console.WriteLine("ERROR");
                    cont--;
                }


                

            }

            int puntos = 0;

            for (int cont = 0; cont < cantobts.Count(); cont++)
            {
                puntos += cantobts[cont];
            }

            Console.WriteLine("puntos finales: " + puntos);
            Console.ReadKey();
        }
    }
}
