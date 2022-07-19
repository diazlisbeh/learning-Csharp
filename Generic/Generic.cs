using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>(10);
            numbers.Add(3);
            numbers.Show();
            
            MyList<string> letters = new MyList<string>(10);
            letters.Add("Hola");
            letters.Show();

        }
    }

    public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n){
            _elements = new T[n];
        }

        public void Add(T e){
            if(_index < _elements.Length){
                _elements[_index] = e;
                _index++;
            }
        }
        public string Show(){
            string res;
            for(int i = 0;i < _elements.Length; i++){
                
            }
        }
    }
}