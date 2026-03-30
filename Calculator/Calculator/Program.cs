namespace Calculator;

internal class Program
{
    static void Main()
    {
        try {
            Console.WriteLine("Enter the  First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            if(num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            int divide = num1 / num2;

            Console.WriteLine($"The sum of the {num1} and {num2} is {sum}");
            Console.WriteLine($"The subtraction of the {num1} and {num2} is {sub}");
            Console.WriteLine($"The multiplication of the {num1} and {num2} is {mul}");
            Console.WriteLine($"The division of the {num1} and {num2} is {divide}");
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch(FormatException)
        {
            Console.WriteLine("Error: Non-numeric value entered. Please enter a Numeric value.");
        }
        catch(Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}