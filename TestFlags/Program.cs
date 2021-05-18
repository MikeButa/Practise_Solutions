using System;
using System.Collections.Generic;
using System.Text;


namespace TestFlags

{
    class Program
    {
        static void Main(string[] args)
        {

            Font font = new Font();
            font.FontProps = FontProperties.Bold | FontProperties.Italic;
            font.Format = fomrating.Left | fomrating.right | fomrating.down;
            Console.WriteLine(font.FontProps);
            Console.WriteLine(font.Format);
            Console.ReadLine();
        }
    }

    [Flags]
    public enum FontProperties
    {
        Bold = 1,
        Italic = 2,
        Underlined = 4,
        None = 8
    }

    [Flags]
    public enum fomrating
    {
        Left = 1,
        right = 2,
        up = 4,
        down = 8,
        None = 16
    }

    public class Font
    {
        FontProperties fontProps;
        fomrating format;
        internal FontProperties FontProps
        {
            get { return fontProps; }
            set { fontProps = value; }
        }

        internal fomrating Format
        {
            get { return format; }
            set { format = value; }
        }

        public Font()
        {
            fontProps = FontProperties.None;
            format = fomrating.None;
        }

    }

}
