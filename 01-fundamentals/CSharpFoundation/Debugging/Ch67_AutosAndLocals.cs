using System;
using System.Collections.Generic;
using System.Text;

// Compare automatic variable inspection tools in Visual Studio.
// Key terms in this chapter:
// Autos Window: Shows variables/expressions Visual Studio predicts are relevant.
// Locals Window: Shows variables currently in local scope.
// Local Scope: Variables declared in the current method/block and currently available.

namespace CSharpFoundation.Debugging
{
    internal class Ch67_AutosAndLocals
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
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {                      // Debug -> Windows -> Autos/Locals
                if (list[i] < min) // Autos Window selects automaticall that VS deems vital.
                                   // Locals Window is similar to Autos but it doesn't show list all kinds of variations
                                   // That we see in the Autos Window
                    min = list[i];
            }
            return min;
        }
    }
}
