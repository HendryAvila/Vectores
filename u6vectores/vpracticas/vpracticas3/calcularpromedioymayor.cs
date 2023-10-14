using System;

namespace vpracticas3
{//ingresar (x) numeros, calcular promedio y mostrar los mayores al promedio
    class Program
    {
        static void Main(string[] args)
        {
            int [] v = new int [10];
            int numero, promedio, acu = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese su numero");
                numero = int.Parse(Console.ReadLine());
                v[i] = numero;
            }
            acu = 0;

            for (int i = 0; i < 10; i++)
            {
                acu += v[i];
            }
            promedio = acu/10;
            Console.WriteLine("El promedio de todos los numeros es " + promedio);
            Console.WriteLine(" los numeros mayor al promedio son: ");

            for (int i = 0; i < 10; i++)
            {
                if (v[i] > promedio)
                {
                    Console.WriteLine(v[i]);
                }
            }
            
        }
    }
}
