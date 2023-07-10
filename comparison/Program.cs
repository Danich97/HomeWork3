using System.Diagnostics;

namespace comparison
{
    public class Program
    {
        public static void SortInt(int[] array)
        {
            Array.Sort(array);
        }

        public static void SortObject(object[] array)
        {
            Array.Sort(array);
        }

        static void Main(string[] args)
        {
            const int N = 1000000;
            int[] array1 = new int[N];
            object[] array2 = new object[N];

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                array1[i] = rnd.Next();
                array2[i] = rnd.Next();
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            SortInt(array1);
            stopwatch.Stop();

            Console.WriteLine("Time taken to sort array1: " + stopwatch.ElapsedMilliseconds + " ms");

            stopwatch.Reset();

            stopwatch.Start();
            SortObject(array2);
            stopwatch.Stop();

            Console.WriteLine("Time taken to sort array2: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}