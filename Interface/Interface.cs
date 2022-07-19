using System;

namespace Interface
{
   public class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]{
                new Shark("Tiburucis", 12.3),
                new Shark("bu jaja", 4.3),
                new Shark("baby", 10),
                new Shark("tururu", 15)
            };
        ShowFish(sharks);

        }
        public static void ShowFish(IFish[] fishs){
            Console.WriteLine("-- Mostrando pecesitos --");
            
            for(int i = 0;i<fishs.Length;i++){
                Console.WriteLine(fishs[i].Swin());
            }
        }



    }

    public class Shark: IAnimal, IFish{

        public Shark(string Name, double Speed){
            this.Name = Name;
            this.Speed = Speed;

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
        string Name {get; set;}
    }
   public interface IFish {
        double Speed {get; set;}

        string Swin ();
    }
}