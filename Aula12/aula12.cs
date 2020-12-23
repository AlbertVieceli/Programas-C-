using System;
//CONDICIONAL IF
class Aula12{
    static void Main(){
        int nota = 80;
        string resultado = "Reprovado";

        if (nota >= 60)
        {
            resultado = "Aprovado";
            //Console.WriteLine(resultado);
        }

        Console.WriteLine("Resultado: {0}", resultado);
    }
}