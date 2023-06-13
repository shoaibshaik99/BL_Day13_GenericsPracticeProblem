class Program {
    static void Main(string[] args) {
        // Test cases with integers
        int result1 = Maximum<int>.TestMaximum(15, 10, 5);
        Console.WriteLine("Test case 1 with integers: Max number at first position: " + result1);

        int result2 = Maximum<int>.TestMaximum(5, 15, 10);
        Console.WriteLine("Test case 2 with integers: Max number at second position: " + result2);

        int result3 = Maximum<int>.TestMaximum(10, 5, 15);
        Console.WriteLine("Test case 3 with integers: Max number at third position: " + result3);

        // Test cases with strings
        string result4 = Maximum<string>.TestMaximum("banana", "apple", "cherry");
        Console.WriteLine("Test case 1 with strings: Max string at first position: " + result4);

        string result5 = Maximum<string>.TestMaximum("apple", "cherry", "banana");
        Console.WriteLine("Test case 2 with strings: Max string at second position: " + result5);

        string result6 = Maximum<string>.TestMaximum("cherry", "banana", "apple");
        Console.WriteLine("Test case 3 with strings: Max string at third position: " + result6);

        // Test cases using the generic class
        Maximum<int> maxInt = new Maximum<int>(15, 10, 5);
        int result7 = maxInt.TestMaximum();
        Console.WriteLine("Test case using the generic class with integers: Max number at first position: " + result7);

        Maximum<string> maxString = new Maximum<string>("banana", "apple", "cherry");
        string result8 = maxString.TestMaximum();
        Console.WriteLine("Test case using the generic class with strings: Max string at first position: " + result8);
    }
}
