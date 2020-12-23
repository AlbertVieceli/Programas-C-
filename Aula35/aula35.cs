using System;
//HERANÇA, CONSTRUTOR DE CLASSE BASE E TERNÁRIOS
class Veiculo{ //Classe base/mãe
    public int velMax;
    private bool ligado;
    private int rodas;

    public Veiculo(int rodas){
        this.rodas=rodas;
    }

    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public string getLigado(){
        return(ligado?"sim":"não"); //OLHA O TERNÁRIO FILHO DA PUTA expressão?seForTrue:seForFalse
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
            if(rodas<0){
                this.rodas=0;
            }else if (rodas>40){
                this.rodas=40;
            }else{
                this.rodas=rodas;
            }
    }
}

class Carro:Veiculo{ //classe base:classe derivada CLASSE DERIVADA/FILHA

    public string nome, cor;
    public Carro(string nome, string cor):base(4){ //:base() inicia o construtor de veiculos
        desligar();                                //tipo um super() em java
        velMax=120;
        this.nome=nome;
        this.cor=cor;
        

    }
}

class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("Carro de combate","Verde"){
        municao=100;
        setRodas(6);

    }
}

class Aula35{
    static void Main(){
         Carro c1 = new Carro("Rapidão", "vermelho");
         CarroCombate cc1 = new CarroCombate();
         c1.ligar();
         Console.WriteLine("Cor {0}",c1.cor);
         Console.WriteLine("Nome {0}",c1.nome);
         Console.WriteLine("Rodas {0}",c1.getRodas());
         Console.WriteLine("Vel.Máxima {0}", c1.velMax);
         Console.WriteLine("Ligado? {0}", c1.getLigado());
         Console.WriteLine(new string('-',50));

         Console.WriteLine("Cor {0}",cc1.cor);
         Console.WriteLine("Nome {0}",cc1.nome);
         Console.WriteLine("Rodas {0}",cc1.getRodas());
         Console.WriteLine("Vel.Máxima {0}", cc1.velMax);
         Console.WriteLine("Ligado? {0}", cc1.getLigado());
        
        
        

    }
}