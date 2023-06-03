// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using calc;
using static calc.Calculator;

string operation;
var calculator = new Calculator();

do
{
    Console.WriteLine("---  Type the operation you want to perform");
    Console.WriteLine("Type 1 for Sum");
    Console.WriteLine("Type 2 for Subtract");
    Console.WriteLine("Type 3 for Multiply");
    Console.WriteLine("Type 4 for Divide");
    Console.WriteLine("Type 5 for the Result");
    Console.WriteLine("Type 0 to exit");

    operation = Console.ReadLine();

    switch (operation)
    {
        case "1":
            PerformOperation(calculator, Operation.Sum);
            break;
        case "2":
            PerformOperation(calculator, Operation.Subtract);
            break;
        case "3":
            PerformOperation(calculator, Operation.Multiply);
            break;
        case "4":
            PerformOperation(calculator, Operation.Divide);
            break;
        case "5":
            calculator.Result();
            break;
        default:
            Console.WriteLine("Invalid input. Please try again.");
            break;
    }
} while (operation != "0");