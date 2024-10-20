
using System;

namespace Test //collection of classes
{
    internal class Program // collection of variable and functions
    {
        static void Main(string[] args) // code to executed
        {
            Vehicle<int>   v = new Vehicle<int>();
            v.PrintValue();

            Vehicle<string> v2 = new Vehicle<string>();
            v2.PrintValue();

            Machine obj = new Machine();
            PrintMessage p = new PrintMessage(obj.PrintValue);
            p("Saif");

            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(add(3,4));

            Console.ReadLine();

        }

        

        public delegate void PrintMessage(string message);

        public class Machine
        {
            public void PrintValue(string value)
            {
                Console.WriteLine(value);
            }
        }
    }
}
