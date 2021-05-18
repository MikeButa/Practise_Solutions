using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            string[] array1 = { "Mike", "Sipho", "John", "Victor" };
            string[] array2 = { "Mike", "Sipho", "Cathy", "Ben" };
            string[] result = Program.uniqueNamesInArrays(array1, array2);

            foreach(var name in result)
            {
                Console.WriteLine(String.Format("name is {0} and", name));
            }

            Console.ReadLine();
        }

        public static string[] uniqueNamesInArrays(string[] names1, string[] names2)
        {
            List<string> results;

            results = names1.ToList();
            for (var i = 0; i < names2.Length; i++)
            {
                if (!results.Contains(names2[i]))
                    results.Add(names2[i]);
            }

            return results.ToArray();
        }

        public static string[] commonNamesInArrays(string[] names1, string[] names2)
        {
            List<string> results;

            results = names1.ToList();
            //for (var i = 0; i < names1.Length; i++)
            //{
            //    for(var j = 0; j < names2.Length; j++)
            //    {
            //        if()
            //            results.Add(names2[i]);
            //    }
            //    if (!results.Contains(names2[i]))
            //        results.Add(names2[i]);
            //}

            return results.ToArray();
        }


    }
}
