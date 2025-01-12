//while


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a number");
//        int n =int.Parse(Console.ReadLine());
//        int i =1;
//        while (i <= n)
//        {
//         Console.WriteLine(i);
//            i = i + 1;
//        }
//    }
//}

//do while
using System;

class Program
{
    static void Main()
    {
        string userChoice;

        do
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int i = 0;

            // Print numbers from 0 to the entered number
            while (i <= number)
            {
                Console.WriteLine(i);
                i++;
            }

            // Validate user input for continuation
            do
            {
                Console.WriteLine("Do you want to continue? (Yes or No)");
                userChoice = Console.ReadLine();

                if (userChoice != "Yes" && userChoice != "No")
                {
                    Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                }

            } while (userChoice != "Yes" && userChoice != "No");

        } while (userChoice == "Yes");

        Console.WriteLine("Program exited.");
    }
}
