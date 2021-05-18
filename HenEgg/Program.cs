using System;

public interface IFowl
{
    Egg Lay();
}

public class Hen : IFowl
{
    //private readonly Egg ;
    public Hen()
    {
    }

    public Egg Lay()
    {
        return new Egg();
    }
}

public class Egg
{

    private readonly IFowl fowl;

    public Egg()
    { }

    public Egg(Func<IFowl> createFowl)
    {
        fowl = createFowl();
    }

    public IFowl Hatch()
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //      var hen1 = new Hen();
        //      var egg = hen1.Lay();
        //      var childHen = egg.Hatch();
    }
}