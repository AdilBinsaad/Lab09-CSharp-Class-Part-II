﻿Person.name = "Adil"; 
System.Console.WriteLine(Person.GetName());  
var student = new Student();
Student.name = "66030301";
Console.WriteLine(Student.GetName());

class Person
{
    public static string? name;  
    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    
}