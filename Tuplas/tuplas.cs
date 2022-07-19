using System;
using System.Collections.Generic;

namespace Tuplas
{
    class Program{
        static void Main(string[] args){

            (int id, string name) product = (1,"hola tu");
            Console.WriteLine($"{product.id}, {product.name}");

        }
        
    }
}