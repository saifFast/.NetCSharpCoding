

using System;
using System.Collections.Generic;

namespace BasicOfC_
{
    internal class Generics
    {
        public void Start()
        {
            var list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var listObjects = new List<SampleModel>();

            listObjects.Add(new SampleModel() { Id = 1, Name = "Saif" });
            listObjects.Add(new SampleModel() { Id = 2, Name = "Khan" });
            listObjects.Add(new SampleModel() { Id = 3, Name = "Hakro" });
            listObjects.Add(new SampleModel() { Id = 4, Name = "C#" });

            foreach (var obj in listObjects)
            {
                Console.WriteLine("ID:" + obj.Id);
                Console.WriteLine("Name:" + obj.Name);
            }

        }
    }
}
