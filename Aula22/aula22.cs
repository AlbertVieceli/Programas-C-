using System;
//FOREACH
class Aula22{
    static void Main(){
        int[] num=new int[5]{11,22,35,44,55};

        /*for(int i=0;i<num.Length; i++){
            Console.WriteLine(num[i]);
        }*/

        foreach(int n in num){ //n recebe os valores de num
            Console.WriteLine(n);
        }
    }
}