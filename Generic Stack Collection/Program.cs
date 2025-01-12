using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Microsoft.Win32.SafeHandles;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Country country1 = new Country()
            {
                Code = "AUS",
                Name = "AUSTRALIA",
                Capital = "Canberra"
            };
            Country country2 = new Country()
            {
                Code = "IND",
                Name = "INDIA",
                Capital = "New Delhi"
            };
            Country country3 = new Country()
            {
                Code = "USA",
                Name = "UNITED STATES",
                Capital = "Washington D.C"
            };
            Country country4 = new Country()
            {
                Code = "GBR",
                Name = "UNITED KINGDOM",
                Capital = "London"
            };
            Country country5 = new Country()
            {
                Code = "CAN",
                Name = "CANADA",
                Capital = "Ottawa"
            };
            Stack<Country> stack = new Stack<Country>();
            stack.Push(country1);
            stack.Push(country2);
            stack.Push(country3);
            stack.Push(country4);
            stack.Push(country5);

            //Country c1 =stack.Pop();
            //Console.WriteLine(c1.Code + "-" + c1.Name);
            //Console.WriteLine("Items in the stack =" +stack.Count());

            //Country c2 = stack.Pop();
            //Console.WriteLine(c2.Code + "-" + c2.Name);
            //Console.WriteLine("Items in the stack =" + stack.Count());

            //Country c3 = stack.Pop();
            //Console.WriteLine(c3.Code + "-" + c3.Name);
            //Console.WriteLine("Items in the stack =" + stack.Count());

            //Country c4 = stack.Pop();
            //Console.WriteLine(c1.Code + "-" + c4.Name);
            //Console.WriteLine("Items in the stack =" + stack.Count());

            //Country c5 = stack.Pop();
            //Console.WriteLine(c5.Code + "-" + c5.Name);
            //Console.WriteLine("Items in the stack =" + stack.Count());

            // One more method
            //foreach(Country c in stack)
            //{
            //    Console.WriteLine(c.Code + "-" + c.Name);
            //    Console.WriteLine("Items in the stack =" + stack.Count);
            //}

            // one more method
            if (stack.Contains(country4))
            {
                Console.WriteLine(country4.Code + "-" + country4.Name);
                Console.WriteLine("Items in the stack =" + stack.Count);
            }
            else
            {
                Console.WriteLine("not exists");
            }

        }

        
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}


