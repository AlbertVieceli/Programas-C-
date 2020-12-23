using System;
//CLASSES construtores e destrutores
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
    /*~Jogador(){ //destrutor
        Console.WriteLine("Jogador {0} foi deletado",nome);
    }*/
    ~Jogador(){
        Console.WriteLine("Jogador destruido");
    }
}
class Aula29{
    static void Main(){
        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1=Console.ReadLine();
        Jogador j1 = new Jogador(nome1);//chamando e passando parametros para o construtor
        Jogador j2 = new Jogador("Albert");
        

        //j1.energia=50;
        Console.WriteLine("Energia jogador 1: {0} de nome {1}", j1.energia, j1.nome);
        Console.WriteLine("Energia jogador 2: {0} de nome {1}", j2.energia, j2.nome);

    }
}