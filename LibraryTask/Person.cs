﻿namespace LibraryTask;

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
}
