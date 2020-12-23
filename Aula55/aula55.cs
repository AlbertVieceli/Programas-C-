using System;
using System.Collections.Generic; //biblio importada
//DICTIONARY-coleção de dados, valores relacionados com chaves

class Aula55{
    static void Main(){
        
        Dictionary <int,string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");
        
        //veiculos.Clear(); //limpa

        //veiculos.Remove(20); //remove

        Console.WriteLine("Tamanho do Dictionary:{0}", veiculos.Count);
        
        int chave=20; //Verifica a chave(int)
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A chave {0} esta na coleção", chave);
        }else{
            Console.WriteLine("A chave {0} não esta na coleção", chave);
        }

        veiculos[15]="Bicicleta"; //adicionando valor

        string valor="Bicicleta"; //Verifica o valor(string)
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("O Valor {0} esta na coleção", valor);
        }else{
            Console.WriteLine("O Valor {0} não esta na coleção", valor);
        }


        Dictionary <int,String>.ValueCollection valores=veiculos.Values;
        foreach(string v in valores){
            Console.WriteLine(v);
        }

        //Imprimindo o conteudo do dicstringionario
        /*foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine("Chave {0} valor {1}",v.Value, v.Key);
        }*/

    }
}