using System;

namespace Recursion.GFG
{
    class PrintValue
    {
        internal void Print(int n)
        {
            //Base condition
            if (n == 0)
                return;

            //Console.WriteLine(n); //Head recursion
            Print(n-1);

            Console.WriteLine(n); //Tail recursion
        }
    }
}
