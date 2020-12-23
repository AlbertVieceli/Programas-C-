using System;
using System.Collections.Generic;
// COLEÇÃO LIST
class Aula57{
    static void Main(){
        List<string> carros= new List<string>();
        String[] carros2= new string[10];
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros);// recebendo elemetos de outro list


        //carros.Clear();
        if(carros.Contains("Gol")){ //se esta na lista
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não esta na lista");
        }

        carros.CopyTo(carros2,2);// copia da lista para um vetor
        //neste caso a partir do elemento 2

        carros.Insert(1,"Cruze"); //insere elemento em determ posição

        int pos2=carros.LastIndexOf("HRV");

        //carros.Remove("Argo");
        //carros.RemoveAt(0);

        //carros.Reverse();
        carros.Sort();

        int tamanho=carros.Count;
        carros.Capacity=15;
        int capa=carros.Capacity;

        Console.WriteLine("Tamanho {0}", tamanho);
         Console.WriteLine("Capacidade {0}", capa);

        foreach (string c in carros)
        {
            Console.WriteLine("Carro: {0}", c);
        }

        string ca="HRV";
        int pos=0;
        pos=carros.IndexOf(ca);
        Console.WriteLine("Carro {0} esta na posição {1}",ca,pos);
        Console.WriteLine("Ultimo HRV esta na pos {0}",pos2);
    }
}