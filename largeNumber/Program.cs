using System.Text;

namespace LargeNumberClass
{
    class LargeNumber
    {
        private string value;

        public LargeNumber(string initialValue)
        {
            value = initialValue;
        }

        public LargeNumber Add(LargeNumber other)
        {
            int maxLength = Math.Max(value.Length, other.value.Length);
            int carry = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = GetDigit(i);
                int digit2 = other.GetDigit(i);

                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                result.Insert(0, (sum % 10).ToString());
            }

            if (carry > 0)
            {
                result.Insert(0, carry.ToString());
            }

            return new LargeNumber(result.ToString());
        }

        public LargeNumber Subtract(LargeNumber other)
        {
            int maxLength = Math.Max(value.Length, other.value.Length);
            int borrow = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = GetDigit(i);
                int digit2 = other.GetDigit(i);

                int diff = digit1 - digit2 - borrow;

                if (diff < 0)
                {
                    diff += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                result.Insert(0, diff.ToString());
            }

            // Remove leading zeros
            while (result.Length > 1 && result[0] == '0')
            {
                result.Remove(0, 1);
            }

            return new LargeNumber(result.ToString());
        }

        private int GetDigit(int index)
        {
            if (index < value.Length)
            {
                return value[value.Length - 1 - index] - '0';
            }
            return 0;
        }

        public override string ToString()
        {
            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LargeNumber num1 = new LargeNumber("154687513216549687431245874899");
            LargeNumber num2 = new LargeNumber("997984897984994521658798494154");

            LargeNumber sum = num1.Add(num2);
            Console.WriteLine("Sum: " + sum);

            LargeNumber difference = num1.Subtract(num2);
            Console.WriteLine("Difference: " + difference);
        }
    }
}
