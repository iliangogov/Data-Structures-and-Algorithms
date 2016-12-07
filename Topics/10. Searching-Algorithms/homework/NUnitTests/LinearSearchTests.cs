using NUnit.Framework;
using SortingHomework;

namespace NUnitTests
{
    [TestFixture]
    public class LinearSearchTests
    {
        [TestCase("a")]
        [TestCase("b")]
        [TestCase("c")]
        [TestCase("d")]
        [TestCase("e")]
        [TestCase("f")]
        public void LinearSearch_ShouldReturnTrueWhenElemenIsFound(string valid)
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
            Assert.That(list.LinearSearch(valid) == true);
        }

        [TestCase("dgdj")]
        public void LinearSearch_ShouldReturnFalseWhenElemenIsFound(string notValid)
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
            Assert.That(list.LinearSearch(notValid) == false);
        }
    }
}