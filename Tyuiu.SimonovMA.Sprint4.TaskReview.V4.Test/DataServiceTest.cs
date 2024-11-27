using Tyuiu.SimonovMA.Sprint4.TaskReview.V4.Lib;

namespace Tyuiu.SimonovMA.Sprint4.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSum()
        {
            DataService ds = new DataService();
            string numbers = "382976421897";
            int expected = 36;

            Assert.AreEqual(expected, ds.Calculate(numbers));
        }
    }
}