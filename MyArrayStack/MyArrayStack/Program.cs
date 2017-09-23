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
            Stack<int> stack = new Stack<int>();

            stack.Push(7);
            stack.Push(9);
            stack.Push(2);
            stack.Push(8);
            stack.Push(7);
            stack.Push(15);
            stack.Push(7);

            int a = 7;
            if (stack.Contains(a) == true) Console.WriteLine("Элемент " + a + " найден");

            Console.WriteLine("Размер стека равен " + stack.Count);
            Console.WriteLine("Верхушка стека - это " + stack.Peek());
            int count = stack.Count;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("Элемент номер " + stack.Count + " равен " + stack.Pop());
            }


            Console.ReadKey();
        }
    }
}
