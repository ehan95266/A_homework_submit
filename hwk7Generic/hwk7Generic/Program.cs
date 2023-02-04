using System;
using System.Collections;

namespace hwk7Generic;

public class Program
{
    public static void Main()
    {
        //Stack class
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("I am");
        myStack.Push("Elva");

        Console.WriteLine(myStack.Count);
        Console.WriteLine(myStack.Pop());

        //MyList
        MyList<string> cities = new MyList<string>();
        cities.Add(1, "Chicago");
        cities.Add(2, "Michigan");
        cities.Add(3, "Boston");

        cities.Remove(2);
        cities.Contains("Boston");
        cities.Clear();
        cities.InsertAt("Ohio",4);
        cities.DeleteAt(1);
        cities.Find(3);
    }

}
