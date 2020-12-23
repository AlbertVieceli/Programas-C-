using System;
//LENDO VALORES DO TECLADO
class Aula08{
    static void Main(){
        int v1,v2,soma;
        string nome;
        /*Console.Write("Digite o seu nome: ");
        nome=Console.ReadLine();
        Console.WriteLine("Nome digitado: {0}", nome);*/

        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine()); //int.Parse() para converter string para int
        Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 para int de 32 bits
        soma=v1+v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}",v1,v2,soma);

    }
}