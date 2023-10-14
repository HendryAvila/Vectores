using System;

namespace vpracticas4
{
    class Program
    {//dada una lista de 10 numeros enteros
    //cargarlos en un vector 
    //y buscar si estan ordenados de menor a mayor(lo hago buscando un maximo y con una bandera)
        static void Main(string[] args)
        {
            int [] v = new int [10];
            int numero, minimo;
            bool bandera;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese su numero");
                numero = int.Parse(Console.ReadLine());//guardamos los valores en el vector
                v[i] = numero;
            }
           bandera = true;
           minimo = v[0];//iniciamos el maximo con el primer numero para que se compare
           for (int i = 0; i < 10; i++)
           {
              if (v[i] >= minimo)
              {
                minimo = v[i];
              }else
              {
                bandera = false;
              }
           }
           if (bandera)
           {
            Console.WriteLine("estan ordenados");
           }else
           {
            Console.WriteLine("Estan desordenados");
           }
        }
    }
}
