using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyArrayStack;

namespace StackTest
{
    public class Class1
    {
        [Test]
        public void push()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("2");
            string expected = "2";
            Assert.AreEqual(expected, stack.Peek());
        }

        [Test]
        public void count()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            stack.Push("5");
            stack.Push("6");
            stack.Push("7");
            stack.Push("8");
            stack.Push("9");
            int expected = 9;
            Assert.AreEqual(expected, stack.Count());

        }
        [Test]
        public void peek()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            stack.Push("5");
            //stack.Pop();
            string expected = "5";
            Assert.AreEqual(expected, stack.Peek());

        }
        [Test]
        public void popeek()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("6");
            stack.Push("7");
            stack.Pop();
            string expected = "6";
            Assert.AreEqual(expected, stack.Peek());

        }
        [Test]
        public void count2()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("6");
            stack.Push("8");
            int expected = 2;
            Assert.AreEqual(expected, stack.Count());

        }


        [Test]
        public void containsTRUE()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(9);
            stack.Push(7);
            stack.Push(8);
            stack.Push(5);
            bool expected = true;

            Assert.AreEqual(expected, stack.Contains(5));
        }

        [Test]
        public void containsFALSE()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(9);
            stack.Push(7);
            stack.Push(8);
            stack.Push(5);
            bool expected = false;

            Assert.AreEqual(expected, stack.Contains(1));
        }


        [Test]
        [ExpectedException]
        public void ERROR1()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("p");
            stack.Push("o");
            stack.Pop();
            stack.Pop();
            stack.Peek();
        }
        [Test]
        [ExpectedException]
        public void ERROR2()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("l");
            stack.Push("o");
            stack.Pop();
            stack.Pop();
            stack.Pop();

        }
    }
}

