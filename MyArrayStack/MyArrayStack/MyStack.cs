using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayStack
{
    public class MyStack<T> : IStack<T>
    {
        T[] elements;
        int count;
        const int array_size = 6;
        public MyStack()
        {
            elements = new T[array_size];
        }
        public MyStack(int length)
        {
            elements = new T[length];
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Count()
        {
            return count;
        }

        public void Push(T element)
        {
            if (count == elements.Length)
            {
                T[] newArray = new T[2 * elements.Length];
                Array.Copy(elements, 0, newArray, 0, count);
                elements = newArray;
            }
            elements[count++] = element;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("Стек пуст");
            T element = elements[--count];
            return element;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("Стек пуст");
            return elements[count - 1];
        }

        public bool Contains(T a)
        {
            int q = 0;
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(a))
                { q++; }
            }

            bool n = q > 0;
            return n;
        }
    }
}
