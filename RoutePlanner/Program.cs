using System;

public class RoutePlanner
{
    public static bool RouteExists(int fromRow, int fromColumn, int toRow, int toColumn,
                                      bool[,] mapMatrix)
    {
        // getting upper bound
        int uBound0 = mapMatrix.GetUpperBound(0);
        int uBound1 = mapMatrix.GetUpperBound(1);
        for (int i = 0; i <= uBound0; i++)
        {
            for (int j = 0; j <= uBound1; j++)
            {
                bool res = mapMatrix[i, j];
                Console.WriteLine(res);
            }
        }

        return true;
    }

    public static void traverseArray(bool[,] mapMatrix)
    {
        // getting upper bound
        int uBound0 = mapMatrix.GetUpperBound(0);
        int uBound1 = mapMatrix.GetUpperBound(1);
        for (int i = 0; i <= uBound0; i++)
        {
            for (int j = 0; j <= uBound1; j++)
            {
                bool res = mapMatrix[i, j];
                Console.WriteLine(res);
            }
        }
    }

    public static void Main(string[] args)
    {
        bool[,] mapMatrix = {
            {true, false, false},
            {true, true, false},
            {false, true, true}
        };

        traverseArray(mapMatrix);
        Console.WriteLine(RouteExists(0, 0, 2, 2, mapMatrix));
        Console.ReadLine();
    }
}