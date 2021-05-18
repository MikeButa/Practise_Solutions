using System;
using System.Collections.Generic;
using System.Linq;


public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        int result = 0;
        for(int i = 0; i < sortedArray.Length; i++)
        {
            if (sortedArray[i] == lessThan)
            {
                return i + 1;
            }
            else if (sortedArray[i] >= lessThan)
            {
                return i;
            }
        }

        return result;
    }

    public static int CountNumbersLessThan(int[] sortedArray, int lessThan)
    {
        int minNum = 0;
        int maxNum = sortedArray.Length - 1;
        int midResult = 0;

        while (minNum <= maxNum)
        {
            int mid = (minNum + maxNum) / 2;
            if (lessThan == sortedArray[mid])
            {
                return mid;
                
            }
            else if (lessThan < sortedArray[mid])
            {
                maxNum = mid - 1;
                midResult = mid;
            }
            else
            {
                minNum = mid + 1;
                midResult = mid;
            }
        }

        return midResult;
    }

    public static int BinarySearch(int[] sortedArray, int searchInt)
    {
        int minNum = 0;
        int maxNum = sortedArray.Length - 1;

        while (minNum <= maxNum)
        {
            int mid = (minNum + maxNum) / 2;
            if (searchInt == sortedArray[mid])
            {
                return sortedArray[mid];
            }
            else if (searchInt < sortedArray[mid])
            {
                maxNum = mid - 1;
            }
            else
            {
                minNum = mid + 1;
            }
        }

        return 0;
    }

    public static void Main(string[] args)
    {
        //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1,2, 3, 5, 7 }, 4));
        //Console.WriteLine(SortedSearch.CountNumbersLessThan(new int[] { 1,2, 3, 5, 7 }, 4));
        //Console.WriteLine(SortedSearch.BinarySearch(new int[] { 1, 3, 5, 7, 9, 11 }, 5));
        //Console.WriteLine(4 / 2);
        //Console.WriteLine(7 / 2);
        //Console.WriteLine(9 / 2);
        //var r = OrderChars("ab", "ab");
        //var re = OrderChars("b1", "a0");
        //var rd = OrderChars("a", "b");

        var rd = RemoveDuplicateCharsFast("abbcbbb");
        Console.ReadLine();
    }

    public static IEnumerable<char> OrderChars(params string[] strings)
    {
        return strings.SelectMany(str => str.ToCharArray())
            .Where(chr => char.IsLetter(chr)).OrderBy(chr => chr);
    }

    static string RemoveDuplicateCharsFast(string key)
    {
        // Remove duplicate chars using char arrays.
        int keyLength = key.Length;

        // Store encountered letters in this array.
        char[] table = new char[keyLength];
        int tableLength = 0;

        // Store the result in this array.
        char[] result = new char[keyLength];
        int resultLength = 0;

        foreach (char value in key)
        {
            // Scan the table to see if the letter is in it.
            bool exists = false;
            for (int i = 0; i < tableLength; i++)
            {
                if (value == table[i])
                {
                    exists = true;
                    break;
                }
            }
            // If the letter is new, add to the table and the result.
            if (!exists)
            {
                table[tableLength] = value;
                tableLength++;

                result[resultLength] = value;
                resultLength++;
            }
        }
        // Return the string at this range.
        return new string(result, 0, resultLength);
    }

    static string RemoveDuplicateChars(string key)
    {
        int keyLength = key.Length;

        char[] table = new char[keyLength];
        int tableLength = 0;

        char[] result = new char[keyLength];
        int resultLength = 0;

        foreach (char value in key)
        {
            bool exists = false;
            for (int i = 0; i < tableLength; i++)
            {
                if (value == table[i])
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                table[tableLength] = value;
                tableLength++;

                result[resultLength] = value;
                resultLength++;
            }
        }
        return new string(result, 0, resultLength);
    }

}