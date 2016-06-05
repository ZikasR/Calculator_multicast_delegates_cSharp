using System;

namespace ConsoleApplication
{
    public class Program
    {
        delegate void Operator (int x, int y); 
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Operator o = Add;
            o += Multiply;
            o += Substract;
            o(int.Parse(args[0]), int.Parse(args[1]));
            
        }
        
        static void Add (int x, int y) => Console.WriteLine("Addition : {0}", x + y);
        static void Multiply (int x, int y) => Console.WriteLine("Multiplication : {0}", x * y);        
        static void Substract (int x, int y) => Console.WriteLine("Sustraction : {0}", x - y);
    }
}
