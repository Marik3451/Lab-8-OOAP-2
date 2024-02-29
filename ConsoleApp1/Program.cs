using System;

public interface IExpression
{
    int Interpret();
}

public class NumberExpression : IExpression
{
    private int number;

    public NumberExpression(int number)
    {
        this.number = number;
    }

    public int Interpret()
    {
        return number;
    }
}

public class AddExpression : IExpression
{
    private IExpression leftExpression;
    private IExpression rightExpression;

    public AddExpression(IExpression leftExpression, IExpression rightExpression)
    {
        this.leftExpression = leftExpression;
        this.rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return leftExpression.Interpret() + rightExpression.Interpret();
    }
}

public class SubtractExpression : IExpression
{
    private IExpression leftExpression;
    private IExpression rightExpression;

    public SubtractExpression(IExpression leftExpression, IExpression rightExpression)
    {
        this.leftExpression = leftExpression;
        this.rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return leftExpression.Interpret() - rightExpression.Interpret();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IExpression number1 = new NumberExpression(20);
        IExpression number2 = new NumberExpression(5);

        IExpression addition = new AddExpression(number1, number2);
        Console.WriteLine($"Додавання: {addition.Interpret()}");

        IExpression subtraction = new SubtractExpression(number1, number2);
        Console.WriteLine($"Віднімання: {subtraction.Interpret()}");
    }
}
