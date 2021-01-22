using System;

public class Work{
    public virtual void DoWork(int i){

    }
}

public abstract class A:Work{
    public abstract override void DoWork(int i);
    //Se um método virtual for declarado abstract, 
    //ele ainda será virtual para qualquer classe que herdar da classe abstrata
}

public class B:A
{
    public override void DoWork(int i){

    }
}

public class MaaM
{
    static void Main(){
        Work w = new Work();
        B b = new B();
        //A a = new A();
        

    }
    
}