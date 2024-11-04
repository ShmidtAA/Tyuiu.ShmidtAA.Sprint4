using Tyuiu.ShmidtAA.Sprint4.Task3.V14.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = new int[5, 5]
            {
            {3, 2, 3, 3, 5 },
            {2, 3, 3, 7, 3 },
            {7, 5, 2, 7, 3 },
            {4, 2, 7, 5, 2 },
            {3, 5, 4, 2, 6 } 
            
            };

            DataService ds = new DataService();

            int wait = 7;

            Assert.AreEqual(wait,ds.Calculate(array));

        }
    }
}