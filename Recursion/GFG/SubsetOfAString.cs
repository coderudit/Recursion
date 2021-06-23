using System;

namespace Recursion.GFG
{
    class SubsetOfAString
    {
        internal void Subset(string input, string output, int index)
        {
            if (input.Length == (index))
            {
                Console.WriteLine(output);
                return;
            }
            string output1 = output + input[index].ToString();
            string output2 = output + string.Empty;
            Subset(input, output1, index + 1);
            Subset(input, output2, index + 1);
        }
    }
}
