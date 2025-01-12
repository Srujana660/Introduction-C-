//class Program
//{
//    public static void Main()
//    {
//     Thread T1 = new Thread(() => {Numbers.PrintNumbers();});
//        T1.Start();
//    }
//}

//class Numbers
//{
//    public static void PrintNumbers()
//    {
//        for (int i = 0; i <= 10; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}



//or using threadstart delegate as shown below


//class Program
//{
//    public static void Main()
//    {
//        Thread T1 = new Thread(new ThreadStart(Numbers.PrintNumbers));
//        T1.Start();
//    }
//}

//class Numbers
//{
//    public static void PrintNumbers()
//    {
//        for (int i = 0; i <= 10; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//or here we are not explicitly creating the threadstart delegate, then how is it working?
//its working in spite of not creating the Threadstart delegate expliciyly because the framework is doing it automatically for us.

class Program
{
    public static void Main()
    {
        Thread T1 = new Thread(Numbers.PrintNumbers);
        T1.Start();
    }
}

class Numbers
{
    public static void PrintNumbers()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}