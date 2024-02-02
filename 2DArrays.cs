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
Context
Given a  2D Array, :
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
We define an hourglass in to be a subset of values with indices falling in this pattern in 's graphical representation:
a b c
  d
e f g
There are  hourglasses in , and an hourglass sum is the sum of an hourglass' values.

Task
Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.

Example
In the array shown above, the maximum hourglass sum is  for the hourglass in the top left corner.

Input Format
There are  lines of input, where each line contains  space-separated integers that describe the 2D Array .


Sample Input
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0

Sample Output
19
*/

class Result
{
    public static void CalculateAmpulheta(List<List<int>> array)
    {
        int maxSum = int.MinValue; // guarda o valor da soma maxima da submatriz 3x3
        int countRows = array.Count; // guarda a quantidade de linhas
        int countCols = array[0].Count; // guarda a quantidade de colunas

        for (int row = 0; row <= countRows - 3; row++) // percorre todas as linhas da matriz ate a ultima -3
        {
            for (int col = 0; col <= countCols - 3; col++) // percorre todas as colunas da matriz ate a ultima -3
            {
                int sumNow = 0; // guarda o valor da soma atual da submatriz

                for (int j = 0; j < 3; j++) // percorre todas as linhas da matriz atual 3x3
                {
                    for (int i = 0; i < 3; i++) // percorre todas as colunas da matriz atual 3x3
                    {
                        int rowNow = row + j; // atribui o valor inicial da linha da matriz + valor da posicao atual da submatriz 
                        int colNow = col + i; // atribui o valor inicial da coluna da matriz + valor da posicao atual da submatriz

                        if (!(j == 1 && (i == 0 || i == 2))) // verifica se as posicoes da submatriz nao estao no intervalo 1,0 ou 1,3
                        {
                            sumNow = sumNow + array[rowNow][colNow]; // guarda a soma da submatriz atual
                        }
                    }
                }

                if (sumNow > maxSum) // compara a soma da submatriz atual com o valor maximo ja guardado
                {
                    maxSum = sumNow;
                }
            }
        }

        Console.WriteLine($"{maxSum}");
    }
}


class Solution
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        
        Result.CalculateAmpulheta(arr);
    }
    
    
}
