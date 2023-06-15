
class Program
{
    static void Main(string[] args)
    {
        // Test cases with integers
        int result1 = Maximum<int>.TestMaximum(15, 10, 5, 20, 25);
        Console.WriteLine("Test case 1 with integers: Max number: " + result1);

        int result2 = Maximum<int>.TestMaximum(1, 2, 3, 4, 5);
        Console.WriteLine("Test case 2 with integers: Max number: " + result2);

        int result3 = Maximum<int>.TestMaximum(5);
        Console.WriteLine("Test case 3 with integers: Max number: " + result3);

        int result4 = Maximum<int>.TestMaximum();
        Console.WriteLine("Test case 4 with integers: Max number: " + result4);

        // Test cases with strings
        string result5 = Maximum<string>.TestMaximum("banana", "apple", "cherry", "orange", "grape");
        Console.WriteLine("Test case 1 with strings: Max string: " + result5);

        string result6 = Maximum<string>.TestMaximum("a", "b", "c", "d", "e");
        Console.WriteLine("Test case 2 with strings: Max string: " + result6);

        string result7 = Maximum<string>.TestMaximum("abc");
        Console.WriteLine("Test case 3 with strings: Max string: " + result7);

        string result8 = Maximum<string>.TestMaximum();
        Console.WriteLine("Test case 4 with strings: Max string: " + (result8 ?? "null"));

        // Test cases using the generic class
        Maximum<int> maxInt = new Maximum<int>(15, 10, 5, 20, 25);
        int result9 = maxInt.TestMaximum();
        Console.WriteLine("Test case using the generic class with integers: Max number: " + result9);

        Maximum<string> maxString = new Maximum<string>("banana", "apple", "cherry", "orange", "grape");
        string result10 = maxString.TestMaximum();
        Console.WriteLine("Test case using the generic class with strings: Max string: " + result10);
    }
}