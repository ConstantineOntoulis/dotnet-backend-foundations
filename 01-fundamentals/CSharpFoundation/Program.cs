using CSharpFoundation.Debugging;
using CSharpFoundation.Exercises;
using CSharpFundamentals.LINQ;
using System;

Console.Write("Chapter number (1–67): ");
var input = Console.ReadLine();

if (int.TryParse(input, out var id))
{
    if (id >= 1 && id <= 50)
    {
        Topics.Run(id);          // Exercises (Bro Code 1–50)
    }
    else if (id >= 51 && id <= 59)
    {
        LinqTopics.Run(id);      // LINQ (51–59)
    }
    else if (id >= 60 && id <= 67)
    {
        DebugTopics.Run(id);  // Debugging Tutorial
    }
    else
    {
        Console.WriteLine("Out of range. Use 1–50 (Exercises) or 51–59 (LINQ) or 60-67 (Debugging).");
    }
}
else
{
    Console.WriteLine("Invalid input. Enter a number like 2, 12, 57.");
}