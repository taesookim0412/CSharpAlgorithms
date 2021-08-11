using System;
using System.Collections.Generic;
using System.Text.Json;

namespace CSharpAlgorithms.Basics
{
    public class BuiltIn
    {
        public BuiltIn()
        {
            // LinkedList<int> linkedList = new LinkedList<int>(new int[]{1,2,3,4});
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(new LinkedListNode<int>(1));
            linkedList.AddLast(new LinkedListNode<int>(2));
            linkedList.AddLast(new LinkedListNode<int>(3));
            Console.WriteLine(JsonSerializer.Serialize(linkedList));
            LinkedListNode<int> curr = linkedList.First;
            int i = 0;
            while (curr != null) 
            {
                if (i == 2)
                {
                    break;
                }
                Console.Write(curr.Value);
                curr = curr.Next;
                i += 1;
            }

            // curr.Next = new LinkedListNode<int>(10);

        }
    }
}
