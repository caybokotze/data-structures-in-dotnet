using NExpect;
using NUnit.Framework;
using static NExpect.Expectations;

namespace BinarySearchTree.Tests;

public class Tests
{
    [TestFixture]
    public class WhenAddingValuesToABinaryTree
    {
        [Test]
        public void DoesAddToTree()
        {
            // arrange
            var sut = Create();
            // act
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);
            sut.Add(4);
            sut.Add(5);
            sut.Add(6);
            sut.Add(7);
            sut.Add(8);
            sut.TraversePreOrder(sut.Root);
            var result = sut.Find(5);
            int depth = sut.GetTreeDepth();
            // assert
            Expect(result?.Data).To.Equal(5);
            Expect(depth).To.Equal(3);
        }
    }
  

    public static BinaryTree Create()
    {
        return new BinaryTree();
    }
}