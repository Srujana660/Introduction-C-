//using System;
//class Program
//{
//    public static void Main()
//    {

//       Program p = new Program();
//        p.EvenNumbers();

//    }
//    public void EvenNumbers()
//    {
//        int i = 0;
//        while (i <= 10)
//        {
//            Console.WriteLine(i);
//            i++;
//        }
//    
//}


using System;
class Program
{
    public static void Main()
    {

        Program p = new Program();
        p.EvenNumbers();
        int sum = p.Add(1, 2);
        Console.WriteLine(sum);

    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    public  void EvenNumbers()
    {
        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
