namespace Calculator;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the  First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        int sub = num1 - num2;
        int mul = num1 * num2;
        int divide = num1 / num2;

        Console.WriteLine($"The sum of the {num1} and {num2} is {sum}");
        Console.WriteLine($"The subtraction of the {num1} and {num2} is {sub}");
        Console.WriteLine($"The multiplication of the {num1} and {num2} is {mul}");
        Console.WriteLine($"The division of the {num1} and {num2} is {divide}");
    }
}