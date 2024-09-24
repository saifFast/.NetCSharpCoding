using System;

namespace BasicOfC_
{
    internal class DelegateExample
    {
        public void Start()
        {
            MyDelegate @delegate = GreetMorning;
            @delegate("Saif");
            @delegate = PrintName;
            @delegate("Saif");
        }

        public delegate void MyDelegate(string name);

        public static void GreetMorning(string name)
        {
            Console.WriteLine("Hi : " + name);
        }

        public static void PrintName(string nameOfPerson)
        {
            Console.WriteLine($"{nameOfPerson}");
        }
    }
}
