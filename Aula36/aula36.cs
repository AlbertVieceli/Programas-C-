using System;
//MEMBROS PROTECTED

class Veiculo{ //Base
    public int velAtual;
    private int velMax;// private restringe o acesso somente pela classe, preciso usar get e set
    protected bool ligado;// protected permite acesso pelas classes filhas/derivadas somente por CLASES

    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getvelMax(){
        return velMax;
    }
}


class Carro:Veiculo{ //derivada de Veiculo
    public string nome;

    public Carro(string nome, int vm):base(vm){
        this.nome=nome;
        ligado = true;
    }
}
class Aula36{
    static void Main(){
        Carro carro=new Carro("Ferrari", 250);

        Console.WriteLine("Nome: {0}", carro.nome);
        Console.WriteLine("Vel.Max: {0}", carro.getvelMax());
        Console.WriteLine("Ligado: {0}", carro.getLigado());
    }
}