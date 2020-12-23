using System;
//ARGUMENTOS DE ENTRADA DO PROGRAMA
class Aula51{
    static void Main(string[] args){ //VAI RECEBER OS ARGUMENTOS NA CHAMADA NO TERMINAL

        Console.WriteLine("Alberto");

        int res=0;

        if(args.Length>0){
            Console.WriteLine("Qtde de argumentos: {0}",args.Length);
            for(int i=0;i<args.Length;i++){
                //Console.WriteLine("Argumento: {0}:{1}",i,args[i]); //mostrar cada argumento
                res+=Int32.Parse(args[i]); //soma dos argumentos
            }
            Console.WriteLine("Soma:{0}", res);
        }else{
            Console.WriteLine("Não foram passados argumentos");
        }

    }
}

/*dotnet run 10 4 5
Alberto
Qtde de argumentos: 3
Argumento: 0:10
Argumento: 1:4
Argumento: 2:5*/