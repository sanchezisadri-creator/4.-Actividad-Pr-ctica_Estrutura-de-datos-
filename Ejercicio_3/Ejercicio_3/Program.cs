using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, int> estudiantes = new Dictionary<string, int>()
        {
            {"Juan", 85},
            {"Maria", 90},
            {"Carlos", 78}
        };

        
        estudiantes["Carlos"] = 88;

        
        Console.WriteLine("Calificaciones de los estudiantes:\n");

        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine(estudiante.Key + " : " + estudiante.Value);
        }

        Console.ReadKey();
    }
}
