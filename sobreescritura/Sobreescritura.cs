using System;

namespace Sobreescritura{
    class Program{
        static void Main(string[] args){
            B b = new B();
            Console.WriteLine(b.Hi());

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