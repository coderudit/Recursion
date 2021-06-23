using System;

namespace Recursion.GFG
{
    class PermutationOfAString
    {

        internal void Permutate(char[] arr, int visitedIndex, char[] resultArr, int[] visitedArr)
        {
            //If visited index has reached to the end, print it.
            if (visitedIndex == arr.Length)
                Console.WriteLine(resultArr);

            else
            {
                for (int index = 0; index < arr.Length; index++)
                {
                    if (visitedArr[index] == 0) //If it's not visited add it to resulting arr and mark it as visited, then again call Permutate
                    {
                        resultArr[visitedIndex] = arr[index];
                        visitedArr[index] = 1;
                        Permutate(arr, visitedIndex + 1, resultArr, visitedArr);
                        visitedArr[index] = 0;
                    }
                }
            }
        }
    }
}
