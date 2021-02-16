using System;

namespace Valores_extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valores extremos");
            double total = 0;
            Console.Write("Ingrese el numero de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200, edad = 0;
            string nombreMA = " ", nombreME = " ";

            
            while (i < n)
            {
                Console.WriteLine("Nombre: ");
                string nombre = (Console.ReadLine());

                Console.WriteLine("Edad: ");
                edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    nombreMA = nombre;
                }
                if (edad < min)
                {                 
                   min = edad;
                   nombreME = nombre;
                } 
                total += edad;
                i++;
            }

            double promedio = total / n;
            
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor =" + max);
            Console.WriteLine("El mayor es =" + nombreMA);
            Console.WriteLine("Minimo =" + min);
            Console.WriteLine("El menor es =" + nombreME);
        }
    }
}
