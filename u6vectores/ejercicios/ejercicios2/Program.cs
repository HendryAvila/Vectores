using System;

namespace ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
        //Hacer un programa que solicite 10  números enteros y los guarde en un vector. l
        //uego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
        int [] vnumeros = new int [10];
        int numeros;
        float acu, promedio;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese su numero, por favor");
            numeros = int.Parse(Console.ReadLine());
            vnumeros[i] = numeros;
        }
        acu = 0;
        for (int i = 0; i < 10; i++)
        {
              acu += vnumeros[i];
            
        }
        promedio = acu/10;
        Console.WriteLine("el promedio mayor es " + promedio);
        for (int i = 0; i < 10; i++)
        {
            
        if (vnumeros[i] > promedio)
        {
            Console.WriteLine( vnumeros[i] + "es mayor al promedio");
        }
        }
        }
    }
}
