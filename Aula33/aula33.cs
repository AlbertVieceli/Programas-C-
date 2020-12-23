using System;
//Private e Public
class Jogador{
    private int energia;
    private string nome;
    public Jogador(String nome){
        this.nome = nome;
        energia=100;
    }
    public int getEnergia(){
        return energia;
    }
    public string getNome(){
        return nome;  
    }
    public void setEnergia(int e){
        if(e<0){
            if(energia+e < 0){
                energia=0;
            }else{
                energia+=e;
            }
        }else if(e>0){
             if(energia+e > 100){
                energia=100;
            }else{
                energia+=e;
            }
        }
    }

}



class Aula33{
    static void Main(){
        Jogador j1=new Jogador("Bruno");

        j1.setEnergia(-30);

        Console.WriteLine("Nome do jogador é {0}",j1.getNome());
        Console.WriteLine("Energia é {0}",j1.getEnergia());
    }
}