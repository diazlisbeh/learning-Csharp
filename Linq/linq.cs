using System;
using System.Linq;
using System.Collections.Generic;
namespace Linq{

class Program{

    static void Main(string[] args){
        List<Beer> beers = new List<Beer>(){
            new Beer(){Name = "nodehru", Country="Mexico"},
            new Beer(){Name = "holfsafa", Country="Argentina"},
           new Beer(){ Name = "bkyef", Country="Espana"}
       };
        List<Country> countries = new List<Country>(){
            new Country(){Name = "Mexico", Continent="America"},
            new Country(){Name = "Argentina", Continent="America"},
            new Country(){Name = "Espana", Continent="Europa"},
            new Country(){Name = "China", Continent="Asia"},
       };
        
        //select
            Console.WriteLine("------------select-------------------");
        var beersName = from b in beers 
                        select new {
                            Name = b.Name,
                            letras = b.Name.Length
                        };

        foreach (var item in beersName)
        {
            Console.WriteLine($"{item.Name} {item.letras}");
            
        }
        
            Console.WriteLine("------------Where-------------------");
        var beerArgentina = from b in beers
                                where b.Country == "Argentina"
                                select b;
        
        foreach(var beer in beerArgentina)
            Console.WriteLine(beer);
        
        Console.WriteLine("------------OrderBy-------------------");
        var beerOrderby = from b in beers
                                orderby b.Country  //descending
                                select b;
        
        foreach(var beer in beerOrderby)
            Console.WriteLine(beer);

        //---------------------------------------------------------------------------

        Console.WriteLine("------------JOIN-------------------");
        var berrsWithContinent = from b in beers
                                join c in countries
                                on b.Country equals c.Name
                                select new{
                                    Name = b.Name,
                                    Country = b.Country,
                                    c.Continent
                                };
        foreach (var j in berrsWithContinent){
            Console.WriteLine($"{j.Name} {j.Country} {j.Continent}");
        }
        

    }

    
}

public class Beer{
    public string Name {get; set;}
    public string Country {get; set;}

    public override string ToString (){
        return $"Nombre: {Name} Pais: {Country}";
    }
}

public class Country{
    public string Name {get; set;}
    public string Continent {get; set;}

}
}
