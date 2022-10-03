using System;
public class Program
{
    public static double[] FindVertex(int a, int b, int c)
    {
        double[] result = new double[2];

        //formula for result[0]: -b / 2a
        //formula for result[1]: (a * x2) + (b * x) + c

        result[0] = -(b) / (2d * a);
        result[1] = (a * Math.Pow(result[0], 2)) + (b * result[0]) + c;
        return result;
    }

public static void Main()
    {
        double[] vertex = new double[2];
        foreach (int i in vertex)
            vertex = FindVertex(5, -20, 15);
        Console.WriteLine("x = {0}", vertex[0]);
        Console.WriteLine("y = {0}", vertex[1]);
    }
}