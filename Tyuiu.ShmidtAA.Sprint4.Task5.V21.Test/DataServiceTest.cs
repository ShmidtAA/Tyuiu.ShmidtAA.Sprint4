using Tyuiu.ShmidtAA.Sprint4.Task5.V21.Lib;
namespace Tyuiu.ShmidtAA.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = new int[5, 5] 
            
            { 
                {-8,-7,-6,-5,-4 },
                {-3,-2,1,0,0},
                {2,-1,0,0,2},
                {2,-2,2,2,1},
                {2,-1,0,0,2}
                
            };

            int[,] wait = new int[5, 5]
            {
                {-8,-7,-6,-5,-4 },
                {-3,-2,1,0,0},
                {1,-1,0,0,1},
                {1,-2,1,1,1},
                {1,-1,0,0,1}
            };

            DataService ds  = new DataService();

            CollectionAssert.AreEqual(wait, ds.Calculate(matrix));

        }
    }
}