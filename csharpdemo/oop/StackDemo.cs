using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    interface IStack
    {
        void Push(string name);
        string Pop();
        int Length
        {
            get;
        }
    }

    class MyStack : IStack
    {
        private string[] names = new string[10];
        private int top = 0;

        public int Length
        {
            get
            {
                return this.top;
            }
        }

        public string Pop()
        {
            this.top--;
            return this.names[this.top];
        }

        public void Push(string name)
        {
            this.names[this.top] = name;
            this.top++;
        }
    }

    class StackDemo
    {
        static void Main(string[] args)
        {
            IStack s = new MyStack();
            s.Push("C#");
            s.Push("Java");

            Console.WriteLine(s.Length);
            Console.WriteLine(s.Pop());
        }
    }
}
