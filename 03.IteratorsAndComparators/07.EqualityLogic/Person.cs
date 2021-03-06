﻿using System;
using System.Collections.Generic;
using System.Text;

public class Person : IComparable<Person>
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        var result = this.Name.CompareTo(other.Name);
        if (result == 0)
        {
            result = this.Age.CompareTo(other.Age);
        }
        return result;
    }


    public override bool Equals(object obj)
    {
        Person other = obj as Person;
        return this.Name == other.Name && this.Age == other.Age;
    }

    public override int GetHashCode()
    {
        return (this.ToString()).GetHashCode();
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }
}

