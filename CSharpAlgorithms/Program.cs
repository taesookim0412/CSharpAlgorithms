using System;

namespace CSharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            twoSum twoSumObj = new twoSum();
            int[] twoSumRes = twoSumObj.TwoSum(new int[] {2,7,11,15}, 9);
            Array.ForEach(twoSumRes, Console.WriteLine);
        }
    }
}