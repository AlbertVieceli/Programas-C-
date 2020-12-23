using System;
//SOBRECARGA DE MÉTODOS
class Calc{
    public int soma(int n1, int n2){
        return n1 + n2;
    }

    public int soma(int n1, int n2, int n3){ //MÉTODOS IGUAIS COM PARAMETROS DIFERENTES
        return n1 + n2 + n3;
    }

    public double soma(double n1, double n2){
        return n1 + n2;
    }

    public int soma(params int[]n){ //PARAMS aceita a entrada de inumeros valores
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }

    public double soma(params double[]n){ //PARAMS aceita a entrada de inumeros valores
        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }

}

class Aula47{
    static void Main(){
        
        //int res;

        Calc calc = new Calc();

        /*res=calc.soma(10,5);
        Console.WriteLine(res);

        res=calc.soma(10,5,69);
        Console.WriteLine(res);*/

        /*var res=calc.soma(10.5,25.99);
        Console.WriteLine(res);*/

        /*var res=calc.soma(10.5,25.99,44.4,56.79);
        Console.WriteLine(res);*/

        var res=calc.soma(5,6,33,24,53,12);
        Console.WriteLine(res);
    }
}