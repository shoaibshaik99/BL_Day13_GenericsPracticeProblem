namespace GenericsPracticeProblem
{
    internal class Program
    {
        static int FindMax(int a, int b, int c)
        {
            int max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Finding Maximum using Generics");

            // Test cases
            int result1 = FindMax(15, 10, 5);
            Console.WriteLine("Test case 1: Max number at first position: " + result1);

            int result2 = FindMax(5, 15, 10);
            Console.WriteLine("Test case 2: Max number at second position: " + result2);

            int result3 = FindMax(10, 5, 15);
            Console.WriteLine("Test case 3: Max number at third position: " + result3);
        }
    }
}