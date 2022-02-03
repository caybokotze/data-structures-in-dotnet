// See https://aka.ms/new-console-template for more information

using Shared;

var a = TestData.Naturals();
var n = a.Length;
var s = 0;

var item = 7;

for (var i = 1; i <= n - 1; i++)
{
    if (a[i] == item)
    {
        s = 1;
        break;
    }
}

if (s == 0)
{
    Console.WriteLine("No data found");
}