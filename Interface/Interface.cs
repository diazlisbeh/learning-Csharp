using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }

    public class Shark: IAnimal, IFish{

        public Shark(string name, double speed){
            
        }
        public string Name {get; set;}
        public double Speed {get; set;}
        public string Swin (){

            if(Name.Length <= 0 || Speed < 0){
                return "Nombre o velocidad no ha sido inicialisados";
            }else{
            return $"{Name} nada a {Speed}km/h";
            }
        }
    }

    public interface IAnimal {
        public string Name {get; set;}
    }
    public interface IFish {
        public double Speed {get; set;}

        public string Swin ();
    }
}