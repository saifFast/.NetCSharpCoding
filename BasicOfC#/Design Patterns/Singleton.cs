using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfC_.Design_Patterns
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hey");
        }
    }
}
