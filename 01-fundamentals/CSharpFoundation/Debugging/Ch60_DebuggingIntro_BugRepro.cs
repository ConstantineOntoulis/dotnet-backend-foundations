using System;
using System.Collections.Generic;
using System.Text;

// Introduce debugging as a process for locating and fixing bugs.
// Reproduce a faulty program on purpose so we can inspect it.
// Key terms in this chapter:
// Bug: A defect in code that causes incorrect behavior.
// Reproduction: Running the program in a way that reliably shows the bug.
// Expected vs Actual Output

namespace CSharpFoundation.Debugging
{
    internal class Ch60_DebuggingIntro_BugRepro
    {
        public static void Run()
        {
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
                var smallests = GetSmallests(numbers, 3);

                foreach (var number in smallests)
                    Console.WriteLine(number);

                Console.ReadLine();
            }
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