﻿Person.name = "Adil";  
System.Console.WriteLine(Person.GetName());  

static class Person
{
    public static string? name;  
    
    public static string GetName()  
    {
        return $"Hello from {name}";  
    }
}