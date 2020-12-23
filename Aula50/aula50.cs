using System;
//DELEGATES

delegate int Op(int n1, int n2); //DELEGATE
class Mat{
    public static int soma(int n1, int n2){
        return n1 + n2;
    }

    public static int multi(int n1,int n2){
        return n1*n2;
    }
}

class aula50{
    static void Main(){

        int res;

        Op d1 = new Op(Mat.soma); //instanciando o delegate com o método static referenciando a class

        res = d1(10,50);

        Console.WriteLine("Soma: {0}", res);

        d1 = new Op(Mat.multi); //alterando o método do delegate

        res=d1(10,50);

        Console.WriteLine("Multiplicação: {0}", res);

    }
}