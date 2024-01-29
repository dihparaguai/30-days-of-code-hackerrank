using System;
using System.Collections.Generic;
using System.IO;
/*
Sample Input
2
Hacker
Rank

Sample Output
Hce akr
Rn ak
*/
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine()); // le quantas strings serao passadas
        List <string> str = new List<string>(); // armazena as strings
        
        for (int i = 0; i < n ; i++) // adiciona cada string na lista
        {
            str.Add(Console.ReadLine());
        }
        
        for (int i = 0; i < n ; i++) // chama a funcao sobre cada string da lista
        {
            StringOddEven(str[i]);
        }
        
        static void StringOddEven (string s) // mostra para cada string:
        {
            for (int i = 0; i < s.Length ; i++) // caracteres nas posicoes pares
            {
                if (i % 2 == 0)
                {
                Console.Write($"{s[i]}");
                }
            }
            Console.Write(" ");
            for (int i = 0; i < s.Length ; i++) // caracteres nas posicoes impares
            {
                if (i % 2 == 1)
                {
                Console.Write($"{s[i]}");
                }
            }
            Console.WriteLine("");
        }
    }
}
