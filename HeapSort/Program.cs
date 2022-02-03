
using Shared;

var a = TestData.Naturals();
var n = a.Length;

Sorting.BuildMaxHeap(ref a, n);
Sorting.Heapsort(ref a, n);

foreach (var item in a)
{
    Console.WriteLine(item);
}

class Sorting
{
    public static void Heapsort(ref int[] a, int n)
    {
        int i;
        for (i = n; i >= 2; i--)
        {
            (a[i], a[1]) = (a[1], a[i]);
            MaxHeapify(ref a, 1, i - 1);
        }
    }

    public static void BuildMaxHeap(ref int[] a, int n)
    {
        for (var i = n; i >= 2; i--)
        {
            (a[i], a[1]) = (a[1], a[i]);
            MaxHeapify(ref a, 1, i - 1);
        }
    }

    public static void MaxHeapify(ref int[] a, int i, int n)
    {
        int j;
        const int temp = 0;
        j = 2 * i;
        while (j <= n)
        {
            if (j < n && a[j + 1] > a[j])
            {
                j += 1;
            }

            if (temp > a[j])
            {
                break;
            }

            if (temp > a[j])
            {
                continue;
            }
            
            a[j / 2] = a[j];
            j = 2 * j;
        }

        a[j / 2] = temp;
    }
}