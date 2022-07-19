using System;
using System.Collections.Generic;

namespace TipoAnonimos 
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new{
                Name = "Jose",
                Age = 50
        
            };
            Console.WriteLine($"{people.Name}, {people.Age}");

            
        }
    }
}