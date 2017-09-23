using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayStack
{
        interface IStack<T>
        {
            void Push(T element);
            T Pop();
            T Peek();
            bool Contains(T a);

        }
    }
