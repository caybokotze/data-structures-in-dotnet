var a = new int[100];
var beg = 0;
var end = 0;
var mid = 0;

Console.WriteLine("Begin...");

var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Data source

for(var i = 0; i <= items.Length - 1; i++)
{
    a[i] = items[i];
}

const int itemToSearch = 5; // Could use Console.ReadLine();

beg = 1;
end = items.Length;
mid = (beg + end) / 2;

while (beg <= end && a[mid] != itemToSearch)
{
    if (a[mid] < itemToSearch)
    {
        beg = mid + 1;
    }

    if (a[mid] == itemToSearch || a[mid] > itemToSearch)
    {
        end = mid - 1;
    }

    mid = (beg + end) / 2;
}

if (a[mid] == itemToSearch)
{
    Console.WriteLine("Found at position: " + mid);
}

if (a[mid] != itemToSearch)
{
    Console.WriteLine("Not found");
}


