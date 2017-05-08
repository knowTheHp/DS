using System;
namespace PatternMatchingBF {
    /// <summary>
    /// BruteForce pattern matching algorithm
    /// </summary>
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the pattern you want to look for");
            string pattern = Console.ReadLine();
            int matchPosition = PatternMatch(text, pattern);
            Console.WriteLine(matchPosition);
        }
        /// <summary>
        /// Bruteforce algorithm to search for a pattern in a given string.
        /// </summary>
        /// <param name="text">The string in which we will search the pattern.</param>
        /// <param name="pattern">The pattern we want to search for in the string</param>
        /// <returns>start position of the matching pattern</returns>
        static int PatternMatch(string text, string pattern) {
            for (int i = 0; i <= (text.Length - pattern.Length); i++) {
                int j = 0;
                while ((j < pattern.Length) && (pattern[j] == text[i + j])) {
                    j++;
                    if (j == pattern.Length) {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}