using System;

namespace ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
         //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos)
         //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo
         //. Mostrar el resultado en pantalla. Ejemplo:
         //CADENA FUENTE: “La mar estaba serena"
         //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
         //CADENA RESULTADO: “Li mir estibi sereni"
         char [] cadfuente = new char [100];
         char carac1, carac2 = ' ', l = ' ';
         int indice = 0;
           while (l != '.')
           {
            Console.WriteLine("Ingrese una frase letra por letra y cortas con un punto");
            l = char.Parse(Console.ReadLine());
            cadfuente[indice] = l;
            indice++;
           }

            Console.WriteLine("Ingrese un caracter para que sea cambiado por el segundo caracter");
            carac1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo caracter para que sea cambiado por el primer caracter caracter ingresado  y terminas con un punto");
            carac2 = char.Parse(Console.ReadLine());
            
            for (int i = 0; i < indice -1; i++)
            {
                if (cadfuente[i] == carac1)
                {
                    cadfuente[i] = carac2;
                    
                }
           Console.WriteLine(cadfuente);
        }
    }
}
}
