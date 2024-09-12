using System;

class Program
{
    static void Main(string[] args)
    {
        int numA = 0;
        int numB = 0;

        // Get data
        Console.Write("Enter a number: ");
        string numAInput = Console.ReadLine();

        Console.Write("Enter another number: ");
        string numBInput = Console.ReadLine();

        // Validations
        if (!parseInt(numAInput, out numA) || !parseInt(numBInput, out numB))
        {
            return;
        }

        // To do sum
        int numC = numA + numB;
        Console.WriteLine($"{numA} + {numB} = {numC}");
    }

    static bool parseInt(string numString, out int num)
    {
        // Initialize num to a default value
        num = 0;

        // Check for null or empty string
        if (string.IsNullOrEmpty(numString))
        {
            Console.WriteLine("The input can't be null or empty.");
            return false;
        }

        // Attempt to parse the integer
        if (!int.TryParse(numString, out num))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return false;
        }

        return true;
    }
}
