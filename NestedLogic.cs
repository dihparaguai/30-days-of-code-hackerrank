using System;
using System.Collections.Generic;
using System.IO;

/*
Sample Input
STDIN       Function
-----       --------
9 6 2015    day = 9, month = 6, year = 2015 (date returned)
6 6 2015    day = 6, month = 6, year = 2015 (date due)

Sample Output
45
*/

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        // Le as datas de devolucao e vencimento e divide em um array (dia, mes, ano)
        string[] dateReturnedString = Console.ReadLine().Split(" ");
        string[] dateDueString = Console.ReadLine().Split(" ");

        // Converte a data de devolucao e vencimento em um array de inteiros
        int[] dateReturned = Array.ConvertAll(dateReturnedString, int.Parse);
        int[] dateDue = Array.ConvertAll(dateDueString, int.Parse);

        // Se o ano da devolucao for maior que o ano do vencimento
        if (dateReturned[2] > dateDue[2])
        {
            Console.WriteLine("10000");
        }
        // Se o mes da devolucao for maior que o mes do vencimento, mas o ano for o mesmo
        else if (dateReturned[1] > dateDue[1] && dateReturned[2] == dateDue[2])
        {
            Console.WriteLine($"{500 * (dateReturned[1] - dateDue[1])}");
        }
        // Se o dia da devolucao for maior que o dia do vencimento, mas o mes for o mesmo
        else if (dateReturned[0] > dateDue[0] && dateReturned[1] == dateDue[1])
        {
            Console.WriteLine($"{15 * (dateReturned[0] - dateDue[0])}");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
