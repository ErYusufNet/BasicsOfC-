using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPointAndToolTip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int result = a + b + c;

            Console.WriteLine(result);
            /*
             *Breakpoint:
            A breakpoint is a marker that you can place in your source code to tell the debugger to pause the 
            program's execution at that specific line of code. It allows you to inspect variables, check the flow of your program,
            and identify errors or unexpected behavior. Here's how you can use breakpoints:

            Setting a Breakpoint:

            In your Visual Studio or other C# development environment, locate the line of code where you want to pause execution.
            Click in the left margin of the code editor next to the line where you want to set the breakpoint. 
            A red dot will appear, indicating the breakpoint.
            Running the Program with Breakpoints:

            Start debugging your program (usually by pressing F5 or clicking the "Start Debugging" button).
            When the program reaches the line with the breakpoint, it will pause, allowing you to inspect
            variables and step through the code.
            Inspecting Variables:

            While paused at a breakpoint, you can hover your mouse over variables to see their current values.
            You can also open the "Watch" window to add specific variables you want to monitor.
            Stepping Through Code:

            To continue execution from a breakpoint, you can press F5 (Continue) to run the program until the next breakpoint.
            Alternatively, you can use F10 to step over each line of code one by one, examining the effects of each statement.
            F10 (Step Over):
            F10 is a keyboard shortcut used during debugging to execute the current line of code and move 
            to the next line in your program. It's often called "Step Over" because it allows you to step
            over function or method calls without going into their details. Here's how it works:

            Placing a Breakpoint:

            Before you start debugging, set a breakpoint at the line where you want to begin stepping through your code.
            Starting Debugging:

            Begin debugging your program (usually by pressing F5 or the "Start Debugging" button).
            Using F10:

            When your program pauses at a breakpoint, press F10 to execute the current line of code.
            If the line contains a function or method call, F10 will execute the call and move to the next line in the current scope.
            Inspecting Variables:

            While using F10, you can inspect variables and check their values as you step through the code.
            Using breakpoints and the F10 key in C# debugging allows you to gain insights into 
            how your program runs and helps you identify and resolve issues effectively.
                         */


        }
    }
}
