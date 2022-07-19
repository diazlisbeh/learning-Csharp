using System;
using System.Linq;
using System.Collections.Generic;
class Program{
    static void Main(string[] args){
        var beer = new List<Beer>(){
            Name = "node", Country="Mexico",
            Name = "hola", Country="Argentina",
            Name = "bkye", Country="Espana"
        };

        var beersName = from b in beer 
                        select new {
                            Name = b.Name,
                            letras = b.Name.Length
                        };

        foreach (var item in beersName)
        {
            Console.WriteLine($"{item.Name} {item.letras}");
            
        }

    }

    
}

public class Beer{
    public string Name {get; set;}
    public string Country {get; set;}
}

public class Country{
    public string Name {get; set;}
    public string Continent {get; set;}

}