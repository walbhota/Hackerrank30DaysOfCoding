//Task
//You are given two classes, Person and Student, where Person is the base class and Student is the derived class.
//Completed code for Person and a declaration for Student are provided for you in the editor.
//Observe that Student inherits all the properties of Person.

//Complete the Student class by writing the following:

//A Student class constructor, which has 4 parameters:
//A string, firstName .
//A string, lastName.
//An integer, idNumber.
//An integer array (or vector) of test scores, scores.
//A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:



using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
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
    public Student(string firstName, string lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
    }

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public string Calculate()
    {
        var average = testScores.Average();
        var res = IsWithin(average, 90, 100) ? "O" :
                    IsWithin(average, 80, 89) ? "E" :
                    IsWithin(average, 70, 79) ? "A" :
                    IsWithin(average, 50, 69) ? "P" :
                    IsWithin(average, 40, 54) ? "D" :
                    "T";
        return res;

    }

    private bool IsWithin(double value, int minimum, int maximum)
    {
        return value >= minimum && value <= maximum;
    }
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}
