using System;
//MÉTODOS PARA ARRAYS
class Aula23{
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random=new Random();
        for(int i=0;i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);// next pode ser sem valor(), min e max(5,100)ou só max(50)
        }

        Console.WriteLine("Elementos do Vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array,valor); retorno -1 ->não esta no array
        Console.WriteLine("BinarySearch");
        int procurado=33;
        int pos = Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}",procurado, pos);
        Console.WriteLine(new string('-',50));

        //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine(new string('-',50));

        //public void CopyTo(Ar_destino,a partir desta posição);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine(new string('-',50));

        //public int GetLongLenght(dimensão) 
        Console.WriteLine("GetLongLenght");     
        long qtdeElementos=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtdeElementos);
        Console.WriteLine(new string('-',50));


        //public int GetLowerBound(dimensão) -> vetor 1D, ou seja, 0. Na matriz precisa indicar qual
        Console.WriteLine("GetLowerBound");     //i=0 menor indice, j=1 maior indice
        int MenorIndiceVetor=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz=matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor1 {0}",MenorIndiceVetor);
        Console.WriteLine("Menor indice do matriz {0}",MenorIndiceMatriz);
        Console.WriteLine(new string('-',50));


        //public int GetUpperBound(dimensão) -> vetor 1D, ou seja, 0. Na matriz precisa indicar qual
        Console.WriteLine("GetUpperBound");     //i=0 menor indice, j=1 maior indice
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz=matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do vetor1 {0}",MaiorIndiceVetor);
        Console.WriteLine("Maior indice do matriz {0}",MaiorIndiceMatriz);
        Console.WriteLine(new string('-',50));

        //public object GetValue(long indice)
        Console.WriteLine("GetValue");     //i=0 menor indice, j=1 maior indice
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}",valor0);
        Console.WriteLine("Valor da posição (1,3) da matriz {0}",valor1);
        Console.WriteLine(new string('-',50));

        //public static int IndexOf(array,valor)
        Console.WriteLine("IndexOf");     
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Indice do primeiro valor 3:{0}",indice1);
        Console.WriteLine(new string('-',50));

        //public static int LastIndexOf(array,valor)
        Console.WriteLine("LastIndexOf");     
        int indice2=Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Indice do ultimo valor 3:{0}",indice2);
        Console.WriteLine(new string('-',50));

        //public static void Reverse(array);
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        //public static void Sort(array);
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("vetor1");
        foreach(int n in vetor1){
            Console.Write("{0} ",n);
        }

    }
}