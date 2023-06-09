namespace GenericsPracticeProblem
{
    internal class Program
    {
        static string FindMax(string a, string b, string c)
        {
            string max = a;
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

            //Ascending order is a A b B c C...
            //Is it lexographic order?
            // Test cases
            string result1 = FindMax("Car", "Amphoteric", "Brain");
            Console.WriteLine("Test case 1: Max number at first position: " + result1);

            string result2 = FindMax("Brain", "Car", "Amphoteric");
            Console.WriteLine("Test case 2: Max number at second position: " + result2);

            string result3 = FindMax("Amphoteric", "Brain", "Car");
            Console.WriteLine("Test case 3: Max number at third position: " + result3);
        }
    }
}