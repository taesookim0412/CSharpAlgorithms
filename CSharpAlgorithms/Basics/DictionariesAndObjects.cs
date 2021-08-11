using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAlgorithms.Basics
{
    public class DictionariesAndObjects
    {
        public DictionariesAndObjects()
        {
            Hashtable data = new Hashtable();
            if (data.Contains(4))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Dictionary<int, int> nums = new Dictionary<int, int>();
            if (nums.ContainsKey(4))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
        
    }
}