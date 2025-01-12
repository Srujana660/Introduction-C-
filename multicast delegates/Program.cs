//Multicast Delegates

//using System;
//public delegate void SampleDelegate();
//class Program
//{
//    public static void Main()
//    {
//        SampleDelegate del = new SampleDelegate(SampleMethodone);
//        del += SampleMethodtwo;
//        del += SampleMethodthree;
//        del();
//    }
//    public static void SampleMethodone()
//    {
//    Console.WriteLine("1.Srujana");
//    }
//public static void SampleMethodtwo()
//{
//    Console.WriteLine("2.Pradeep");
//}
//public static void SampleMethodthree()
//{
//    Console.WriteLine("3.Vicky");
//}
//}


// Other method
using System;
using System.Runtime.InteropServices;
public delegate void SampleDelegate();
class Program
{
    public static void Main()
    {
        SampleDelegate del1, del2, del3, del4;
        del1 = new SampleDelegate(SampleMethodone);
        del2 = new SampleDelegate(SampleMethodtwo);
        del3 = new SampleDelegate(SampleMethodthree);
        del4 = del1 + del2 + del3-del2;//(you can also substract)
        del4();
        
    }
    public static void SampleMethodone()
    {
        Console.WriteLine("1.Srujana");
    }
    public static void SampleMethodtwo()
    {
        Console.WriteLine("2.Pradeep");
    }
    public static void SampleMethodthree()
    {
        Console.WriteLine("3.Vicky");
    }
}
