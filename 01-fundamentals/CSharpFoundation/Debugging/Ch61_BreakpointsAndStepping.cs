using System;
using System.Collections.Generic;
using System.Text;

// Learn how to pause execution and inspect code flow line-by-line.
// Key terms in this chapter:
// Breakpoint (F9): A marker that pauses execution at a specific line.
// Debug Mode (F5): Runs the app with debugging enabled.
// Run Without Debugging (Ctrl+F5): Runs normally without pausing.
// Step Over (F10): Executes the current line without entering method calls.
// Step Into (F11): Enters a called method to inspect its internals.
// Step Out (Shift+F11): Finishes the current method and returns to caller.
// Stop Debugging (Shift+F5): Stops the current debug session.

namespace CSharpFoundation.Debugging
{
    internal class Ch61_BreakpointsAndStepping
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3); // added the first breakpoint here and noticed that
                                                      // this method returns the number 6 so we pressed F11 to step into it

            foreach (var number in smallests)
                Console.WriteLine(number);

            Console.ReadKey();
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var minim = GetSmallest(list);
                smallests.Add(minim);
                list.Remove(minim);
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            //Assume the first number is the smallest
            var min = list[0];

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;
        }
    }
}
