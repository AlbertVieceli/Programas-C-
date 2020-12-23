using System;
using System.Collections.Generic;
// QUEUE (FILA)




class Aula59{
    static void Main(){

        //string[] vs={"Carro","Moto","Navio", "Avião"};
        Queue<String>veiculos=new Queue<string>();

        veiculos.Enqueue("Carro");// Adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        Console.WriteLine("Tamanho fila: "+veiculos.Count);

        //verifica se existe elemento
        string v="Avião";
        if(veiculos.Contains(v)){
            Console.WriteLine("Contem "+v);
        }else{
            Console.WriteLine("Não contem "+v);
        }


        //veiculos.Clear();

        Console.WriteLine("Primeiro Veiculo: "+veiculos.Dequeue()); //dequeue retorna o primeiro elemento e remove
        Console.WriteLine("Tamanho fila: "+veiculos.Count);
        Console.WriteLine("Primeiro Veiculo: "+veiculos.Peek()); //Peek só retorna
        Console.WriteLine("Tamanho fila: "+veiculos.Count);
        
        //lendo e removendo elementos
        foreach (string veic in veiculos)
        {
            Console.WriteLine("veiculo removido "+veic);
        }
        Console.WriteLine("Tamanho fila: "+veiculos.Count);
        while (veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho fila: "+veiculos.Count);
    }
}