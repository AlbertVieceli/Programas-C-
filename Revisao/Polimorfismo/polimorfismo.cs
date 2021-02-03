using System;


namespace Teste
{   
    public class A{
        public int x =10;
        public int X { get; private set; }

        public A(){
            Console.WriteLine("constructor");
        }

        public virtual int Abismo(){
            return x;
        }
    }

    public class B:A{
        int x = 15; //sobreescrevendo campo
        public int X { get; private set; } //sobreescrvendo propriedade

        public B(){
            Console.WriteLine("constructor de B");
        }

        public sealed override int Abismo(){
            return x;
        }
    }
    class Polimorfismo
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            
            Console.WriteLine($"valor de x é: {a.Abismo()}");
            Console.WriteLine($"valor de x é: {b.Abismo()}");
        }
    }
}
