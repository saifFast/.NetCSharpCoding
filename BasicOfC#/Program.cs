﻿using BasicOfC_.Design_Patterns;
using System;

namespace BasicOfC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var genercis = new Generics();
            //genercis.Start();

            //var DI = new DependecyInjection();
            //DI.Start();

            //var _Datastructure = new Datastructure();
            //_Datastructure.Start();

            //var Threading = new Threading();
            //Threading.Start();

            Singleton singleton = Singleton.Instance;
            singleton.ShowMessage();

            Console.ReadLine();            
        }       
    }
}
