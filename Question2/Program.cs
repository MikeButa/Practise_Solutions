using System;
using System.Collections.Generic;
using System.Linq;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        List<string> result;

        result = names1.ToList();

        for (var i = 0; i < names2.Length; i++)
        {
            if (!result.Contains(names2[i]))
                result.Add(names2[i]);
        }

        //var r = result.GroupBy(n => n).Where(g => g.Count() > 1).Select(x => x.Key).ToList();
        return result.Distinct().ToArray();

    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia", "Emma" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        Console.ReadLine();
    }
}