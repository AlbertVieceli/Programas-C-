using System;
//STRUCT n funciona como classe mas tem construtores

//Não possui construtor vazio. Você é obrigado a ter construtores com parâmetros
//Você é obrigado a atribuir valor às variáveis locais ao criá-las. Não pode “deixar pra depois”.
struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }

    public void info(){
        Console.WriteLine("---------------------");
        Console.WriteLine("Marca.:{0}", this.marca);
        Console.WriteLine("Modelo:{0}", this.modelo);
        Console.WriteLine("Cor...:{0}", this.cor);
    }

}

class Aula44{
    static void Main(){
        
        Carro c1; //criando o objt da struct
        c1.marca="VW";
        c1.modelo="Golf";
        c1.cor="Azul";

        Console.WriteLine("Marca.:{0}", c1.marca);
        Console.WriteLine("Modelo:{0}", c1.modelo);
        Console.WriteLine("Cor...:{0}", c1.cor);

        Carro c2=new Carro("Honda","HRV","Vermelho"); // instanciando normalmente

        Console.WriteLine("---------------------");
        Console.WriteLine("Marca.:{0}", c2.marca);
        Console.WriteLine("Modelo:{0}", c2.modelo);
        Console.WriteLine("Cor...:{0}", c2.cor);

        Carro c3=new Carro("Fiat","500","Prata");

        c3.info();
    }
}