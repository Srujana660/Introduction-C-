//Passing parameter by value
//using System;
//class Program
//{
//    public static void Main()
//    {
//        int i = 0;
//        Simplemethod(i);
//        Console.WriteLine(i);
//    }
//    public static void Simplemethod(int j)
//    {
//        j = 4; 
//    }
//}

//Passing parameter by reference
// using System;
//class Program
//{
//    public static void Main()
//    {
//        int i = 0;
//        Simplemethod(ref i);
//        Console.WriteLine(i);
//    }
//    public static void Simplemethod(ref int j)
//    {
//        j = 4;
//    }
//}


//out parameter
//using System;
//class Program
//{
//    public static void Main()
//    {
//        int Sum = 0;
//        int Product = 0;
//        Calculate(1,2,out Sum, out Product);
//        Console.WriteLine("Sum is {0} and Product is {1}",Sum,Product);
//    }
//    public static void Calculate(int a, int b, out int Sum, out int Product)
//    {
//    Sum = a + b;
//    Product = a* b;
//    }
//}AQ

//Params
