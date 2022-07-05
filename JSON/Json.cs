using System;
using System.Text.Json;

namespace JSON
{
    class Program
    {
        static  void Main(string[] args)
        {
            Beer myBeer = new Beer(){
                Name = "golden",
                Brand = "presidente"
            };

            string json = JsonSerializer.Serialize(myBeer);
            
        }
    }

    public class Beer
    {
        public string Name {get; set;}
        public string Brand {get; set;}

    }
    
}