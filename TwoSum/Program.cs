using System;
using System.Collections.Generic;
using System.Linq;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        Tuple<int, int> indices = null;
        for(var i = 0; i < list.Count; i++)
        {
            var item1 = list[i];
            for(var j = 0; j < list.Count; j++)
            {
                if (list[i] + list[j] == sum)
                    return indices = new Tuple<int, int>(i, j);
            }
        }

        return indices;
    }

    public static Tuple<int, int> FindTwoSum2(IList<int> list, int sum)
    {
        var result = from n1 in list
                     from n2 in list
                     where n1 + n2 == sum
                     select new Tuple<int, int>(list.IndexOf(n1), list.IndexOf(n2));
        return result.FirstOrDefault();
    }

    public static void Main(string[] args)
    {
        //Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1}, 10);
        Tuple<int, int> indices = FindTwoSum2(new List<int>() { 1, 3, 5, 7, 9 }, 12);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
        Console.ReadLine();
    }
}