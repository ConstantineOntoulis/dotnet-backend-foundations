using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFoundation.Debugging;
public static class DebugTopics
{
    public static void Run(int id)
    {
        switch (id)
        {
            case 60: Ch60_DebuggingIntro_BugRepro.Run(); break;
            case 61: Ch61_BreakpointsAndStepping.Run(); break;
            case 62: Ch62_WatchWindow_MinAndIndexes.Run(); break;
            case 63: Ch63_Exceptions_BreakpointsWindow_Restart.Run(); break;
            case 64: Ch64_SideEffects_RemoveMutationWithBufferCopy.Run(); break;
            case 65: Ch65_DefensiveProgramming_GuardClauses.Run(); break;
            case 66: Ch66_CallStack_Navigation.Run(); break;
            case 67: Ch67_AutosAndLocals.Run(); break;

            default:
                Console.WriteLine("Unknown debugging chapter id.");
                break;
        }
    }
}