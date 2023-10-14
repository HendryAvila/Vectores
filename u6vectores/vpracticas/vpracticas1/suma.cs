using System;

namespace vpracticas1 //hacer una suma de vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vsuma = new int [10];
            int acu = 0, numero;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese su numero");
                numero = int.Parse(Console.ReadLine());
                vsuma[i] = numero; // los numeros que me ingrese la variable numero me los guardo en el vector
            }
            acu += 0;
            for (int i = 0; i < 10; i++)
            {
                acu += vsuma[i];
            }

            Console.WriteLine("La suma de los numeros es: " + acu);

            

        }
    }
}
