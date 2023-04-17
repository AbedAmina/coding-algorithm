class Program
{
    static bool IsPalindrome(string inputString)
    {
        char[] arr = inputString.ToCharArray();
        Array.Reverse(arr);
        string inputString_reverse = new String(arr);
        return inputString.Equals(inputString_reverse);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a word");
        string inputString = Console.ReadLine();
        bool isPalindrome = IsPalindrome(inputString);
        Console.WriteLine(isPalindrome);
    }

}