// See https://aka.ms/new-console-template for more information
using System;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB(@"containers-us-west-66.railway.app","railway","root","svq9dWLslBbrLQ5iolIb");
            db.Connect();
            db.Close();
        }
    }
}