//how to implement using string ------
//using System;
//using System.Text;
//namespace srujana
//{
//    public class Srujananame
//    {
//        public static void Main()
//        {
//            string str = "C#";
//            str = str + "Video";
//            str = str + "good";
//            str = str + "Tutorial";
//            Console.WriteLine(str);          
//        }
//    }
//}

//using string builder----
//using System;
//using System.Text;
//namespace srujana
//{
//    public class Srujananame
//    {
//        public static void Main()
//        {
//            StringBuilder str = new StringBuilder("C#");
//            str.Append("Video");
//            str.AppendLine("good");
//            str.Append("Tutorial");
//            Console.WriteLine(str.ToString());
//        }
//    }
//}


using System;
using System.Text;
namespace srujana
{
    public class Srujananame
    {
        public static void Main()
        {
            string str = string.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str = str + i.ToString();
            }
            Console.WriteLine(str);
        }
    }
}
////When heavy string manupulation is involved always use string of type system.text.StringBuilder rather than strings of type system.string.
