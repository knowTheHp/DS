﻿using System;
namespace PatternMatchingBF {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the pattern you want to look for");
            string pattern = Console.ReadLine();
            int matchPosition = PatternMatch(text, pattern);
            Console.WriteLine(matchPosition);
        }

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