using System;

public class TextInput {

    public string input { get; set; }
    public virtual void Add(char c)
    {
        input = input + c;
    }
    public string GetValue()
    {
        return input;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        //int enteredNumber;
        //char.IsNumber(c)
        //if (Int32.TryParse(c.ToString(), out enteredNumber))
        if(char.IsNumber(c))
        {
            base.Add(c);
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
        Console.ReadLine();
    }
}