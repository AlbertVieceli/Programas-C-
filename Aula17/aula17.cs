using System;
//ARRAY/VETOR

class Aula17
{
    static void Main(){
        //int n1,n2,n3,n4,n5;
        int[] n = new int[5]; //vetor com 5 posições
        //int[] num = new int[3]{55,77,99};
        int[] num={55,77,99};
        string[] veiculos=new string[3];

        veiculos[0]="Carro";
        veiculos[1]="Avião";
        veiculos[2]="Navio";

        n[0]=111;
        n[1]=222;
        n[2]=333;
        n[3]=444;
        n[4]=555;

        Console.WriteLine("Valor do vetor é de {0}",n[0]);
        Console.WriteLine(num[2]);
        Console.WriteLine(new string('-',50));
        for(int i = 0; i<veiculos.Length;i++){
            Console.WriteLine(veiculos[i]);
        }
    }
}