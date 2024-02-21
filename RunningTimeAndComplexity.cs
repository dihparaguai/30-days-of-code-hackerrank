using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Collections.Generic;

/*
Sample Input
3
12
5
7

Sample Output
Not prime
Prime
Prime
*/

class Solution {
    
    static void Main(String[] args) {
        // Le uma lista de numeros usando funcao estatica
        List<int> numbers = ReadNumbers();
        
        // Chama a funcao que verifica se cada numero da lista eh primo ou nao, e imprime
        PrintPrimes(numbers);
    }


    // Funcao que lee os numeros e armazena em uma lista
    static List<int> ReadNumbers() {
        int qtd = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 0; i < qtd; i++) {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        // Retorna a lista de numeros lidos
        return numbers;
    }


    // Funcao para imprimir se cada numero da lista eh primo ou nao
    static void PrintPrimes(List<int> numbers) {
        // Itera sobre cada numero na lista
        foreach (int number in numbers) {
            // Chama a funcao IsPrime para verificar se o numero eh primo ou nao
            if (IsPrime(number)) {
                Console.WriteLine("Prime");
            } else {
                Console.WriteLine("Not prime");
            }
        }
    }


    // Funcao para verificar se um numero eh primo ou nao
    static bool IsPrime(int number) {
        if (number <= 1) {
            return false;
        }

        // Calcula a raiz quadrada do numero, pois um numero nao sera primo caso qualquer numero ate sua raiz seja divisor dele
        int sqrt = (int)Math.Sqrt(number);

        // Loop para verificar divisores ate a raiz
        for (int i = 2; i <= sqrt; i++) {
            if (number % i == 0) {
                return false;
            }
        }

        // Se nao encontrou divisores...
        return true;
    }
}
