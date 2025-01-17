using System;
class calculator
{
    static void Main()
    {
        Console.WriteLine("enter 1st no");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd no");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nchoose an operation");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Substraction");
        Console.WriteLine("3.Mulitplication");
        Console.WriteLine("4.Division");
        int choice = int.Parse(Console.ReadLine());
        double result = 0;

        switch (choice)
        {
            case 1:
                result = n1 + n2;
                Console.WriteLine($"\nResult: {n1} + {n2} = {result}");
                break;
            case 2:
                result = n1 - n2;
                Console.WriteLine($"\nResult: {n1} - {n2} = {result}");
                break;
            case 3:
                result = n1 * n2;
                Console.WriteLine($"\nResult: {n1} * {n2} = {result}");
                break;
            case 4:
                result = n1 / n2;
                if (n2 != 0)
                {
                    result = n1 / n2;
                    Console.WriteLine($"\nResult: {n1} / {n2} = {result}");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                break;
            default:
                Console.WriteLine("invalid Statement");
                break;
        

        }
    }
}