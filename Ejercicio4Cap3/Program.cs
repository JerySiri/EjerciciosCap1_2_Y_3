using System;

namespace Ejercicio4Cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Introduca un numero del 1 al 7: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("--Domingo--");
                break;

                case 2:
                    Console.WriteLine("--Lunes--");
                break;

                case 3:
                    Console.WriteLine("--Martes--");
                break;

                case 4:
                    Console.WriteLine("--Miercoles--");
                break;

                case 5:
                    Console.WriteLine("--Jueves--");
                break;

                case 6:
                    Console.WriteLine("--Viernes--");
                break;

                case 7:
                    Console.WriteLine("--Sabado--");
                break;

                default:
                    Console.WriteLine("Error, Laopcion que tomo no es correcta.");
                break;
            }

        }
    }
}
