using Shared;

namespace BubbleSort;

public class BubbleSort
{
    public int[] Sort(int[] input)
    {
        for (var write = 0; write < input.Length; write++)
        {
            for (var sort = 0; sort < input.Length - 1; sort++)
            {
                if (input[sort] > input[sort + 1])
                {
                    (input[sort + 1], input[sort]) = (input[sort], input[sort + 1]);
                }
            }
        }

        return input;
    }
}