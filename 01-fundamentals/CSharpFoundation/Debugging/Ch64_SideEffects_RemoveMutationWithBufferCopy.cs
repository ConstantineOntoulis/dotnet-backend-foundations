using System;
using System.Collections.Generic;
using System.Text;

// Identify and eliminate a side effect caused by mutating input data.
// Key terms in this chapter:
// Side Effect: A method changes data/state outside its intended output.
// Mutation: Modifying an existing object or collection.
// Input List: The original data passed into a method.
// Buffer Copy: A temporary copy used for processing so the original stays unchanged.

namespace CSharpFoundation.Debugging
{
    internal class Ch64_SideEffects_RemoveMutationWithBufferCopy
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
            var buffer = new List<int>(list); // We create a new list to make sure that everything works properly 
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var minim = GetSmallest(buffer);
                smallests.Add(minim);
                buffer.Remove(minim); // Now, instead of removing the numbers from the original list, they are removed
            }                         // from the buffer list
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
