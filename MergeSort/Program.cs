﻿using System;
namespace Program {
    class MergeSortAlgorithm {
        static public void MergeSort(int[] numbers,int left,int mid,int right) {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end=(mid-1);
            tmp_pos=left;
            num_elements=(right-left+1);
            while ((left<=left_end)&&(mid<=right)) {
                if (numbers[left]<=numbers[mid])
                    temp[tmp_pos++]=numbers[left++];
                else
                    temp[tmp_pos++]=numbers[mid++];
            }
            while (left<=left_end)
                temp[tmp_pos++]=numbers[left++];
            while (mid<=right)
                temp[tmp_pos++]=numbers[mid++];
            for (i=0;i<num_elements;i++) {
                numbers[right]=temp[right];
                right--;
            }

        }
        static public void Sort(int[] numbers,int left,int right) {
            int mid;
            if (right>left) {
                mid=(right+left)/2;
                Sort(numbers,left,mid);
                Sort(numbers,(mid+1),right);
                MergeSort(numbers,left,(mid+1),right);
            }
        }
        static void Main(string[] args) {
            int[] numbers = { 3,8,7,5,2,1,9,6,4 };
            int len = 9;
            Console.WriteLine("MergeSort :");
            Sort(numbers,0,len-1);
            for (int i = 0;i<9;i++)
                Console.WriteLine(numbers[i]);
            Console.Read();
        }
    }
}