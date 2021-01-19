using System;
public class BC{
    public void MM(){
        Console.WriteLine("BC metodo");

    }
}

public class DC : BC{
     public new void MM(){
        Console.WriteLine("DC metodo");
    }
    public static void Main(){
    BC b = new BC();
    DC d = new DC();

    b.MM();
    d.MM();
}
}

