using System;
using System.Collections.Generic;
using System.Text;

// Validate inputs before processing to prevent invalid program states.
// Key terms in this chapter:
// Defensive Programming: Writing code that checks assumptions early.
// Guard Clause: An early validation check that stops execution when input is invalid.
// ArgumentOutOfRangeException: Thrown when a value is outside allowed range.
// ArgumentNullException: Thrown when a required reference argument is null.
// Meaningful Exception Message: A message that explains what is wrong and why.

namespace CSharpFoundation.Debugging
{
    internal class Ch65_DefensiveProgramming_GuardClauses
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2 }; 
            var smallests = GetSmallests(numbers, 3); // Client of method sends wrong data for unhandled exception
            // if instead of numbers, we used null, we would get a no reference exception
            foreach (var number in smallests)
                Console.WriteLine(number);

            Console.ReadKey();
        }

        public static List<int> GetSmallests(List<int> list, int count) // We need to enuse that the "count" is not
        {                                                               // Greater than the items we receive in the list
            //if (list == null)
            //    throw new ArgumentNullException("list");
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
            var min = list[0]; // Failure point
                               // To solve, we may either use a conditional statement here to enture
                               // The list wil not be empty. It is wiser to use one in the GetSmallests method instead.
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
