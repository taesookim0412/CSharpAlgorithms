using System;
using System.Collections.Generic;
using CSharpAlgorithms.Global;

namespace CSharpAlgorithms.Difficulties.Easy
{
    class Easy
    {
        public Easy()
        {
            TwoSum();
            ReverseString();
            MergeIntervals();
            UniquePaths();
            ReverseLinkedList();
            
        }
        public void TwoSum()
        {
            twoSum twoSumObj = new twoSum();
            int[] twoSumRes = twoSumObj.TwoSum(new int[] {2, 7, 11, 15}, 9);
            Array.ForEach(twoSumRes, (num) => Console.Write(num + " "));
            Console.WriteLine();
        }

        public void ReverseString()
        {
            ReverseString reverseStringObj = new ReverseString();
            string res = reverseStringObj.ReverseWords("the sky is blue");
            string res2 = reverseStringObj.ReverseWords("  hello world  ");
            string res3 = reverseStringObj.ReverseWords("a good   example");
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
        }

        public void MergeIntervals()
        {
            MergeIntervals mergeIntervalsObj = new MergeIntervals();
            int[][] inputs =
            {
                new int[] {1, 3},
                new int[] {2, 6},
                new int[] {8, 10},
                new int[] {15, 18}
            };
            int[][] res = mergeIntervalsObj.Merge(inputs);
            Array.ForEach(res, (num) => Console.Write($"[{num[0]} {num[1]}]"));
            Console.WriteLine();
        }

        public void UniquePaths()
        {
            uniquePaths uniquePaths = new uniquePaths();
            int res = uniquePaths.UniquePaths(3, 7);
            Console.WriteLine(res);
        }

        public void ReverseLinkedList()
        {
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
            ListNode linkedList = createLinkedList(new int[] {1, 2, 3, 4, 5});
            ListNode res = reverseLinkedList.ReverseList(linkedList);
            printLinkedList(res);

        }

        public ListNode createLinkedList(int[] nums)
        {
            ListNode dummy = new ListNode();
            ListNode curr = dummy;
            foreach (int num in nums)
            {
                curr.next = new ListNode(num);
                curr = curr.next;
            }
            return dummy.next;
        }

        public void printLinkedList(ListNode linkedList)
        {
            ListNode curr = linkedList;
            Console.Write('[');
            while (curr != null)
            {
                Console.Write(curr.val + ", ");
                curr = curr.next;
            }
            Console.Write(']');
            Console.WriteLine();
        }
        public static void printLine<T>(IList<T> arr)
        {
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }
        public static void printLine<T>(T[] arr)
        {
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }

        public static void printMatrix<T>(IList<IList<T>> matrix)
        {
            foreach (var array in matrix)
            {
                printLine(array);
            }
        }

        public static void printMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}