using System;
using System.Collections;
using System.Collections.Generic;

namespace _13_01
{
    class Fibonacci : IEnumerable
    {
        int a0 = 1, a1 = 1, n;
        public Fibonacci(int n)
        {
            this.n = n;
        }

        public IEnumerator GetEnumerator()
        {
            return new FibonacciEnumerator(n);
        }

        class FibonacciEnumerator: IEnumerator
        {
            int position = 0;
            int a0 = 0, a1 = 1, n;
            public FibonacciEnumerator(int n = 10) { this.n = n; }

            public object Current => a0;

            public bool MoveNext()
            {
                if (position < n)
                {
                    int a2 = a0 + a1;
                    a0 = a1;
                    a1 = a2;
                    position++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                position = 0;
                a0 = 1; a1 = 1;
            }
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new(int.Parse(Console.ReadLine()));
            foreach (var i in fibonacci)
                Console.WriteLine(i);
        }
    }
}
