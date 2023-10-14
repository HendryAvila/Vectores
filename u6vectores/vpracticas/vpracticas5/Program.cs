using System;

namespace vpracticas5
{
    class Program
    {
        static void Main(string[] args)
        {

         char [] letra = new char [50];
         char l;
         int indice = 0;

         Console.WriteLine("Ingrese su nombre letra por letra (Termina con un punto)");
         l = char.Parse(Console.ReadLine());

         while (l != '.' && indice < 50)
         {
            letra[indice] = l;
            l = char.Parse(Console.ReadLine());
            indice++;
         }
         letra[indice] = '\0';
         for (int i = 0; i < 50; i++)
         {
            if (letra[i] == 'a')
            {
               letra[i] = 'e';
            }
            }

         Console.WriteLine(letra);

      
        
    }
 } 
}
