using System;
using System.Text;

namespace Recursion.Leetcode
{
    class _779_KthSymbolInGrammar
    {
        public int KthGrammar(int n, int k)
        {
            if (n == 1 && k == 1)
                return 0;
            int mid = (int)Math.Pow(2, n - 1) /2;
            if (k <= mid)
                return KthGrammar(n - 1, k);
            else
            {
                int value = KthGrammar(n - 1, k - mid);
                if (value == 1)
                    return 0;
                else
                    return 1;
            }
        }

        
    }
}
