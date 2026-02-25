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


            Console.ReadKey();
        }
    }
}
