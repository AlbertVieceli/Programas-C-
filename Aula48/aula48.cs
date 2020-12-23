using System;
//RECURSIVIDADE
class Calc{

    public int soma(params int[]n){ //PARAMS aceita a entrada de inumeros valores
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }

    public int fat(int n){ //FATORIAL
        int res;
        if(n<=1){
            res=1;
        }else{
            res=n*fat(n-1);
        }
        return res;
    }

}

class Aula48{
    static void Main(){
        
        Calc calc = new Calc();

        var res=calc.soma(5,6,33,24,53,12);
        Console.WriteLine(res);
        Console.WriteLine("--------------");
        int fat = calc.fat(5);
        Console.WriteLine(fat); //fATORIAL
    }
}