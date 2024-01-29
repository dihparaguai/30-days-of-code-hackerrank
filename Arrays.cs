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
Sample Input
4
1 4 3 2

Sample Output
2 3 4 1
*/

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        static void ReserseN (List<int> arr, int n)
        {
            for (int i = n-1; i > -1 ; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        
        ReserseN(arr, n);
    }
}
