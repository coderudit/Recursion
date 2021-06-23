using System.Collections.Generic;
using System.Linq;

namespace Recursion.GFG
{
    class SortAStack
    {
        internal void SortStack(ref Stack<int> stack)
        {
            if (stack.Count == 0)
                return;
            int popElement = stack.Pop();
            SortStack(ref stack);
            Insert(ref stack, popElement);
        }

        void Insert(ref Stack<int> stack, int currentValue)
        {
            if(stack.Count() == 0 || stack.Peek() > currentValue)
            {
                stack.Push(currentValue);
            }
            else
            {
                int element = stack.Pop();
                Insert(ref stack, currentValue);
                stack.Push(element);
            }
        }
    }
}
