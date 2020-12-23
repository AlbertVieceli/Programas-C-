using System;
//P1 TRY-CATCH-FINALLY
//P2 TRY-CATCH-FINALLY

class Area{
    public static float Quad(float bas, float alt){
        if(bas == 0 || alt == 0){
            throw new Exception ("Base ou altura não podem ser zero");
        }
        return bas*alt;
    }
}

class Aula52{
    static void Main(){

        float area=0;

        /*int n1,n2,res;
        res=n1=n2=0;
        n1=10;
        n2=5;*/
        
        try{
            /*res=n1/n2;
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
            throw new Exception("Alberto");//lança uma exception mesmo se tiver correto*/
            area=Area.Quad(10F,0F);
            Console.WriteLine("Area do quad:{0}",area);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Exc: {0}", e.GetType());
            
        }finally{ //sempre executa
            Console.WriteLine("Fim do processo");
        }

        

    }
}