using System;
//Operações de Bitwise << ou >>
class Aula09{
   static void Main(){
       int num=10;//00001010
       num=num<<1; //<<DOBRA por 1
       Console.WriteLine("valor de num em <<: {0}", num);//20=00010100
       num=num>>1; //METADE por 1
       Console.WriteLine("valor de num em >>: {0}", num);//5=00000101
       num=2;//00000010
       num=num<<2; //<<DOBRA por 2
       Console.WriteLine("valor de num 2 em << 2: {0}", num);//8=00001000
    
   }
}