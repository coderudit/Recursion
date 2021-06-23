using System.Collections.Generic;

namespace Recursion.GFG
{
    class ReverseAStack
    {
        internal void ReverseStack(ref Stack<int> stack)
        {
            if (stack.Count == 0)
                return;
            int value = stack.Pop();
            ReverseStack(ref stack);
            Insert(ref stack, value);
        }

        void Insert(ref Stack<int> stack, int element)
        {
            if (stack.Count == 0)
            {
                stack.Push(element);
                return;
            }
            int value = stack.Pop();
            Insert(ref stack, element);
            stack.Push(value);
        }
    }
}
