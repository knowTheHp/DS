using System;

namespace BinarySearch {
    class Program {
        static void Main(string[] args) {
            int[] BinarySearchArray = { 0,2,3,4,6,8,10 };
            Console.WriteLine("Input a number you want to look for");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            /*No recursive binary search*/
            int i = BinarySearch(BinarySearchArray,BinarySearchArray.Length,searchNumber);
            if (i!=-1) {
                Console.WriteLine($"Match found at Index {i}");
            } else {
                Console.WriteLine("no match found");
            }

            /*Recursive binary search*/
            int result = RecursiveBinarySearch(BinarySearchArray,0,BinarySearchArray.Length-1,searchNumber);
            if (result!=-1) {
                Console.WriteLine($"Item is found at index {result}");
            } else {
                Console.WriteLine("No match found");
            }
        }

        //size is array size
        //x is the number to search in array
        static int BinarySearch(int[] array,int size,int x) {
            int start = 0;
            int end = size-1;
            while (start<=end) {
                int mid = start+end/2;
                if (array[mid]==x) {
                    return mid;
                } else if (x<array[mid]) {
                    end=mid-1;
                } else if (x>array[mid]) {
                    start=start+1;
                }
            }
            return -1;
        }

        //recursive
        static int RecursiveBinarySearch(int[] array,int begin,int end,int search) {
            if (begin<=end) {
                int medium = begin+end/2;
                if (search<array[medium]) {
                    end=medium-1;
                    return RecursiveBinarySearch(array,begin,end,search);
                } else if (search>array[medium]) {
                    begin=medium+1;
                    return RecursiveBinarySearch(array,begin,end,search);
                } else {
                    return medium;
                }
            }
            return -1;
        }
    }
}