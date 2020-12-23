using System;
using System.Collections.Generic;
//Linkedlist / LISTA DUPLAMENTE ENCADEADA
class Aula56{
    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();//instanciando e criando o construtor

        transp.AddFirst("Carro");// add no inicio da lista
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");//INICIO

        transp.AddLast("Bicicleta");// add no final

        LinkedListNode<string>no; //add antes 
        no=transp.FindLast("Navio");
        transp.AddAfter(no, "Patinete");
        
        no=transp.FindLast("Navio");//add depois
        transp.AddBefore(no, "Patins");

        //transp.Clear();

        //ACHAR ELEMENTO
        if(transp.Find("Carro")==null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Elemento encontrado");
        }

        //REMOVER ELEMENTO
        //transp.Remove("Navio");

        transp.RemoveFirst();//remove o primeiro
        transp.RemoveLast();//remove o ultimo

        foreach(string t in transp){
            Console.WriteLine("Transporte:{0}",t);
        }
    }
}