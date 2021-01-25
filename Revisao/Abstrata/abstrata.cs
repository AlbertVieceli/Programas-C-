using System;

public class A{
    public virtual void Trampar(){
        Console.WriteLine("Classe Base A");
    }

}

public abstract class B:A{
    public abstract override void Trampar();

}

public class C:B{
    public override void Trampar()
    {
        Console.WriteLine("Classe C subclasse de B");
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