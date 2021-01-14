using System;

namespace Ejercicio1Cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Introdusca un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("{0} es un numero par.", num);
            }
            else
            {
                Console.WriteLine("{0} es un numero impar.", num);
            }
        }
    }
}
