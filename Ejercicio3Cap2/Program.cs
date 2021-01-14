using System;

namespace Ejercicio3Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.1416f;
            float radial = 0.0f, grado = 0.0f;
            Console.WriteLine("¿Cual es la cantidad de grados que desea Convertir?");
            grado = Convert.ToSingle(Console.ReadLine());
            radial = grado * (PI/180);
            Console.WriteLine("{0} grados son {1} radiales", grado,radial);

        }
    }
}
