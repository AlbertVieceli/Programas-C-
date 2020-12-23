using System;
//MÉTODOS E VARIÁVEIS ESTATICOS

class Mat{
    public static double pi= 3.14;

    public static int dobro(int n){
        return n*2;
    }
}

class Aula49{
    static void Main(){
        //PARA CHAMAR UM MÉTODO OU VARIÁVEL STATIC TEM QUE REFERENCIAR A SUA CLASSE
        double vpi= Mat.pi; //não precisa criar o objeto da classe Mat
        Console.WriteLine(vpi);
        int num = 10;
        Console.WriteLine(Mat.dobro(num)); //não precisa criar o objeto da classe Mat

    }
}