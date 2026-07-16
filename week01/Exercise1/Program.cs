using System;

class Program
{
    static void Main(string[] args)
    {
        //Input= Ask for the name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        //Input= Ask for the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
       //Output
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }

}