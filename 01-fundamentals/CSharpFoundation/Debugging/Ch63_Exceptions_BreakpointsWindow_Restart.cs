using System;
using System.Collections.Generic;
using System.Text;

// Learn how to debug crashes and manage breakpoints efficiently.
// Key terms in this chapter:
// Exception: A runtime error that interrupts program execution.
// Breakpoints Window: A panel listing all breakpoints in the project.
// Continue (F5): Resume execution until the next breakpoint / crash.
// Restart Debugging (Ctrl+Shift+F5): Restart current debug session quickly.
// Disable vs Delete Breakpoints:
// * Disable = keep breakpoint but ignore it temporarily
// * Delete  = remove breakpoint entirely

namespace CSharpFoundation.Debugging
{
    internal class Ch63_Exceptions_BreakpointsWindow_Restart
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2 }; // Remove the last 4 numbers so we only have 2. That will cause n "Out of Range" Exception
            var smallests = GetSmallests(numbers, 3); 

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
            var min = list[0];

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
