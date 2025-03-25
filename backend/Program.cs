using System;
using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}