using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicOfC_
{
    internal class Threading
    {
        public async void MakeItHappen(string str = "")
        {
            Console.WriteLine(str);
        }

        public async void Start()
        {
            Thread t1 = new Thread(SmallFunction);
            t1.Start();

            Thread t2 = new Thread(SmallFunction2);
            t2.Start();
        }

        public void SmallFunction()
        {
            MakeItHappen("A");
            MakeItHappen("B");
            MakeItHappen("C");
        }

        public void SmallFunction2()
        {
            
            MakeItHappen("D");
            MakeItHappen("E");
        }

    }
}
