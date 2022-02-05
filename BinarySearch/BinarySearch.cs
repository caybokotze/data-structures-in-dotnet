using Shared;

public class BinarySearch : ISearchable
{
    public int? Find(int[] values, int find)
    {
        var beg = 1;
        var end = values.Length;
        var mid = (beg + end) / 2;

        while (beg <= end && values[mid] != find)
        {
            if (values[mid] < find)
            {
                beg = mid + 1;
            }

            if (values[mid] == find || values[mid] > find)
            {
                end = mid - 1;
            }

            mid = (beg + end) / 2;
        }

        if (values[mid] == find)
        {
            return mid;
        }

        if (values[mid] != find)
        {
            return null;
        }

        return null;
    }
}


