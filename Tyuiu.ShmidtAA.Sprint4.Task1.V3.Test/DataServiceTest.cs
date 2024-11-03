using Tyuiu.ShmidtAA.Sprint4.Task1.V3.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };

            int wait = 4*8*8*6*2;

            Assert.AreEqual(wait,ds.Calculate(array));

        }
    }
}