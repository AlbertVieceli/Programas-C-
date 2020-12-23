using System;
//OPERADORES E OPERAÇÕES
namespace HelloWorld
{
    class Aula05
    {
        static void Main(string[] args)
        {
            //bool res=10<5;
            //bool res=10!=5;
            
            //& AND, | OR, ! NOT
            bool res = (5>7)&&(10<5);
            int num=10;
            //num+=1; // * + - /
            num++;
           //int res=(10+5)*2;
           
           Console.WriteLine(res);
           Console.WriteLine(num);
        }
    }
}