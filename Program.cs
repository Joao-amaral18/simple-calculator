// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using calc;
using static calc.Calculator;

string operation;
var calculator = new Calculator();

do
{
    Console.WriteLine("---  Digite o operador que deseja performar");
    Console.WriteLine("+");
    Console.WriteLine("-");
    Console.WriteLine("*");
    Console.WriteLine("/");
    Console.WriteLine("Digite = para obter o Resultado");
    Console.WriteLine("Digite 0 para zerar o resultado");

    operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            PerformOperation(calculator, Operation.Sum);
            break;
        case "-":
            PerformOperation(calculator, Operation.Subtract);
            break;
        case "*":
            PerformOperation(calculator, Operation.Multiply);
            break;
        case "/":
            PerformOperation(calculator, Operation.Divide);
            break;
        case "=":
            calculator.Result();
            break;
        case "0":
            calculator.ZeraValor();
            break;
        case "exit":
            Console.WriteLine("Adeus!");
            break;
        default:
            Console.WriteLine("Input invalido. Tente novamente.");
            break;
    }
} while (operation != "exit");
