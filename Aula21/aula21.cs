using System;
//DO WHILE
class Aula21{
    static void Main(){
        int num = 5;
        while(num<5){
            Console.WriteLine("Não executa esse while");
        }

        do{
            Console.WriteLine("Esse executa pelo menos uma vez");
        }while(num<5);

        string senha="123";
        string senhauser;
        int tentativas = 0;
        do{ 
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser=Console.ReadLine();  
            tentativas++; 
        }while(senha != senhauser);

        Console.Clear();
        Console.WriteLine("Senha Correta, tentativas : {0}", tentativas);
    }
}