using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio02estructuras
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio  1");
            Console.Write("Ingrese un numero entero;");
            int x;

            try
            {
                x = Convert.ToInt32(Console.ReadLine());

                if (x > 0)
                {
                    Console.WriteLine("Es numero positivo");
                }
                else if (x < 0)
                {
                    Console.WriteLine("El numero es negativo  ");
                }
                else
                {
                    Console.WriteLine("Es igual a ceroo");
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine("No ingreso un numero " + ex.Message);
            }







            Console.WriteLine("Ingrese un numero de dia ");
            int dia;
            dia = Convert.ToInt32(Console.ReadLine());

            switch(dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("martes ");
                    break;
                case 3:
                    Console.WriteLine("miercoles");
                    break;
                case 4:
                    Console.WriteLine("jueves");
                    break;
                case 5:
                    Console.WriteLine("viernes");
                    break;
                case 6:
                    Console.WriteLine("sabado");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;
                default:
                    Console.WriteLine(dia + "  No es un numero valido ");
                    break;
            }


            Console.ReadKey();



        }
    }
}
