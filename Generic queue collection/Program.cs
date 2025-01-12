using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
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
            Queue<Country> queuecountries = new Queue<Country>();
            queuecountries.Enqueue(country1);
            queuecountries.Enqueue(country2);
            queuecountries.Enqueue(country3);
            queuecountries.Enqueue(country4);
            queuecountries.Enqueue(country5);

            //dequeue .....
            //   Country c1 = queuecountries.Dequeue();
            //    Console.WriteLine(c1.Code + "-"+ c1.Name);
            //    Console.WriteLine("Totsl items in the Queue =" +queuecountries.Count());

            //    Country c2 = queuecountries.Dequeue();
            //    Console.WriteLine(c2.Code + "-" + c2.Name);
            //    Console.WriteLine("Totsl items in the Queue =" + queuecountries.Count());

            //    Country c3= queuecountries.Dequeue();
            //    Console.WriteLine(c3.Code + "-" + c3.Name);
            //    Console.WriteLine("Totsl items in the Queue =" + queuecountries.Count());

            //    Country c4 = queuecountries.Dequeue();
            //    Console.WriteLine(c4.Code + "-" + c4.Name);
            //    Console.WriteLine("Totsl items in the Queue =" + queuecountries.Count());


            //    Country c5 = queuecountries.Dequeue();
            //    Console.WriteLine(c5.Code + "-" + c5.Name);
            //    Console.WriteLine("Totsl items in the Queue =" + queuecountries.Count());
            //}

            // for printing everything
            // foreach (Country c in queuecountries)
            //{
            //    Console.WriteLine(c.Code + "-" + c.Name);
            //    Console.WriteLine("Totsl items in the Queue =" + queuecountries.Count());
            //}

            //gives begining of the queue
            //Country c = queuecountries.Peek();
            //Console.WriteLine(c.Code + "-" + c.Name);
            //Console.WriteLine("Totsl items in the Queue =" + queuecountries.Count());

            //checking if it is there
            queuecountries.Enqueue(country5);
            if (queuecountries.Contains(country5))
            {
                Console.WriteLine("exists");
            }
            else 
            {
                Console.WriteLine("not exists");
            }

        }

        public class Country
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public string Capital { get; set; }
        }
    }
}


