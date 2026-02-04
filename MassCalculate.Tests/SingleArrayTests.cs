using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MassCalculate.Tests
{
    [TestClass]
    public sealed class SingleArrayTests
    {
        [TestMethod]
        public void SumArray_int_26result()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 5};
            int result = MassCalculate.SingleArray.SumArray(array);
            Assert.AreEqual(26, result);
        }
    }
}
