using System;
//Array de Struct
struct Carro{
    
    public string modelo;
    public string cor;

    public void info(){
        
        Console.WriteLine("Modelo:{0}", this.modelo);
        Console.WriteLine("Cor...:{0}", this.cor);
        Console.WriteLine("---------------------");
    }

}

class Aula45{
    static void Main(){
        
        int[]numeros = new int[10];

        Carro[] carros=new Carro[5];
        carros[0].modelo="HRV";
        carros[0].cor="Prata";

        carros[1].modelo="Golf";
        carros[1].cor="Rosa";

        carros[2].modelo="corsa";
        carros[2].cor="amarelo";

        carros[3].modelo="Chevette";
        carros[3].cor="Azul da cor do mar";

        carros[4].modelo="civic";
        carros[4].cor="Vermelho";

       for(int i=0; i<carros.Length;i++){
            carros[i].info();
       }
    }
} 