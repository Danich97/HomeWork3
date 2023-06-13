const int N = 5;
int[] array = new int[N];

Console.WriteLine("Input numbers for array: ");

for (int i = 0; i < N; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Reverse array: ");

for (int i = N-1; i >= 0; i--)
{
    Console.Write(array[i] + " ");
}
Console.ReadLine(); 