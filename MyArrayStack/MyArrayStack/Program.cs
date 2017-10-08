using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> _mystack = new MyStack<int>();

            _mystack.Push(1);
            _mystack.Push(2);
            _mystack.Push(3);
            _mystack.Push(4);
            _mystack.Push(5);
            _mystack.Push(6);
            _mystack.Push(7);
            _mystack.Push(8);

            Console.WriteLine("Count - " + _mystack.Count());
            Console.WriteLine("Peek - " + _mystack.Peek());
            Console.WriteLine("Pop1 - " + _mystack.Pop());
            Console.WriteLine("Pop2 - " + _mystack.Pop());
            Console.WriteLine("Peek2 - " + _mystack.Peek());
            Console.WriteLine("Count2 - " + _mystack.Count());
            _mystack.Push(66);
            Console.WriteLine("Peek3 - " + _mystack.Peek());
            bool contains1 = _mystack.Contains(66);
            Console.WriteLine(contains1 == true ? "66 есть" : "66 отсутствует");

            Console.WriteLine("Pop - " + _mystack.Pop());

            bool contains2 = _mystack.Contains(66);
            Console.WriteLine(contains2 == true ? "66 есть" : "66 отсутствует");
            Console.ReadKey();
        }
    }
}
