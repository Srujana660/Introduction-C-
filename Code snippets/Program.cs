using System.Text;
using System.Runtime.InteropServices;
namespace Snippets
{
    class Program
    {
        public static void Main()
        {
            checked
            {
                for (int k = 0; k < 20; k++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                } 
            }
            for (int j = 0; j < 5; j++)
            {

            }
        }
    }
}