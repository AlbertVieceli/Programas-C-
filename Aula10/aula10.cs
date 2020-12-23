using System;
//ENUM
    class Aula10{
        enum DiasSemana{domingo,segunda,terca,quarta,quinta,sexta,sabado};
        static void Main(){
            
            //DiasSemana ds = DiasSemana.domingo;
            //DiasSemana ds = (DiasSemana)3;
            int ds =(int)(DiasSemana.sexta);
        
            Console.WriteLine(ds);
        }
    }