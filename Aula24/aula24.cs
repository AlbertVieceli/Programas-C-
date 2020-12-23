using System;
//metodos
class Aula24{
    static void Main(){
        int v1,v2,r;
        v1=Convert.ToInt32(Console.ReadLine());
        v2=Convert.ToInt32(Console.ReadLine());
        //soma(v1,v2);
        r=soma2(v1,v2);
        Console.WriteLine("A soma de {0} com {1} é: {2} ", v1,v2,r);
        //Console.WriteLine("A soma de {0} com {1} é: {2} ", v1,v2,soma2(v1,v2));

        /*for(int i=0;i<10;i++){
            soma(10,5);
        }*/
    }

    /*static void nome(){ //metodo sem retorno e parametros

    }*/
    public static void soma(int n1, int n2){ //metodo com parametros
        int res=n1+n2;
        Console.WriteLine("A soma de {0} com {1} é: {2} ", n1,n2,res);
    }

    public static int soma2(int n1, int n2){ //metodo com retorno e parametros
        int res=n1+n2;
        return res;
    }
}