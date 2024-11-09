
using Tyuiu.ShmidtAA.Sprint4.Task6.V6.Lib;
    namespace Tyuiu.ShmidtAA.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string[] array = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            DataService ds = new DataService();

            string[] wait = { "Борис", "Ирина" };

            CollectionAssert.AreEqual(wait, ds.Calculate(array));
        }
    }
}