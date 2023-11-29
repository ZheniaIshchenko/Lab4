using Lab4;

internal class Program
{
    public static void Main(string[] args)
    {
        CommonFraction fraction_1 = new(7, 4);
        CommonFraction fraction_2 = new(8, 7);
        CommonFraction fraction_3 = new(2, 4);
        
        CommonFraction R;

        R = (fraction_1+ fraction_2)* (fraction_1 - fraction_3);

        Console.WriteLine("Result ---> " + R);
        Console.WriteLine("Reversed ---> " + R.reverseFraction());
    }
}