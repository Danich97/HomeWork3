Console.Write("Please input your number: ");
string x = Console.ReadLine();
int val = int.Parse(x);

bool isPrime = CheckPrime(val);

if (isPrime)
{
    Console.WriteLine($"{val} is a prime number.");
}
else
{
    Console.WriteLine($"{val} is not a prime number.");
}

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

    int val2 = 2;
    while (val2 < Math.Sqrt(val))
    {
        if (val % val2 == 0)
        {
            return false;
        }
        val2++;
    }

    return true;
}