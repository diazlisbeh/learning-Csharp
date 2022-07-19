using System;
using System.Collections.Generic;

namespace MetodosListas
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>(){
        3,24,52,3,43,25,4,2
      };
      Show(numbers);
      numbers.Insert(0,4);
      Show(numbers);
     Console.WriteLine( numbers.Contains(25));
     //Index of
     Console.WriteLine(numbers.IndexOf(100));
     //sort
     numbers.Sort();
     Show(numbers);
      //Add Range
      numbers.AddRange(new List<int> (){
        3,4,25,3,3
      });

      Show(numbers);
    }

    public static void Show(List<int> numbers){
      Console.WriteLine("--- Mostrado Lista ------");
      foreach(var a in numbers){
        Console.WriteLine(a);
      }
    }
  }
}
