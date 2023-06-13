const int N = 5;
int[] array = new int[N];

Console.WriteLine("Input numbers for array: ");

for  (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Input number that you are looking for: ");

int lookingNumber = int.Parse(Console.ReadLine());
bool matchNumber = true;

for (int i = 0;i < array.Length; i++)
{
    if (lookingNumber == array[i])
    {
        matchNumber = true;
        Console.WriteLine("The array has numer " + lookingNumber + " and its position in array " + (i + 1)); // I wrote i+1 to show user exacty place of the looking number
        break;
    }
    else matchNumber = false;
}
if (!matchNumber)
{
    Console.WriteLine("The array doesn't include number " + lookingNumber);
}

