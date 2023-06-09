namespace GenericsPracticeProblem
{
    internal class Program
    {
        static float FindMax(float a, float b, float c)
        {
            float max = a;
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
            float result1 = FindMax(15.25f, 10.65f, 5.89f);
            Console.WriteLine("Test case 1: Max number at first position: " + result1);

            float result2 = FindMax(10.65f, 15.25f, 5.89f);
            Console.WriteLine("Test case 2: Max number at second position: " + result2);

            float result3 = FindMax(10.65f, 5.89f, 15.25f);
            Console.WriteLine("Test case 3: Max number at third position: " + result3);
        }
    }
}