using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/*
Sample Input 1
3
3 2 1

Sample Output 1
Array is sorted in 3 swaps.
First Element: 1
Last Element: 3
*/

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        
        // Track number of elements swapped during a single array traversal
        int numberOfSwaps = 0;
        
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < n - 1; j++) 
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1]) 
                {
                    int aux = a[j];
                    a[j] = a[j+1];
                    a[j+1] = aux;
                    numberOfSwaps++;
                }
            }
            
            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0) 
            {
                break;
            }
        }
        
        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[(a.Count-1)]}");
    }
}
