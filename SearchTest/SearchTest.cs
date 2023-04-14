using SearchAlgorithms;

namespace SearchTest
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void test_linear_search()
        {
            int[] array = { 1, 5, 6, 9, 10 };
            int expected = 3;

            int actual = SearchAlgorithm.LinearSearch(array, 9, array.Length);

            Assert.AreEqual(expected, actual, 0, "The algorithm is faulty");

        }

        [TestMethod]
        public void test_binary_search()
        {
            int[] array = { 3, 6, 7, 10, 12, 19 };
            int expected = 4;

            int actual = SearchAlgorithm.BinarySearch(array, 12, 0, 5);

            Assert.AreEqual(expected, actual, 0, "The algorithm is faulty");
        }
    }
}