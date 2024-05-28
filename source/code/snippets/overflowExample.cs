using System;

class Program
{
    static void Main()
    {
        uint n1,
            n2;

        Console.WriteLine("Enter the requested loan amount for the first person:");
        n1 = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter the requested loan amount for the second person:");
        n2 = uint.Parse(Console.ReadLine());

        if (n1 + n2 < 10000)
        {
            Console.WriteLine($"Pay ${n1} to the first person");
            Console.WriteLine($"Pay ${n2} to the second person");
        }
        else
        {
            Console.WriteLine("Error: the sum of the loans exceeds the maximum allowance.");
        }
    }
}
