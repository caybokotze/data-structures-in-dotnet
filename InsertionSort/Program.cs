// See https://aka.ms/new-console-template for more information

using Shared;

int[] a;
var n = 0;
var i = 0;
var j = 0;
var temp = 0;

a = TestData.Naturals();
n = a.Length;

for (i = 1; i <= n - 1 ; i++)
{
    for (j = i; j >= 1; j--)
    {
        if (a[j] < a[j - 1])
        {
            temp = a[j];
            a[j] = a[j - 1];
            a[j - 1] = temp;
        }
        else
        {
            break;
        }
    }
}

for (var k = 0; k < n; k++)
{
    Console.WriteLine(a[k]);
}
