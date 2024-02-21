using System;
using System.Collections.Generic;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {
/*
Sample Input
6
1
2
2
3
3
4

Sample Output
1 2 3 4 
*/
    public static Node removeDuplicates(Node head){
        //Write your code here
        // Verifica se a lista esta vazia ou tem apenas um node
        if (head == null || head.next == null) 
        {
            return head;
        }

        // Inicializa um node auxiliar para percorrer a lista
        Node auxNode = head;

        // Percorre a lista enquanto houver nodes
        while (auxNode != null && auxNode.next != null) 
        {
            // Compara o valor do node atual com o valor do proximo node
            if (auxNode.data == auxNode.next.data) {
                // Se sao iguais, remove o proximo node duplicado
                auxNode.next = auxNode.next.next;
            } else {
                // Se nao sao iguais, avanca para o proximo node
                auxNode = auxNode.next;
            }
        }

        // Retorna a cabeca da lista depois da remocao de duplicatas
        return head;
    }
    

	public static  Node insert(Node head,int data)
	{
        Node p=new Node(data);
		
		
		if(head==null)
			head=p;
		else if(head.next==null)
			head.next=p;
		else
		{
			Node start=head;
			while(start.next!=null)
				start=start.next;
			start.next=p;
			
		}
		return head;
    }
	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
      	head=removeDuplicates(head);
		display(head);
	}
}
	
