namespace calc;

public class Calculator
{
    public enum Operation
    {
        Sum,
        Subtract,
        Multiply,
        Divide
    }

    private int _memory;
    public int Num { get; set; }

    public static void PerformOperation(Calculator calculator, Operation operation)
    {
        Console.WriteLine("Type a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            switch (operation)
            {
                case Operation.Sum:
                    calculator.Sum(number);
                    break;
                case Operation.Subtract:
                    calculator.Subtract(number);
                    break;
                case Operation.Multiply:
                    calculator.Multiply(number);
                    break;
                case Operation.Divide:
                    calculator.Divide(number);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    public int Multiply(int Num)
    {
        if (_memory == 0)
        {
            _memory = 1;
        }
        this.Num
            = Num;
        return _memory *= this.Num;
    }

    public int Divide(int Num)
    {
        if (Num != 0)
        {
            this.Num
                = Num;

            return _memory /= this.Num;
        }

        return 0;
    }

    public int Sum(int Num)
    {
        this.Num
            = Num;
        return _memory += this.Num;
    }

    public int Subtract(int Num)
    {
        this.Num
            = Num;
        return _memory -= this.Num;
    }

    public void Result()
    {
        Console.WriteLine($"Resultado = {_memory}");
        Console.WriteLine("Deseja continuar? S/N");
        var continua = Console.ReadLine();
        if (continua.ToUpper() != "S" )
            Environment.Exit(0);
    }

    public void ZeraValor()
    {
        _memory = 0;
    }
}