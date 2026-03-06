using System;
using System.Collections.Generic;
using System.Text;

// Learn how to trace the path of method calls that led to the current line.
// Key terms in this chapter:
// Call Stack: The ordered list of active method calls.
// Current Frame: The method currently being executed (top of stack).
// Caller: The method that invoked the current method.
// Navigation: Jumping between stack frames to inspect code context.

namespace CSharpFoundation.Debugging
{
    internal class Ch66_CallStack_Navigation
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3); 

            foreach (var number in smallests)
                Console.WriteLine(number);

            Console.ReadKey();
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {                                                              
            //  if (list == null)
            //        throw new ArgumentNullException("list");
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");

            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var minim = GetSmallest(buffer);
                smallests.Add(minim);
                buffer.Remove(minim);
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            var min = list[0]; // Debug -> Windows -> Call Stack: Opens a window showing all the processes so far
                               // With the breakpoint being at the very top. When doubleclicking, it brings us there
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
