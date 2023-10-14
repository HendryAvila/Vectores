using System;

namespace ejercicios1
{
    class Program
    { //1. Hacer un programa que solicite 10 números enteros
    // y los guarde en un vector (hecho). Luego recorrer los elementos y determinar e informar cuál es el valor máximo 
    //y su posición dentro del vector.
        static void Main(string[] args)
        {
            int [] vnumeros = new int [10];
            int numero, maximo, posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese su numero");
                numero = int.Parse(Console.ReadLine());
                vnumeros[i] = numero;
            }
            maximo = vnumeros[0];
            for (int i = 0; i < 10; i++)
            {
                if (vnumeros[i] > maximo)
                {
                     maximo = vnumeros[i];
                    posicion = i +1;
                }
            }

            Console.WriteLine("El valor maximo es " + maximo + " y su posicion es " + posicion);

        }
    }
}
