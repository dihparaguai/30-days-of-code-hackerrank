using System;
using System.Collections.Generic;
using System.IO;
/*
A palindrome is a word, phrase, number, or other sequence of characters which reads the same backwards and forwards. Can you determine if a given string, s, is a palindrome?

To solve this challenge, we must first take each character in s, enqueue it in a queue, and also push that same character onto a stack. Once that's done, we must dequeue the first character from the queue and pop the top character off the stack, then compare the two characters to see if they are the same; as long as the characters match, we continue dequeueing, popping, and comparing each character until our containers are empty (a non-match means s isn't a palindrome).

Sample Input
racecar

Sample Output
The word, racecar, is a palindrome.
*/
class Solution {
    //Write your code here
    
    List<char> stackPilha = new List<char>(); // lista que ira guardar valores como uma pilha (lifo)
    List<char> queueFila = new List<char>(); // lista que ira guardar valores como uma fila (fifo)

    // adiciona valor a pilha
    public void pushCharacter (char a)
    {
        stackPilha.Add(a);
    }
    
    // adiciona valor a fila
    public void enqueueCharacter (char a)
    {
        queueFila.Add(a);
    }
    
    // remove valor da pilha e devolve o valor removido
    public char popCharacter ()
    {
        char aux = stackPilha[stackPilha.Count-1];
        stackPilha.RemoveAt(stackPilha.Count-1);
        return aux;
    }
    
    // remove valor da fila e devolve o valor removido
    public char dequeueCharacter ()
    {
        char aux = queueFila[0];
        queueFila.RemoveAt(0);
        return aux;
    }
    
    
    


    static void Main(String[] args) {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}
