using System;
using System.Collections.Generic;
using System.Linq;
/*
Sample Input
6
riya riya@gmail.com
julia julia@julia.me
julia sjulia@gmail.com
julia julia@gmail.com
samantha samantha@gmail.com
tanya tanya@gmail.com

Sample Output
julia
julia
riya
samantha
tanya
*/

class Solution {
    static void Main(string[] args) 
        {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        // Cria uma lista de objeto pessoa para armazenar os dados das pessoas
        List<Person> people = new List<Person>();

        for (int i = 0; i < N; i++) 
        {
            string[] input = Console.ReadLine().TrimEnd().Split(' ');
            string firstName = input[0];
            string emailID = input[1];

            // Adiciona a pessoa a lista de objeto de pessoas
            people.Add(new Person (firstName, emailID));
        }

        // Filtra a lista para pessoas com email '@gmail.com'
        var filteredPeople = people.Where(person => person.EmailID.Contains("@gmail.com"));

        // Ordena a lista por nome
        var sortedPeople = filteredPeople.OrderBy(person => person.FirstName).ToList();

        // Exibe o nome de cada pessoa na lista ordenada
        foreach (var person in sortedPeople) 
        {
            Console.WriteLine($"{person.FirstName}");
        }
    }
}

// Classe para representar cada pessoa da tabela
class Person {
    public string FirstName { get; }
    public string EmailID { get; }

    public Person (string firstName, string emailID)
    {
        this.FirstName = firstName;
        this.EmailID = emailID;
    }
}
