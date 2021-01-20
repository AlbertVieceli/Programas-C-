using System;
//INTERFACES

public interface IVeiculo{ //para implementar em outras classes
// NÃO PODE CONTER ATRIBUTOS NEM CONSTRUTORES
void ligar();
void desligar();
void info();
}

public interface ICombate{
void disparar();
}

class Carro:IVeiculo,ICombate{ //tem que implementar tudo da interface
    public bool ligado;
    private int municao;
    public Carro(){
       setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao=qtde;
        Console.WriteLine("Munição total = {0}",this.municao);
    }
    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }

    public void info(){

    }
    public void disparar(){

    }
}
class Aula43{
    static void Main(){
        Carro c1=new Carro();

    }
}