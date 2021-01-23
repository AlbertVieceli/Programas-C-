using System;

public interface ITeste1
{
    void Simples(); 

    void Paint() => Console.WriteLine("Default Paint method");
}

public interface ITeste2
{
    int P{get;}
}

public interface Iteste3
{
    int P();
}

public class Geral:ITeste1,ITeste2,Iteste3{
    int ITeste2.P{ get{return 0;}}

    public int P(){
        Console.WriteLine("Implementando Teste3");
        return 0;}

    public void Simples(){
        Console.WriteLine("Implementado Teste1");
    }
    
} 

public class Principal{
        static void Main(){
            Geral A = new Geral();

            A.P();
            A.Simples();
            var teste1=new Geral();
            var prin= teste1 as ITeste1;
            prin.Paint();
        }
    }