using System;

class Program
{
    static void Main()
    {
        float n = 1.0f;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(1 / n);
            n /= 1000.0f;
        }
    }
}
