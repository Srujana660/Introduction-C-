using System;
using System.Collections.Generic;
namespace Pradeep
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new()
            {
                ID = 178,
                Name = "srujana",
                Salary = 3267,
            };
            Customer customer2 = new()
            {
                ID = 25,
                Name = "vicky",
                Salary = 5880,
            };
            Customer customer3 = new()
            {
                ID = 378,

                Name = "divya",
                Salary = 23457,
            };
            Dictionary<int, Customer> d = [];
            d.Add(customer1.ID, customer1);
            d.Add(customer2.ID, customer2);
            d.Add(customer3.ID, customer3);

            Customer customer378 = d[378];
            //Console.WriteLine("ID={0}, Name ={1}, Salary ={2}",customer378.Name, customer378.ID, customer3.Salary);
           
            foreach(KeyValuePair<int, Customer>customerkeyValuePair in d)
            {
                Console.WriteLine("Key={0}", customerkeyValuePair.Key);
                Customer customer = customerkeyValuePair.Value;
                Console.WriteLine("ID={0}, Name ={1}, Salary ={2}", customer.ID, customer.Name,customer.Salary);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public int Salary { get; set; }
    }
}