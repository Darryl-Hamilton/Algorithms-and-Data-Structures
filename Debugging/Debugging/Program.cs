namespace Debugging
{
    class ScaryBugsForHalloween
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            Console.WriteLine("Sum of array: " + SinfulSumArray(numbers));

            Console.WriteLine("Recursive countdown from 5:");
            RevoltingRecursiveCountdown(5);

            Console.WriteLine("Reversed string: " + WrongWreverse("Hello"));

            int[] data = { 5, 10, 15 };
            Console.WriteLine("Largest number: " + FreakyFindMax(data));

            Console.WriteLine("Fibonacci of 6: " + FeindishFibonacci(6));
        }

        static int SinfulSumArray(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }

        static void RevoltingRecursiveCountdown(int n)
        {
            Console.WriteLine(n);
            if (n >= 0)
            {
                RevoltingRecursiveCountdown(n - 1);
            }
        }

        static string WrongWreverse(string s)
        {
            char[] letters = s.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                char temp = letters[i];
                letters[i] = letters[letters.Length - i - 1];
                letters[letters.Length - i - 1] = temp;
            }
            return new string(letters);
        }

        static int FreakyFindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        static int FeindishFibonacci(int n)
        {
            if (n == 1)
                return 1;
            return FeindishFibonacci(n - 1) + FeindishFibonacci(n - 2);
        }
    }
}
