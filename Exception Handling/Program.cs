//using System;
//using System.IO;

//class ExceptionHandling
//{
//    public static void Main()
//    {
//        try
//        {
//            StreamReader streamReader = new StreamReader(@"C:\Users\Pradeep.K\OneDrive - Coventry University\Desktop\hello im srujana.txt");
//            Console.WriteLine(streamReader.ReadToEnd());
//            streamReader.Close();
//        }
//        catch(FileNotFoundException ex) 
//        //(use this also for message exception) catch(Exception ex)
//        {
            
//            Console.WriteLine(ex.Message);
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine(ex.StackTrace);
//        }
//    }
//}

// other code
using System;
using System.IO;

class ExceptionHandling
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"C:\Users\Pradeep.K\OneDrive - Coventry University\Desktop\hello.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check if the file exists {0}", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        if (streamReader != null)
        {
            streamReader.Close();
        }
        Console.WriteLine("Finally block");
    }
}


