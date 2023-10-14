using System;

namespace vpracticas2
//ingresa 10 numeros
//buscar valor maximo y su posicion
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] v = new int [10];
           int numero, maximo = 0, pos = 1;  

           for (int i = 0; i < 10; i++)
           {
            Console.WriteLine("Ingrese un numero"); //ingreso los 10 numeros
            numero = int.Parse(Console.ReadLine());
            v[i] = numero;// me guardo los numeros en el vector
           }
           maximo = v[0]; // le doy una posiicion para que empiece como maximo y esa es la primera por donde pasa el for

           for (int i = 0; i < 10; i++)
           {
            if (v[i] > maximo) //busco el maximo con el condicional
            {
                maximo = v[i]; 
                pos = i + 1; //con esto busco la posicion

            }           
           }
           Console.WriteLine(" el valor maximo es " + maximo + " y su posicion es " + pos);
        }
    }
}
