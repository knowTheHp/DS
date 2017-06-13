using System;

namespace BoyerMoorePM {
    class Program {
        static void Main(string[] args) {
            string Text = "a pattern matching algorithm";
            string Pattern = "rithm";
            int i = Find(Text,Pattern);
        }
        //Boyer Moore Algorithm
        static int Find(string Text,string Pattern) {
            try {

                int i, j = 0;

                //get the text and pattern size
                int TextSize = Text.Length;
                int PatternSize = Pattern.Length;

                bool flag = false;

                i=PatternSize-1; //index for scanning the text
                j=PatternSize-1; //index for scanning the pattern
                while (i<=TextSize-1) {
                    if (Pattern[j]==Text[i]) {
                        if (j==0) {
                            Console.WriteLine($"Pattern found at position {i+1}");
                            flag=true; //detects the presence of the pattern in the text
                        }
                        i--;
                        j--;
                    } else {
                        i=i+PatternSize-Math.Min(j,1+Text.IndexOf(Text[i]));
                        j=PatternSize-1;
                    }
                }
                if (!flag) {
                    return 1;
                } else {
                    return -1;
                }
            } catch (Exception) {
                return -1;
            }
        }
    }
}