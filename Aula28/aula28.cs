using System;
//CLASSES
public class Jogador{ //se não uso nenhum modificador, então é publica, como a Aula28
    public int energia=100;
    public bool vivo=true;

}
class Aula28{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia=50;
        Console.WriteLine("Energia jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia jogador 2: {0}", j2.energia);

    }
}