using System;
using System.Collections.Generic;
using System.IO;
/*
Sample Input
3
sam 99912222
tom 11122222
harry 12299933
sam
edward
harry

Sample Output
sam=99912222
Not found
harry=12299933
*/
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> agenda = new Dictionary<string, string>();
        for (int i = 0; i < n ; i++)
        {
            string [] nomeTelefone = Console.ReadLine().Split(" "); // recebe a string e ja reparte ela e coloca cada parte em uma posicao do array de strings
            agenda.Add(nomeTelefone[0], nomeTelefone[1]); // adiciona cada pedaco do array de strings como par chave e valor
        }
        
        bool loop = true; // variavel para manter o loop em execucao
        while (loop == true) // loop que vai rodar enquanto o usuario adicionar nomes para buscar na agenda
            {
            try // tentativa de rodar o codigo com possibilidade de erro runtime exception
            {
                string nome = Console.ReadLine();
                if (agenda.ContainsKey(nome)) // se o nome exitir na agenda...
                {
                    if (agenda[nome] == null) // caso o nome nao tenha numero...
                    {
                        Console.WriteLine($"{nome}");
                    }
                    else
                    {
                    Console.WriteLine($"{nome}={agenda[nome]}");
                    }
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            catch (Exception e) // quando o usuario finalizar as entradas e causar um erro, o loop sera parado
            {
                loop = false;
            }
        }
    }
}
