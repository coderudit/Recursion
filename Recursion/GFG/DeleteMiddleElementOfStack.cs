using System.Collections.Generic;

namespace Recursion.GFG
{
    class DeleteMiddleElementOfStack
    {
        private static int count;
        private static int middleElementIndex;
        
        internal void DeleteMiddleElement(ref Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                middleElementIndex = count / 2;
                return;
            }
            count++;
            int element = stack.Pop();
            DeleteMiddleElement(ref stack);
            count--;
            if (middleElementIndex != count)
                stack.Push(element);
        }
    }
}
