using System;

namespace KMP {
    class Program {
        static void Main(string[] args) {
            string Text = "abxabcabcaby";
            string Pattern = "abcaby";
            bool result = KmpAlgorithm(Text.ToCharArray(),Pattern.ToCharArray());
            Console.WriteLine(result);
        }

        static int[] TemporaryArray(char[] Pattern) {
            int[] F = new int[Pattern.Length];
            int i = 1;
            int j = 0;
            while (i<Pattern.Length) {
                if (Pattern[i]==Pattern[j]) {
                    F[i]=j+1;
                    j++;
                    i++;
                } else {
                    F[i]=0;
                    i++;
                }
            }
            return F;
        }

        static bool KmpAlgorithm(char[] Text,char[] Pattern) {
            int[] tempArray = TemporaryArray(Pattern);
            int i = 0;
            int j = 0;
            while (i<Text.Length&&j<Pattern.Length) {
                if (Text[i]==Pattern[j]) {
                    i++;
                    j++;
                } else {
                    if (j>0) {
                        j=tempArray[j-1];
                    } else {
                        i++;
                    }
                }
            }
            if (j==Pattern.Length) {
                return true;
            }
            return false;
        }
    }
}