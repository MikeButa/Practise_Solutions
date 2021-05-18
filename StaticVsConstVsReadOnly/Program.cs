using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsConstVsReadOnly
{
    class Example
    {
        int x; //Non-static variable
        static int y = 200; //Static Variable
        const float PI = 3.14f; //Const Variable
        static readonly bool flag; //Readonly Variable
        public Example(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Example.y);
            Console.WriteLine(Example.PI);
            Example obj1 = new Example(501, true);
            Example obj2 = new Example(100, false);
            Console.WriteLine(obj1.x + " " + obj2.x);
            Console.WriteLine(obj1.flag + " " + obj2.flag);
            Console.WriteLine("Press any key to exist.");
            Console.ReadLine();
        }
    }
}
