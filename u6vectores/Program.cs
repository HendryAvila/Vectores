using System;

namespace u6vectores
{
    class Program
    {
        static void Main(string[] args)
        {          
            int [] v = new int [10];

            int n, acu;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese su  numero");
                n = int.Parse(Console.ReadLine());

                v[i] = n;

            }
            acu = 0;
            for (int i = 0; i < 10; i++)
            {
                acu += v[i];
            }
            Console.WriteLine("La suma de los 10 numeros es: " + acu);
        }
    }
}
