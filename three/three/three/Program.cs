using System;

public class Program
{
    public static void Main1()
    {
        Person myPerson = new Person();
        myPerson.Greet();

        Student myStudent = new Student();
        myStudent.SetAge(21);
        myStudent.Greet();
        myStudent.ShowAge();
        myStudent.Study();

        Teacher myTeacher = new Teacher();
        myTeacher.SetAge(30);
        myTeacher.Greet();
        myTeacher.Explain();
    }
}

public class Person
{
    protected int age;

    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int n)
    {
        age = n;
    }
}

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
        Console.ReadLine();
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is {0} years old", age);
        Console.ReadLine();
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
        Console.ReadLine();
    }
}