using System;
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
Objective
A Node class is provided for you in the editor. A Node object has an integer data field, data, and a Node instance pointer, next, pointing to another node (i.e.: the next node in the list).

A Node insert function is also declared in your editor. It has two parameters: a pointer, head, pointing to the first node of a linked list, and an integer, data, that must be added to the end of the list as a new Node object.

Task
Complete the insert function in your editor so that it creates a new Node (pass data as the Node constructor argument) and inserts it at the tail of the linked list referenced by the head parameter. Once the new node is added, return the reference to the head node.

Sample Input
STDIN   Function
-----   --------
4       T = 4
2       first data = 2
3
4
1       fourth data = 1

Sample Output
2 3 4 1
*/

	public static Node insert(Node head, int data)
    {
        Node novoNode = new Node(data); // cria um novo node com o dado fornecido
        Node ultimoNode = head; // atribui a cabeca da lista a um node auxiliar

        if (head == null)
        {
            // a lista comeca vazia, entao o novo node se torna a cabeca
            return novoNode;
        }

        while (ultimoNode.next != null)
        {
            ultimoNode = ultimoNode.next;
        }

        ultimoNode.next = novoNode; // ao chegar no ultimo node, atribui ao proximo da lista o novo node
        
        return head; // retorna a cabeca da lista
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
		display(head);
	}
}
	
