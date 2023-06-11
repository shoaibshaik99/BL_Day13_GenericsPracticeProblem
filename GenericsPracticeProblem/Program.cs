namespace GenericsPracticeProblem
{
    internal class Program
    {
        static T FindMax<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
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

        static void Main()
        {
            Console.WriteLine("Finding Maximum using Generics");

            string result1 = FindMax("Car", "Amphoteric", "Brain");
            Console.WriteLine("Test case 1: Max String at first position: " + result1);

            int result2 = FindMax(21, 86, 55);
            Console.WriteLine("Test case 2: Max Integer at second position: " + result2);

            float result3 = FindMax(26.58f, 99.23f, 206.74f);
            Console.WriteLine("Test case 3: Max float at third position: " + result3);
        }
    }
}