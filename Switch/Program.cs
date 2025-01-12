using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Number is {0}", number);
                break;
            default:
                Console.WriteLine("This is not in limit");
                break;

        }
    }
}





