using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MassCalculate.Tests
{
    [TestClass]
    public sealed class SingleArrayTests
    {
        [TestMethod]
        public void SumArray_int_26result()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 5 };
            int result = MassCalculate.SingleArray.SumArray(array);
            Assert.AreEqual(26, result);
        }
        [TestMethod]
        public void MultiplicationArrays_Arrays_result()
        {
            int[,] arrayX = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arrayY = new int[,] { { 4, 5 }, { 2, 6 }, { 4, 8 } };
            int[,] result = MassCalculate.TwoArrays.MultiplicationArrays(arrayX, arrayY);
                CollectionAssert.AreEqual(new int[,] { { 20, 41 }, { 50, 98 } }, result);
            
        }
    }
}
