using System;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

	static int getHeight(Node root){
      //Write your code here
      
      if (root == null) // caso seja passado uma arvore vazia
      {
          return -1;
      }
      else
      {
        // chamadas recursivas em todos os vertices da arvore
        int alturaEsquerda = getHeight(root.left);
        int alturaDireira = getHeight(root.right);
        
        // quando chegar na folha, o retorno sera 0+1 e cada retorno recursivo sera somado este 1, trazendo a folha mais distante
        return Math.Max(alturaEsquerda, alturaDireira) + 1;
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
        int height=getHeight(root);
        Console.WriteLine(height);
        
    }
}
