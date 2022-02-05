using NExpect;
using NUnit.Framework;
using Shared;
using static NExpect.Expectations;

namespace BubbleSort.Tests;

public class BubbleSortTests
{
    [TestFixture]
    public class WhenSorting
    {
        [Test]
        public void ShouldSort()
        {
            // arrange
            var data = TestData.NaturalUnsorted();
            var sut = Create();
            // act
            data = sut.Sort(data);
            // assert
            Expect(data).To.Be.Equal.To(new[] {1, 2, 3, 5, 6, 9, 12, 24, 25, 35});
        }
    }

    public static BubbleSort Create()
    {
        return new BubbleSort();
    }
}