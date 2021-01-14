using System;

namespace Ejercicio1Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            float perimetro = 0.0f, lado = 0.0f;
            int nLados = 0;
            Console.WriteLine("¿Cual es la medida de los lados en centimetros?");
            lado = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("¿Cuantos lados tiene el poligono?");
            nLados = Convert.ToInt32(Console.ReadLine());

            perimetro = lado * nLados;

            Console.WriteLine("Perimetro del poligono es {0} cm",perimetro);
        }
    }
}
