using Tyuiu.ShmidtAA.Sprint4.Task0.V18.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = new int[10] { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            int wait = 41;

            Assert.AreEqual(wait, ds.GetSumOddArrEl(array));
        }
    }
}