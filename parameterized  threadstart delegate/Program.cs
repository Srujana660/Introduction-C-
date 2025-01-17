﻿// using parameterizedThreadStart delegate to pass data to thread function
//class Program
//{

//    public static void Main()
//    {
//        Console.WriteLine("Enter target number");
//        object target = Console.ReadLine();

//        Number number = new Number();
//        ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
//        Thread T1 = new Thread(parameterizedThreadStart);
//        T1.Start(target);
//    }
//}
//class Number
//{
//    public void PrintNumbers(object target)
//    {
//        int number = 0;
//        if (int.TryParse(target.ToString(), out number))
//        {
//            for (int i = 1; i <= number; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }

//    }
//}

// here we are not explicitly creating an instance of parameterizedThreadStart delegate.it also works bcz 
// the compiler implicitly converts

class Program
{

    public static void Main()
    {
        Console.WriteLine("Enter target number");
        object target = Console.ReadLine();

        Number number = new Number();
    
        Thread T1 = new Thread(number.PrintNumbers);
        T1.Start(target);
    }
}
class Number
{
    public void PrintNumbers(object target)
    {
        int number = 0;
        if (int.TryParse(target.ToString(), out number))
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
