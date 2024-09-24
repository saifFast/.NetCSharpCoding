using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicOfC_
{
    internal class Datastructure
    {
        public void Start()
        {
            //Array();
            //ListAndLinkedList();
            //Stack();
            //Queue();
        }

        public void Array()
        {
            int[] array = new int[5];
            string[] strings = new string[5];

            array[0] = 1;
            strings[0] = "Saif";

            Console.WriteLine(array[0]);
            Console.WriteLine(strings[0]);
        }

        public void ListAndLinkedList()
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddBefore(linkedList.First, 3);

            foreach(var listItem in linkedList)
            {
                Console.WriteLine(listItem);
            }
        }

        public void Stack()
        {
            var ints = new Stack<int>();
            ints.Push(1);
            ints.Push(2);
            PrintStack(ints);
            ints.Pop();
            PrintStack(ints);

            void PrintStack(Stack<int> stack)
            {
                foreach(var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Queue()
        {
            var queue = new Queue<int>();
            var queue2 = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue2.Enqueue(1);
            queue2.Enqueue("Saif");
            queue2.Enqueue(3.5);

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            foreach (var item in queue2)
            {
                Console.WriteLine(item);
            }


        }

        public void HashTableExample()
        {
            var ht = new Hashtable();

            ht.Add("a", "a");
            ht.Add("b", "b");
            ht.Add("c", "c");

        }

    }
}
