using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpAlgorithms;
using CSharpAlgorithms.Basics;
using CSharpAlgorithms.Difficulties.Easy;
using CSharpAlgorithms.Global;

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
            ReferenceTypes refe = new ReferenceTypes();
            BuiltIn builtIn = new BuiltIn();
            DictionariesAndObjects dictionariesAndObjects = new DictionariesAndObjects();
            Collections collections = new Collections();
        }
    }
}