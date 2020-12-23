using System;
//VARIÁVEIS
class Aula03{
    static void Main(){
        byte n1=10; //entre 0 e 255
        int num=-10;
        char letra='c';
        float valor=5.3f;
        string nome="Bruno";

        int num1,num2,res;
        num1=10;
        num2=2;
        res = num1 * num2;
        Console.WriteLine("A multiplicação de "+ num1+ " mais " + num2 + " é igual a : " + res);

        var aux=nome; //ajusta o tipo automaticamente

        //Console.WriteLine("valor da variavel: "+ aux);
    }
}