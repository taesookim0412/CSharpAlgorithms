using System;
using System.Collections.Generic;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class ReverseString
    {
        public string ReverseWords(string s)
        {
            string[] wordsSplit = s.Trim().Split(" ");
            List<string> res = new List<string>();
            for (int i = wordsSplit.Length - 1; i > -1; i--)
            {
                string newString = wordsSplit[i].Trim();
                if (newString != "")
                    res.Add(newString);
            }
            return String.Join(" ", res);
        }
    }
}