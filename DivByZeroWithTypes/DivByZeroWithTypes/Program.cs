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

    static void Main()
    {
        Console.WriteLine("1/0 for every types");
        tryIt(() => 1 / zeroByte);
        tryIt(() => 1 / zeroChar);
        tryIt(() => 1 / zeroShort);
        tryIt(() => 1 / zeroInt);
        tryIt(() => 1 / zeroLong);
        tryIt(() => 1 / zeroFloat);
        tryIt(() => 1 / zeroDouble);
        tryIt(() => 1 / zeroDecimal);

        Console.WriteLine("-1/0 for every types");
        tryIt(() => -1 / zeroByte);
        tryIt(() => -1 / zeroChar);
        tryIt(() => -1 / zeroShort);
        tryIt(() => -1 / zeroInt);
        tryIt(() => -1 / zeroLong);
        tryIt(() => -1 / zeroFloat);
        tryIt(() => -1 / zeroDouble);
        tryIt(() => -1 / zeroDecimal);

        Console.WriteLine("0/0 for every types");
        tryIt(() => 0 / zeroByte);
        tryIt(() => 0 / zeroChar);
        tryIt(() => 0 / zeroShort);
        tryIt(() => 0 / zeroInt);
        tryIt(() => 0 / zeroLong);
        tryIt(() => 0 / zeroFloat);
        tryIt(() => 0 / zeroDouble);
        tryIt(() => 0 / zeroDecimal);
    }
}
