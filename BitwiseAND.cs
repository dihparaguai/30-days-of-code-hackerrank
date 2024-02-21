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
STDIN   Function
-----   --------
3       T = 3
5 2     N = 5, K = 2
8 5     N = 8, K = 5
2 2     N = 8, K = 5

Sample Output
1
4
0
*/

class Result
{

    /*
     * Complete the 'bitwiseAnd' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. INTEGER K
     */

    // SOLUCAO COMUM
    public static int bitwiseAnd(int N, int K)
    {
        // N = valor teto a ser percorrido (1 ate (N-1))
        // K = limite a ser devolvido do bit a bit
        
        int maxCount = 0;
        // Loop para comparar todos os valores de i+1 ate N
        for (int i = 1; i < N; i++) 
        {
            // Loop para comparar com todos os valores maiores que i
            for (int j = i + 1; j <= N; j++) 
            {
            // Realiza o AND bit a bit entre i e j
            // (AND bit a bit compara cada bit de dois numeros binarios na mesma posicao de ambos, e retorna um novo numero como resultado da comparacao)
            // o operador & ja faz o processo de comparar cada posicao em bit a bit e realizar a operacao AND, sendo o resultado o novo numero binario ja convertido em int
                int result = i & j;
                // Se o resultado for K-1, ja retorna K-1
                if (result == K - 1) {
                    return K - 1;
                } 
                // Se o resultado for maior que maxCount e menor que K, atualiza maxCount
                else if (result > maxCount && result < K) 
                {
                    maxCount = result;
                }
            }
        }
        return maxCount;
    }

    
/*
    // SOLUCAO MANUAL, NAO UTILIZADA POR TIMEOUT
    public static int bitwiseAnd(int N, int K) 
    {
        // N: valor teto a ser percorrido (1 ate (N-1))
        // K: limite a ser devolvido do bit a bit

        // Variavel para armazenar o maior valor encontrado
        int maxCount = 0;

        // Loop para comparar todos os valores de i+1 ate N
        for (int i = 1; i < N; i++) 
        {
            // Loop para comparar com todos os valores maiores que i
            for (int j = i + 1; j <= N; j++) 
            {
                // Realiza o AND bit a bit entre i e j (comparacao bit a bit)
                int result = CompareBits(i, j);

                // Se o resultado for menor que K e maior que maxCount, atualiza maxCount
                if (result < K && result > maxCount) 
                {
                    maxCount = result;
                }
            }
        }

        // Retorna o maior valor encontrado
        return maxCount;
    }

    static int CompareBits(int i, int j) 
    {
        // Converte i e j em listas de bits binarios
        List<int> numBitI = CreateBinary(i);
        List<int> numBitJ = CreateBinary(j);

        // Cria lista para armazenar o resultado da comparacao bit a bit
        List<int> newBit = new List<int>();

        // Loop para comparar bits correspondentes de i e j
        int count = Math.Min(numBitI.Count, numBitJ.Count);
        for (int m = 0; m < count; m++) 
        {
            // Se ambos os bits forem 1, o bit resultante e 1
            if (numBitI[m] == 1 && numBitJ[m] == 1) 
            {
            newBit.Add(1);
            } 
            else 
            {
            newBit.Add(0);
            }
        }

        // Converte a lista de bits em decimal
        return CreateDecimal(newBit);
    }

    static List<int> CreateBinary(int num) 
    {
        // Lista para armazenar os bits
        List<int> binary = new List<int>();

        // Loop para converter cada digito decimal em binario
        while (num > 0) 
        {
            // Resto da divisao por 2 para obter digito bit
            binary.Add(num % 2);
            // Divide o numero por 2 para obter o proximo digito
            num = num / 2;
        }

        // Retorna a lista de bits
        return binary;
    }

    static int CreateDecimal(List<int> bin) 
    {
        // Soma para armazenar o valor decimal
        int sum = 0;

        // Contador para iterar a lista de bits
        int count = bin.Count;

        // Loop para calcular o valor decimal
        for (int i = 0; i < count; i++) 
        {
            // Multiplica o bit pela potencia de 2 elevado a posicao do bit-1
            sum = sum + bin[i] * (int)Math.Pow(2, count - 1);
            // Decrementa o expoente de 2 para o proximo bit
            count--;
        }

        // Retorna o valor decimal
        return sum;
    }
*/

}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = Result.bitwiseAnd(count, lim);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
