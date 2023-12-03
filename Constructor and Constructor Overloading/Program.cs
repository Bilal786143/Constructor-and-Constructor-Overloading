using System;

namespace Constructor_and_Constructor_Overloading
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Constructor--Default Constructor");
        }

        public Program(int a, int b)
        {
            Console.WriteLine("This is Int Constructor: {0}",(a+b));
        }

        public Program(float a, float b=12.2f)
        {
            Console.WriteLine("This is 3rd constructor:{0}",(a+b));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Program firstConstructor = new Program(10, 20);
            Program secondConstructor = new Program(10.23f, 1212.1f);
            Program thirdConstructor = new Program(10.23f);
            Console.ReadLine();
        }
    }
}
