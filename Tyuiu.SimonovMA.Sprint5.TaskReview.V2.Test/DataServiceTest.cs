using Tyuiu.SimonovMA.Sprint5.TaskReview.V2.Lib;

namespace Tyuiu.SimonovMA.Sprint5.TaskReview.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckString()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V2.txt");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}