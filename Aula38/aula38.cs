using System;
//MÉTODOS VIRTUAISHERANÇA/ORDEM DE EXECUÇÃO DE CONSTRUTORES

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void info(){ //DEFINO COM VIRTUAL
        Console.WriteLine("Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
    override public void info(){ //OVERRIDE SOBRE ESCREVE O MÉTODO DA BASE SE ELE FOR VIRTUAL
        Console.WriteLine("Derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2");
    }
    override public void info(){ //DEFINO COM VIRTUAL
        Console.WriteLine("Derivada 2");
    }
}
class Aula38{
    static void Main(){
        Base Ref; //elemento de referencia
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        //base->derivada1->derivada2
        Ref=derivada1;
        Ref.info();
    }
}