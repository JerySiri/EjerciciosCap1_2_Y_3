using System;

namespace Ejercicio5Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            const float VALOR_EURO = 0.82f;
            float dolar = 0.0f, euros = 0.0f;
            Console.WriteLine("¿Cual es la cantidad de dolares que desea Convertir a euros?");
            dolar = Convert.ToSingle(Console.ReadLine());
            euros = dolar * VALOR_EURO;
            Console.WriteLine("-- {0} dolares son {1} euros", dolar, euros);
            Console.WriteLine("-- Cambio del dia: dolar = {0} euros.",VALOR_EURO);
           
        }
    }
}
