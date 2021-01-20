using System;

public class Pessoa{
    public string Name{get; set;}
       public Pessoa(){ //Construtor sem argumentos
    Name="desconhecido";
    }
    public Pessoa (string Name){ //Construtor com argumentos
        this.Name=Name;
    }
    /*// Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }*/
}

class TestePessoa{
    static void Main(){
        Pessoa pes1 = new Pessoa();
        Console.WriteLine(pes1.Name);

        Pessoa pes2 = new Pessoa("Marquitos");
        Console.WriteLine(pes2.Name);

        Console.WriteLine(pes2);
        pes2.Name="Marcia";
        Console.WriteLine(pes2.Name);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}