using System;

namespace palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "-" + IsPalindrome("teste") + "-"  );
            Console.WriteLine( "-" + IsPalindrome("ana") + "-" );
        }

        private static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            char[] letters = word.ToCharArray();
            char[] reverse = new char[letters.Length];
            int contador = 0;
            for (int i = letters.Length-1; i >= 0; i--)
            {
                reverse[contador++] = letters[i];
            }
            Array.Reverse(letters);
            string reverseWord = new string(reverse);
            return  (word == reverseWord);
        }
    }
}
