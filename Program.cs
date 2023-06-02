// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using calc;

var calc = new Calculator();
Console.WriteLine("---  Type the operation you want to perform");
Console.WriteLine("Type 1 for Sum");
Console.WriteLine("Type 2 for Subtract");
Console.WriteLine("Type 3 for Multiply");
Console.WriteLine("Type 4 for Divide");
Console.WriteLine("Type 5 for the Result");

string operation;

do
{
    Console.WriteLine("---  Type the operation you want to perform");
    Console.WriteLine("Type 1 for Sum");
    Console.WriteLine("Type 2 for Subtract");
    Console.WriteLine("Type 3 for Multiply");
    Console.WriteLine("Type 4 for Divide");
    Console.WriteLine("Type 5 to Exit");

    operation = Console.ReadLine();

    switch (operation)
    {
        case "1":
            Calculator.PerformOperation(calculator, Operation.Sum);
            break;
        case "2":
            Calculator.PerformOperation(calculator, Operation.Subtract);
            break;
        case "3":
            Calculator.PerformOperation(calculator, Operation.Multiply);
            break;
        case "4":
            Calculator.PerformOperation(calculator, Operation.Divide);
            break;
        case "5":
            Calculator.PerformOperation(calculator, Operation.Result);
            break;
        default:
            Console.WriteLine("Invalid input. Please try again.");
            break;
    }
} while (operation != "5");