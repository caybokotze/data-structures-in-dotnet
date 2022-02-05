namespace Shared;

public interface ISortable
{
    /// <summary>
    /// Returns the array in ascending order.
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    int[] Sort(int[] values);
}