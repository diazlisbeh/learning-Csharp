using System;

class Program{
    static void Main(string[] args){
        Console.WriteLine("hola tu");

        Sale venta = new Sale(25,DateTime.Now);
        venta.Show();
        Console.WriteLine(venta.giveTotal());
    }



    class Sale{

        int total;
        DateTime date;
        public Sale(int total, DateTime date){
            this.total = total;
            this.date = date;
        }


        public string giveTotal(){
            return $"El total es de {this.total}, realizada el {this.date}";
        }
        public void Show(){
            Console.WriteLine("Soy una venta");
        }
    }
}