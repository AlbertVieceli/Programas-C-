using System;
// ACESSORES GET E SET

class Carro{
    private int velMax;
    public int vm{ // GET E SET
        get{//LEITURA
            return velMax;
        }set{//ESCRITA
            if(value<0){
                velMax=0;
            }else if(value>300){
                velMax=300;
            }else{
                velMax=value;
            }
        }
    }
    public Carro(){
        //this.velMax=120;
        vm = 120; //usando diretamente o método get e set vm
    }
    
}

class Aula41{
    static void Main(){
        Carro c1=new Carro();
        c1.vm=200; // Usando o SET para atribuir
        Console.WriteLine("Velocidade:{0}",c1.vm);// Usando o GET para ler
        // sem acesso a velMax, mas com acesso a vm

    }
}