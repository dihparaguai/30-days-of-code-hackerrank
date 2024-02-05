using System;
using System.Linq;

/*
Objective
Today, we're delving into Inheritance. Check out the attached tutorial for learning materials and an instructional video.

Task
You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the properties of Person.

Sample Input
Heraldo Memelli 8135627
2
100 80

Sample Output
Name: Memelli, Heraldo
ID: 8135627
Grade: O
*/


class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person
{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student (string firstName, string lastName, int identification, int[] testScores) : base (firstName, lastName, identification)
    {
        this.testScores = new int[testScores.Length]; // cria um novo array com o tamanho do que sera recebido
        Array.Copy(testScores, this.testScores, testScores.Length); // copia todos os scores recebidos para o array do objeto
    }
    
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public string Calculate()
    {
        switch (testScores.Average())
        {
            case < 40 : return "T";
            break;
            
            case < 55 : return "D";
            break;
            
            case < 70 : return "P";
            break;
            
            case < 80 : return "A";
            break;
            
            case < 90 : return "E";
            break;
            
            case <= 100 : return "O";
            break;
            
            default : return "";
            break;
        }
        
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}
