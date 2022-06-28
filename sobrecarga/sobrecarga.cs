using System;


namespace Sobrecarga
{
    class Program{
    static void Main(string[] args)
    {
        Math math = new Math();
        int[] klk = new int[] {1,43,2,3,6};
        Console.WriteLine(math.Sum(1,3));
        Console.WriteLine(math.Sum("1","3"));
        Console.WriteLine(math.Sum(klk));


    }
    }

    class Math
    {
        public int Sum(int a, int b){
            return a + b;
        }
        public int Sum(string a, string b){
            return int.Parse(a) + int.Parse(b);
        }
        public int Sum(int[] numbers){
            int result = 0;

            for(int i= 0;i<numbers.Length; i++ ){
                result = result + numbers[i];
            }

            
            
            return result;
        }


    }
}