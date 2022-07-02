using System;

namespace Sobreescritura{
    class Program{
        static void Main(string[] args){
            B b = new B();
            Console.WriteLine(b.Hi());
            Sale sale1 = new Sale(3);
            sale1.Add(4);
            sale1.Add(4);
            Console.WriteLine(sale1.GetTotal());

        }


    }

    class Sale{
        private decimal[] _amounts;
        private int _n;
        private int _end;

        public Sale(int n){
            _amounts = new decimal[n];
            _n = n;
            _end = 0;            

        }

        public void Add(decimal amount){
            if(_end < _n){
                _amounts[_end] = amount;
                _end++;

            }
        }

        public virtual decimal GetTotal(){
            decimal total = 0;
            for(int i = 0;i<_amounts.Length;i++){
                total = total + _amounts[i];

            }
            return total;
        }
    }

    public class SalesTax : Sale{
        public decimal tax;
        public SalesTax(int n, decimal tax) : base(n){
            this.tax = tax;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * tax;
        }
    }

    class A
    {
        public virtual string Hi(){
            return "hola bro soy A";
        }

    }

    class B : A
    {
        public override string Hi()
        {
            return "Hola soy B" + base.Hi();
        }

    }
}