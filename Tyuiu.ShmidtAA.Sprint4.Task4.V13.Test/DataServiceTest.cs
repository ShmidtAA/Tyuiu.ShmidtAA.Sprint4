using Tyuiu.ShmidtAA.Sprint4.Task4.V13.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = { 

                { 6, 3, 5, 7, 5 }, 
                { 3, 5, 7, 4, 5 }, 
                { 5, 6, 4, 5, 4 }, 
                { 7, 4, 7, 3, 3 }, 
                { 4, 6, 5, 5, 6 } 
            
            };

            int wait = 44;

            DataService ds = new DataService();

            Assert.AreEqual(wait,ds.Calculate(matrix));

           
        }
    }
}