using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){
                43,2,45,23,4,53,4,3,51,3
            };

            foreach (var item in numbers)
            {
                Console.WriteLine(item);   
            }

            List<People> gentes = new List<People>(){
                new People("maria", "argentina"),
                new People("Juna", "Salvador"),
                new People("Jose", "Espana")
            };

            Show(gentes);
        }

        static void Show(List<People> gentes){
            Console.WriteLine("--- persona ---");

            foreach(var item in gentes){
                Console.WriteLine($"Name: {item.Name} Ciudad:{item.City}");
            }
        }

    }

    class People{
        public string Name {get; set;}
        public string City {get; set;}
        
        public People(string n, string c){
            Name = n;
            City = c;
        }

    }
}