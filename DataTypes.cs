using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        
        // Read and save an integer, double, and String to your variables.
        
        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        
        int i2;
        double d2;
        string s2;
        
        i2 = int.Parse(Console.ReadLine()!); // sou obrigado a usar o .Parse nesse caso
        d2 = double.Parse(Console.ReadLine()!); // sou obrigado a usar o .Parse nesse caso
        s2 = Console.ReadLine()!;
        
        Console.WriteLine(i2 + i);
        Console.WriteLine((d2 + d).ToString("N1")); // mesmo sendo double, precisa usar o ToString para mostrar o ponto
        Console.WriteLine(s + s2);
        
        

    }
}
