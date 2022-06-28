using System;


class Program{
    static void Main(string[] args){

    }
}


public interface IAnimal{
    public string Name {get; set;}
}


public interface IRoket{
    public string Model {get; set;}
    public string Speed {get; set;}
    public string DateFlight {get; set;}
}