using System;

class Program
{
    private static void tryIt<T>(Func<T> action)
    {
        string result = "No Result";
        try
        {
            result = "Value:\t\t" + action().ToString();
        }
        catch (Exception e)
        {
            result = "Exception:\t" + e.Message;
        }
        Console.WriteLine($"{typeof(T).Name,16 }={result}");
    }

    private static byte zeroByte = 0;
    private static char zeroChar = '\0';
    private static short zeroShort = 0;
    private static int zeroInt = 0;
    private static long zeroLong = 0;
    private static float zeroFloat = 0;
    private static double zeroDouble = 0;
    private static decimal zeroDecimal = 0;

    private static void tryAll(int n)
    {
        Console.WriteLine($"{n}/0 for every types");
        tryIt(() => n / zeroByte);
        tryIt(() => n / zeroChar);
        tryIt(() => n / zeroShort);
        tryIt(() => n / zeroInt);
        tryIt(() => n / zeroLong);
        tryIt(() => n / zeroFloat);
        tryIt(() => n / zeroDouble);
        tryIt(() => n / zeroDecimal);
    }
    static void Main()
    {
        tryAll(1);
        tryAll(-1);
        tryAll(0);
    }
}
