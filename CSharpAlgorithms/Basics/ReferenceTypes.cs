using System;
using System.Text.Json;

namespace CSharpAlgorithms.Basics
{
    public class ReferenceTypes
    {
        public ReferenceTypes()
        {
            Person person = new Person() {Id = 4};
            person.Name = "Initialized";
            person.Id = 0;
            Console.WriteLine(JsonSerializer.Serialize(person));
            changeValues(person);
            Console.WriteLine(JsonSerializer.Serialize(person));
            changeValues(ref person);
            Console.WriteLine(JsonSerializer.Serialize(person));
        }

        void changeValues(Person person)
        {
            person.Name = "Changed without reference";
        }

        void changeValues(ref Person person)
        {
            person.Name = "Changed with reference";
        }
    }
    // public void Foo(Image image)
    // {
    // // This change won't be seen by the caller: it's changing the value
    // // of the parameter.
    // image = Image.FromStream(...);
    // }
    //
    // public void Foo(ref Image image)
    // {
    // // This change *will* be seen by the caller: it's changing the value
    // // of the parameter, but we're using pass by reference
    // image = Image.FromStream(...);
    // }
    //
    // public void Foo(Image image)
    // {
    // // This change *will* be seen by the caller: it's changing the data
    // // within the object that the parameter value refers to.
    // image.RotateFlip(...);
    // }
}

public class Person {
    public string Name {get;set;}
    public int Id {get;set;}
}