using System;
//CLASSES sobrecarga de construtores
public class Jogador{ //se não uso nenhum modificador, então é publica, como a Aula28
    public int energia;
    public bool vivo;
    public string nome; //global
    public Jogador(string n/*nome*/){ //construtor com escopo local
        energia=100;
        vivo=true;
        nome=n;
        //this.nome=nome;
    }
     public Jogador (){
        energia=100;
        vivo=true;
        nome="Carlins";
    }
    public Jogador (string n,int e){
        energia=100;
        vivo=true;
        nome=n;
    }
    public Jogador (string n,int e,bool v){
        energia=e;
        vivo=v;
        nome=n;
    }
    public void info(){
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}\n", vivo);
    }
        ~Jogador(){
        Console.WriteLine("Jogador destruido");
    }
}
class Aula30{
    static void Main(){
        
    
        Jogador j1 = new Jogador();//chamando e passando parametros para o construtor
        Jogador j2 = new Jogador("Albert");
        Jogador j3 = new Jogador("teho",100);
        Jogador j4 = new Jogador("Aziro",0,false);
        

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}