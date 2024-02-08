using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

/*
Objective
Today, we will extend what we learned yesterday about Inheritance to Abstract Classes. Because this is a very specific
object oriented concept, submissions are limited to the few languages that use this construct.

Sample Input
The following input from stdin is handled by the locked stub code in your editor:
The Alchemist
Paulo Coelho
248

Sample Output
The following output is printed by your display() method:
Title: The Alchemist
Author: Paulo Coelho
Price: 248
*/

//Write MyBook class
class MyBook : Book // herdando da classe Book (modificador de acesso iguais)
{
    public int price;
    
    public MyBook (string t, string a,int price) : base (t, a) // ao instanciar a classe MyBook, ja atribuimos aos atributos de Book
    {
        this.price = price;
    }
    
    public override void display ()
    {
        // acessando variaveis tanto de Book quando de MyBook
        Console.WriteLine($"Title: {this.title}"); 
        Console.WriteLine($"Author: {this.author}");
        Console.WriteLine($"Price: {this.price}");
        
    }  
}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}
