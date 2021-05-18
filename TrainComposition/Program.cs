using System;
using System.Collections.Generic;

public class TrainComposition
{
    // Creating a LinkedList of Strings
    LinkedList<int> train = new LinkedList<int>();

    public void AttachWagonFromLeft(int wagonId)
    {
        train.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        train.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        var removedWagon = train.First;
        train.RemoveFirst();
        return removedWagon.Value;
    }

    public int DetachWagonFromRight()
    {
        var removedWagon = train.Last;
        train.RemoveLast();
        return removedWagon.Value;
    }

    public static void Main(string[] args)
    {
        //TrainComposition train = new TrainComposition();
        //train.AttachWagonFromLeft(7);
        //train.AttachWagonFromLeft(13);
        //Console.WriteLine(train.DetachWagonFromRight()); // 7 
        //Console.WriteLine(train.DetachWagonFromLeft()); // 13
        var rd = RemoveDuplicateChars("abbcbbb");
        Console.ReadLine();
    }

    static string RemoveDuplicateChars(string key)
    {
        LinkedList<char> train = new LinkedList<char>();
        int keyLength = key.Length;
        var result = "";

        foreach (char value in key)
            {
            if (train.Count == 0)
                train.AddLast(value);

            if (train.Count > 0 && train.Last.Value != value)
                    train.AddLast(value);
            }

        foreach (char str in train)
        {
            Console.WriteLine(str);
            result = result + str;
        }
        return result;
    }
}