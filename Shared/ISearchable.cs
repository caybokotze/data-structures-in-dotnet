namespace Shared;

public interface ISearchable
{
    /// <summary>
    /// Returns the index of the search value
    /// </summary>
    /// <param name="values"></param>
    /// <param name="find"></param>
    /// <returns></returns>
    int? Find(int[] values, int find);
}