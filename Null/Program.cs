//using System;
//class Program
//{
//    static void Main()
//    {
//        bool? AreyouMajor = null;
//        if (AreyouMajor == true)
//        {
//            Console.WriteLine("Major");
//        }
//        else if (AreyouMajor == false)
//        {
//            Console.WriteLine("Not Major");
//        }
//        else
//        {
//            Console.WriteLine("did not answer");
//        }
//    }
//}

using System;
class Program
{
    static void Main()
    {
        int? Ticketsonsale = 10;
        int AvailableTickets = Ticketsonsale ?? 0;
        Console.WriteLine("Availale Tickets = {0}", Ticketsonsale);
    }    
        
  }
