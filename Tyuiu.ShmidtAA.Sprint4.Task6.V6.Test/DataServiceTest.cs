
using Tyuiu.ShmidtAA.Sprint4.Task6.V6.Lib;
    namespace Tyuiu.ShmidtAA.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string[] array = { "�����", "����", "������", "�����", "������", "�������", "����" };

            DataService ds = new DataService();

            string[] wait = { "�����", "�����" };

            CollectionAssert.AreEqual(wait, ds.Calculate(array));
        }
    }
}