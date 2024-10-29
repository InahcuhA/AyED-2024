using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp18_huchani_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {/*Escriba un programa que pregunte una y otra vez si desea terminar el programa, salvo si se 
           contesta exactamente SI (en mayúsculas y sin tilde).*/
            
            
            string si = "SI";
            bool cons = true;
            while (cons == true)
            {
                Console.WriteLine("quiere terminar el programa? (ponga SI)");
                string respuesta = Console.ReadLine();
                if (respuesta == si)
                {
                    cons = false;
                }
                
            }


            
        }   
    }
}
