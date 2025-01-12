//using System;

//public class ExceptionHandlingAbuse
//{

//     public static void Main()
//    {
//        try
//          {
//            Console.WriteLine("Enter a number");
//            int a = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter another number");
//            int b = Convert.ToInt32(Console.ReadLine());

//            int c = a / b;
//            Console.WriteLine("c is {0}", c);
//        }
//        catch(FormatException)  
//        {
//            Console.WriteLine("Enter only a number");    
//        }
//        catch(OverflowException)
//        {
//            Console.WriteLine("the number must be in limit {0} && {1} are allowed",int.MinValue,int.MinValue);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

//Preventing Exception Abuse

using System;
public class ExceptionHandlingAbuse
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number");
            int a;
            bool isAConversionSuccessful = Int32.TryParse(Console.ReadLine(), out a);
            if (isAConversionSuccessful)
            {
                Console.WriteLine("Enter another number");
                int b;
                bool isBConversionSuccessful = Int32.TryParse(Console.ReadLine(), out b);

                if (isBConversionSuccessful)
                {
                    if (b != 0)
                    {
                        int c = a / b;
                        Console.WriteLine("c is {0}", c);
                    }
                    else
                    {
                        Console.WriteLine("b can't be zero");
                    }
                }
                else
                {
                    Console.WriteLine("b should be a valid number between {0} and {1}", int.MinValue, int.MaxValue);
                }
            }
            else
            {
                Console.WriteLine("a should be a valid number between {0} and {1}", int.MinValue, int.MaxValue);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter only a number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number must be in limit {0} and {1} are allowed", int.MinValue, int.MaxValue);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}