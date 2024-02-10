using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}
/*
Task
The AdvancedArithmetic interface and the method declaration for the abstract divisorSum(n) method are provided for you in the editor below.

Complete the implementation of Calculator class, which implements the AdvancedArithmetic interface. The implementation for the divisorSum(n) method must return the sum of all divisors of  n.

Sample Input
6

Sample Output
I implemented: AdvancedArithmetic
12
*/
public class Calculator : AdvancedArithmetic
{
    // metodo obrigatorio da interface 'AdvancedArithmetic'
    public int divisorSum(int n) 
    {
        int sum = 0;
        for (int i = 1 ; i <= n ; i++)
        {
            if (n % i == 0)
            {
                sum =  sum + i;
            }
        }
        return sum;
    }
}

class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}
