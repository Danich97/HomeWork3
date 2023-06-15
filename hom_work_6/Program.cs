using System.Diagnostics.Metrics;

namespace hom_work_6
{
    internal class Program
    {
        static bool CheckPrime(int val)
        {
            if (val < 2)
            {
                return false;
            }

            if (val == 2)
            {
                return true;
            }

              for (int i = 2; i <= Math.Sqrt(val); i++)
            {
                if (val % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input order of the prime number");
            int orderOfPrimenumber = int.Parse(Console.ReadLine());
            int count = 0;
            int number = 2;

            while(count < orderOfPrimenumber)
            {
               
                if (CheckPrime(number)) 
                {
                    count++;
                }
                number++;
            }
            Console.WriteLine("The " + orderOfPrimenumber + "th prime number is: " + (number - 1));
        }
    }
}