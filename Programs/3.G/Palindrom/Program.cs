// See https://aka.ms/new-console-template for more information

bool IsPalindrome(string s)
{
    if (s.Length <= 1)
        return true;

    if (s[0] == s[s.Length - 1])
        return IsPalindrome(s.Substring(1, s.Length - 2));

    return false;
}

string word = "atom";

if (IsPalindrome(word) == true)
    Console.WriteLine(word + " is a palindrome");
else
    Console.WriteLine(word + " is not a palindrome");

