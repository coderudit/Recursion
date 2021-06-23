using System;
using System.Collections.Generic;
using Recursion.GFG;
using Recursion.Leetcode;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print
            //PrintValue printValue = new();
            //printValue.Print(10);
            #endregion

            #region SortAnArray
            //SortAnArray sortAnArray = new();
            //int[] arr = new int[] { 12, 11, 13, 5, 6 };
            //sortAnArray.SortArray(ref arr, 4);
            #endregion

            #region SortAStack
            //SortAStack sortAStack = new();
            //Stack<int> stack = new Stack<int>();
            //stack.Push(6); stack.Push(5); stack.Push(13); stack.Push(11); stack.Push(12);
            //sortAStack.SortStack(ref stack);
            #endregion

            #region DeleteMiddleElementOfStack
            //DeleteMiddleElementOfStack deleteMiddleElement = new();
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1); stack.Push(2); stack.Push(3); stack.Push(4); stack.Push(5);
            //deleteMiddleElement.DeleteMiddleElement(ref stack);
            #endregion

            #region 
            //ReverseAStack reverseAStack = new();
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1); stack.Push(2); stack.Push(3); stack.Push(4); stack.Push(5);
            //reverseAStack.ReverseStack(ref stack);
            #endregion

            #region PermutationOfAString
            //PermutationOfAString permutationOfAString = new();
            //char[] arr = new char[] { 'A', 'B', 'C' };
            //permutationOfAString.Permutate(arr, 0, new char[arr.Length], new int[arr.Length]);
            #endregion

            #region SubsetOfAString
            SubsetOfAString subsetOfAString = new();
            subsetOfAString.Subset("ABC", string.Empty, 0);
            #endregion

            #region 
            //_779_KthSymbolInGrammar _779_KthSymbol = new();
            //_779_KthSymbol.kthGrammar(1, 1);
            #endregion

            #region _897_IncreasingOrderSearchTree
            var tree = new TreeNode()
            {
                val = 5,
                left = new TreeNode
                {
                    val = 3,
                    left = new TreeNode
                    {
                        val = 2,
                        left = new TreeNode
                        {
                            val = 1
                        }
                    },
                    right = new TreeNode
                    {
                        val = 4
                    }
                },
                right = new TreeNode
                {
                    val = 6,
                    right = new TreeNode
                    {
                        val = 8,
                        left = new TreeNode
                        {
                            val = 7
                        },
                        right = new TreeNode
                        {
                            val = 9
                        }
                    }
                }
            };
            _897_IncreasingOrderSearchTree increasingOrderSearchTree = new();
            increasingOrderSearchTree.IncreasingBST(tree);
            #endregion

            #region _938_RangeSumofBST
            //var tree = new TreeNode()
            //{
            //    val = 10,
            //    left = new TreeNode
            //    {
            //        val = 5,
            //        left = new TreeNode
            //        {
            //            val = 3,
            //            left = new TreeNode { val = 1 }
            //        },
            //        right = new TreeNode
            //        {
            //            val = 7,
            //            left = new TreeNode { val = 6 }
            //        }
            //    },
            //    right = new TreeNode
            //    {
            //        val = 15,
            //        left = new TreeNode { val = 13 },
            //        right = new TreeNode { val = 18 }
            //    }
            //};
            //_938_RangeSumofBST rangeSumofBST = new();
            //rangeSumofBST.RangeSumBST(tree, 6, 10);
            #endregion
        }
    }
}
