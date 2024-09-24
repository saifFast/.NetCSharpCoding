using System;

namespace BasicOfC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var genercis = new Generics();
            //genercis.Start();

            var DI = new DependecyInjection();
            DI.Start();


            Console.ReadLine();            
        }       
    }
}
