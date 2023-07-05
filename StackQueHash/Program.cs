using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueHash
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(40);
            stack.Push("Today");
            stack.Push("Text");

            //stack.Pop();
            Console.WriteLine($"Top element in the stack = {stack.Peek()}");

            foreach(var item in stack)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("-------------Queue---------------------");

            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.Enqueue("today");

            queue.Dequeue();

            Console.WriteLine($"Top element in the queue = {queue.Peek()}");
            Console.WriteLine($"Total element in the queue = {queue.Count}");

            Console.WriteLine("-----------------Hashtable-------------");



            Hashtable day = new Hashtable();
            day.Add(1, "Monday"); 
            day.Add(2, "Thesday");
            day.Add(3, "Wednesday");
            day.Add(4, "Thursay");

            foreach(DictionaryEntry item in day)
            {
                Console.WriteLine(item.Key +" "+ item.Value);
            }




        }
    }
}
