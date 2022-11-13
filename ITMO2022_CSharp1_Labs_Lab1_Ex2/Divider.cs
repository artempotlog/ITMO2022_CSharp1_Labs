using System;

namespace Divider
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Please enter the second integer");
                string temp2 = Console.ReadLine();
                int j = Int32.Parse(temp2);

                double k = i / j;
                Console.WriteLine("The result is {0}", k);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
        }
    }
}
