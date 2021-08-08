using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpAlgorithms;
using CSharpAlgorithms.Difficulties.Easy;

namespace CSharpAlgorithms
{
    class Program
    {
        private readonly Easy _easy = new Easy();

        public Easy Easy
        {
            get { return _easy; }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
        }
    }
}