// Example ▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒ ▒▒▒▒▒ ▒▒▒▒▒. + ▒▒▒▒▒▒▒ String.

using System;

class StringObjects
{
    static void Main()
    {
        String A = "Language";
        char[] symbols = { 'L', 'a', 'n', 'g', 'u', 'a', 'g', 'e' };

        String B = new String(symbols);

        static bool string_comparison(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i]) return false;
                }
            }

            return true;
        }

        String C = "Language C#";

        Console.WriteLine($"A == B: {string_comparison(A, B)}.");
        Console.WriteLine($"A == C: { string_comparison(A, C)}.");
    }
}
