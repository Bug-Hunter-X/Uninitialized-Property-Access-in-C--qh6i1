# Uninitialized Property Access in C#

This repository demonstrates a common C# coding error: accessing a property before it has been initialized.  Uninitialized properties will have default values, often leading to unexpected behavior in your application.  The example showcases this issue and presents a solution.

## Bug
The `bug.cs` file contains code that attempts to access the `MyProperty` before it is assigned a value. This results in the default value (0 for integers) being printed instead of the intended value.

## Solution
The `bugSolution.cs` file corrects the error by initializing `MyProperty` to a value before accessing it in the `MyMethod` function.  This ensures predictable and correct program execution.

## How to run:
1. Clone this repository.
2. Open the solution in Visual Studio or another C# IDE.
3. Build and run the `bug.cs` file to observe the unexpected behavior.
4. Then, run the `bugSolution.cs` file to see the corrected output.
