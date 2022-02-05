using NExpect;
using NUnit.Framework;
using Shared;

namespace BinarySearch.Tests;

[TestFixture]
public class BinarySearchTests
{
    [TestFixture]
    public class WhenSearchingForValue
    {
        [Test]
        public void ShouldReturnCorrectIndex()
        {
            // arrange
            var data = TestData.Naturals();
            var sut = Create();
            // act
            var index = sut.Find(data, 3);
            // assert
            Expectations.Expect(index).To.Equal(2);
        }
    }

    public static BinarySearch Create()
    {
        return new BinarySearch();
    }
}