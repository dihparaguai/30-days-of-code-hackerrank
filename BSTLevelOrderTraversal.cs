using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

/*
Sample Input
6
3
5
4
7
2
1

Sample Output
3 2 5 1 4 7 
*/

	static void levelOrder(Node root){
        // Write your code here

        // Cria uma fila de nodes (vertices) e coloca a raiz na fila
        Queue<Node> fila = new Queue<Node>();
        fila.Enqueue(root);

        // Funcao que processa os nodes em linha:
        // 1. Remove um node da fila
        // 2. Imprime o valor do node removido
        // 3. Adiciona os filhos do node removido a fila (se existirem)
        // 4. Repete ate que nao tenha mais elementos na fila
        while (fila.Count > 0) 
        {
            // Guarda o primeiro elemento da fila em um node auxiliar e o remove da fila enquanto imprime seu valor
            Node nodeAuxiliar = fila.Dequeue();
            Console.Write(nodeAuxiliar.data + " ");

            // Se existirem filhos (nodes do lado esquerda ou direito), coloca-os ao final da fila.
            if (nodeAuxiliar.left != null)
                fila.Enqueue(nodeAuxiliar.left);

            if (nodeAuxiliar.right != null)
                fila.Enqueue(nodeAuxiliar.right);
        }
    }


	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        levelOrder(root);
        
    }
}
