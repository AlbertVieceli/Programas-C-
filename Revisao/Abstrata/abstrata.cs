using System;

public class A{
    public virtual void Trampar(){
        Console.WriteLine("Classe Base A");
    }

}

public abstract class B:A{
    public abstract override void Trampar();
    public static int i=10;
    private int _horas;
    public int horas{
        get{return _horas;}
        set{ _horas=value;}
    }

    public abstract string Nome{get;set;}

}

public class C:B{
    public override void Trampar()
    {
        Console.WriteLine("Classe C subclasse de B");
    }
    private string _nome;

    public override string Nome{
        get{return _nome;}
        set{_nome=value;}
    }

    
}

public class D:C{
    public sealed override void Trampar()
    {
        Console.WriteLine("Selando este método");
    }
}

public class E:D{
    /*public sealed override void Trampar(){
    não é possível substituir o membro herdado "D.Trampar()" porque ele é sealed
    }*/
    
}

public class Principal{
    static void Main(){
        A a = new A();
        C c = new C();
        D d = new D();

        a.Trampar();
        c.Trampar();
        d.Trampar();
    }
}