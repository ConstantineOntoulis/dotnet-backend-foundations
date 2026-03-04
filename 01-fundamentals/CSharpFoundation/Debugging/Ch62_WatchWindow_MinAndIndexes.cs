using System;
using System.Collections.Generic;
using System.Text;

// Learn to monitor important values while stepping through code.
// Key terms in this chapter:
// Watch Window: A debugging panel where we manually track variables/expressions.
// Expression: A value or computation (e.g., min, list[0], list[i]).
// Scope: Where a variable exists and can be accessed.
// * Example: 'i' is only available inside the for-loop scope.

namespace CSharpFoundation.Debugging
{
    internal class Ch62_WatchWindow_MinAndIndexes
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
                var minim = GetSmallest(list); // we noticed that this method is indeed the faulty one so we 
                                               // entered it by pressing F11 and then we skipped with F10 until we spot the issue
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
                if (list[i] < min) //bug
                    min = list[i];
            }
            return min;
        }
    }
}
