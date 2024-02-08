using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

/*
The absolute difference between two integers, a and b, is written as . The maximum absolute difference between two integers elements in a set of positive integers, , is the largest absolute difference between any two integers in elements.

The Difference class is started for you in the editor. It has a private integer array (elements) for storing  non-negative integers, and a public integer (maximumDifference) for storing N the maximum absolute difference.

Sample Input
STDIN   Function
-----   --------
3       __elements[] size N = 3
1 2 5   __elements = [1, 2, 5]

Sample Output
4
*/

	// Add your code here
    
    public Difference(int[] elements)
    {
        this.elements = (int[])elements.Clone(); // recebe um vetor e clona, o metodo clone retorna um objeto, sendo transformado em um vetor de int
    }
    
    public void computeDifference ()
    {
        maximumDifference = 0;
        for (int i = 0 ; i < elements.Length ; i++)
        {
            for (int j = i+1; j < elements.Length ; j++)
            {
                int difference = (int)Math.Abs(elements[i] - elements[j]);
                if (difference > maximumDifference)
                {
                    maximumDifference = difference;
                }
                difference = 0;
            }
        }
    }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
