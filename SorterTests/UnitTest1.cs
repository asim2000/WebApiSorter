using NUnit.Framework;
using WebApi;

namespace SorterTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] {1,2,3,4},new int[] {4,3,2,1},true)]
        [TestCase(new int[] {4,3,2,1},new int[] {2,3,4,1},false)]
        [TestCase(new int[] { 1,6,7,23,445 }, new int[] { 23,445,6,7,1 },true)]
        [TestCase(new int[] { 32,23,5,0,-43},new int[] { 23,0,-43,5,32},false)]
        [TestCase(new int[] { -76,-8,0,3,67 }, new int[] { 3,-8,67,-76,0 },true)]
        public void Sort(int[] expectedValue,int[] actualValue,bool isAsc)
        {
            Sorter.Sort(actualValue,isAsc);
            Assert.AreEqual(expectedValue,actualValue);
        }
    }
}