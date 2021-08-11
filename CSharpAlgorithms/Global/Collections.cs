using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace CSharpAlgorithms.Global
{
    public class Collections
    {
        public Collections()
        {
            int[] intArray = createIntArray();
            Console.WriteLine(JsonSerializer.Serialize(intArray));
            modifyElement(intArray);
            Console.WriteLine(JsonSerializer.Serialize(intArray));
            createIntList();
            createIntArrayList();
            createIntStack();
            int[,] multiDimensionalArr = createMultimensionalArray(3,4);
            Console.Write(JsonSerializer.Serialize(multiDimensionalArr));

            int[][] jaggedArray = createJaggedArray(4);
            Console.Write(JsonSerializer.Serialize(jaggedArray));

        }

        int[] createIntArray()
        {
            return new int[] {1, 2, 3};
        }

        void modifyElement(int[] arr)
        {
            arr[0] = 0;
        }

        List<int> createIntList()
        {
            List<int> res = new List<int>();
            res.Add(1);
            res.Add(2);
            res.Add(3);
            res.Add(4);
            res.Remove(5);
            Console.WriteLine(JsonSerializer.Serialize(res));
            return res;
        }

        ArrayList createIntArrayList()
        {
            ArrayList res = new ArrayList();
            res.Add(1);
            res.Add(2);
            res.Add(3);
            res.Add(4);
            res.Remove("5");
            Console.WriteLine(JsonSerializer.Serialize(res));
            return res;            
        }

        Stack<int> createIntStack()
        {
            Stack<int> res = new Stack<int>();
            res.Push(1);
            int num = res.Pop();
            Console.WriteLine(num);
            res.Push(1);
            res.Push(2);
            res.Push(3);
            res.Push(4);
            res.Push(5);
            if (res.Count > 0)
                Console.WriteLine(res.Peek());
            return res;
        }

        int[][] createJaggedArray(int sz)
        {
            int[][] arr = new int[sz][];
            for (int i = 0; i < sz; i++)
            {
                arr[i] = new int[2];
            }

            return arr;
        }

        int[,] createMultimensionalArray(int rows, int cols)
        {
            int[,] res = new int[rows, cols];
            return res;
        }
    }
}