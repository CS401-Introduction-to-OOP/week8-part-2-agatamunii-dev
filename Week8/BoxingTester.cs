namespace Variant2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;     
        int c = (int)b;    

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
    }
}
