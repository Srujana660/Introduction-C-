using System.ComponentModel;
using System.Globalization;

//Optional parameters
    namespace Demo
{
    class Program
    {
        public static void Main()
        {
            Add(10, 20, new object[] { 1, 2, 3});
        }
        public static void Add(int a, int b, params object[] numbers)
        {
            int result=a + b;
            if (numbers != null)
            {
                foreach (int i in numbers)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}