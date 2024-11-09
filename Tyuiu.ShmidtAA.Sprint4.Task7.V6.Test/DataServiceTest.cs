using Tyuiu.ShmidtAA.Sprint4.Task7.V6.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            string nums = "458963214789";
            int rows = 3;
            int cols = 4;
            int[,] matrix = new int[rows, cols];
            int res = ds.Calculate(rows, cols, nums);
            int wait = 5+9+3+1+7+9;

            Assert.AreEqual(wait, res);
        }
    }
}