using System;
using System.Collections.Generic;

namespace Listas
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(3);
            numbers.Add(75);
            numbers.Add(2);

            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>(){
                2,34,32,4,5,4,2,43,3
            };
            
            Console.WriteLine(numbers2.Count);
            numbers2.Clear;

            Console.WriteLine(numbers2.Count);

        }
    }   
}