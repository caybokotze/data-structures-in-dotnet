using System.Globalization;

namespace Shared;

public class TestData
{
    public static int[] Naturals()
    {
        return new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    public static int[] NaturalUnsorted()
    {
        return new[] {3, 1, 2, 9, 12, 35, 5, 6, 25, 24 };
    }
}