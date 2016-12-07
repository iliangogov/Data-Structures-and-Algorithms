using NUnit.Framework;
using SortingHomework;

namespace NUnitTests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [TestCase("a")]
        [TestCase("b")]
        [TestCase("c")]
        [TestCase("d")]
        [TestCase("e")]
        [TestCase("f")]
        public void BinarySearch_ShouldReturnTrueWhenElemenIsFound(string valid)
        {
            //Arrange
            var list = new SortableCollection<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");

            //Act & Assert
            Assert.That(list.BinarySearch(valid) == true);
        }

        [TestCase("dgdj")]
        public void BinarySearch_ShouldReturnFalseWhenElemenIsFound(string notValid)
        {
            //Arrange
            var list = new SortableCollection<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");

            //Act & Assert
            Assert.That(list.BinarySearch(notValid) == false);
        }
    }
}
