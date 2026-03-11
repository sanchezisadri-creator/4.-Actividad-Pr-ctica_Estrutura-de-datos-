using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, int> productos = new Dictionary<string, int>()
        {
            {"Agua", 20},
            {"Pan", 15},
            {"Leche", 60},
            {"Jugo", 40},
            {"Arroz", 50}
        };

        
        Console.WriteLine("Claves del diccionario:\n");

        foreach (var clave in productos.Keys)
        {
            Console.WriteLine(clave);
        }

        Console.ReadKey();
    }
}
