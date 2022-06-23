using System;

namespace ReadOnly_Variable
{
    class Program
    {
        readonly int pei;

        Program(int num)
        {
            this.pei = num;
        }



        static void Main(string[] args)
        {
            Program obj = new Program(10);
            Console.WriteLine("Readonly variable :" + obj.pei);

            Program obj1 = new Program(100);
            Console.WriteLine("Readonly variable :" + obj1.pei);

            Program obj2 = new Program(1000);
            Console.WriteLine("Readonly variable :" + obj2.pei);
        }
    }
}
