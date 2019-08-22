using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores = new List<string>();
            colores.Add("Rojo");
            colores.Add("Azul");
            colores.Add("Verde");
            colores.Add("Amarillo");
            colores.Add("Rosa");

            colores.RemoveAt(1);
            colores.Remove("Amarillo");

            Console.WriteLine("Número de elementos: " + colores.Count);

            int x= 1;
            foreach(var color in colores)
            {
                Console.WriteLine("Elemento " + x.ToString() + ": " + color);
                x++;
            }


            Console.ReadKey();



        }
    }
}
