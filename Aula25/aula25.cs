using System;
//passagem por valor e por referencia
class Aula25{
    static void Main(){
        int num=10;
        dobrar(ref num); //com o ref, se se cria uma nova posição na memoria, se usa a msm 
        Console.WriteLine(num);
    }

    static void dobrar(ref int valor){ //por referencia
        valor*=2;
    }

    static void dobrar2(int valor){ //por valor
        valor*=2;
    }
}