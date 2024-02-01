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
5

Sample Output 1
1


Sample Input 2
13

Sample Output 2
2
*/


class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());
        
        List<int> bins = new List<int> (); // lista para guardar os binarios
        int max = 0; // armazena a maior sequencia
        int count = 0; // realiza a contagem de sequencias
        int i = 0; // contador para while
        while (n > 0)
        {
            bins.Add(n % 2); // guarda o resto de n atual no array
            n = n / 2; // atualiza valor de n
            i ++;            
        }
        
        i = 0;      
        while (i < bins.Count)
        {
            if (bins[i] == 1) // se o binario for 1....
            {
                count ++; // acrescenta na soma de sequencia
            }
            else
            {
                count = 0; // zera a sequencia   
            }
            
            if (count > max) // atribui a maior sequencia
            {
                max = count;
            }
            i++;
        }
        Console.WriteLine($"{max}");
    }
}
