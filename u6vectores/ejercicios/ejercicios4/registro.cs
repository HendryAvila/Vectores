using System;

namespace ejercicios4
{
    class Program
    {
/*4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
- Número de Artículo (1 a 15)
- Cantidad Vendida 

Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
Se pide determinar e informar:
a) El número de artículo que más se vendió en total.
b) Los números de artículos que no registraron ventas.
c) Cuantas unidades se vendieron del número de artículo 10.*/
        static void Main(string[] args)
        { int na = 0, cv, maximo;
        int [] vacu = new int [15];
        for (int i = 0; i < 15; i++)
        {
            vacu[i] = 0;
        }
        Console.WriteLine("Ingrese su numero de artico");
        na = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida");
        cv = int.Parse(Console.ReadLine());
    while (na != 0)
    {
        vacu[na -1] += cv;
        Console.WriteLine("Ingrese su numero de artico");
        na = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida");
        cv = int.Parse(Console.ReadLine());
    }
      maximo = vacu[0];
      na = 1;

    for (int i = 0; i < 15; i++)
    {
        if (vacu[i] > maximo)
        {
            maximo = vacu[i];
            na = i + 1;
        }
        
    }
    Console.WriteLine("El numero de articulo mas vendido es " + na + " con una cantidad de " + maximo);
    
    for (int i = 0; i < 15; i++)
    {
        if (vacu[i] == 0)
        {
           Console.WriteLine("El producto " + (i + 1) + " no tuvo ventas");
        }
    }

    Console.WriteLine("la cantidad vendida para el articulo numero 10 es " + vacu[9]); 
        }
    }
}
