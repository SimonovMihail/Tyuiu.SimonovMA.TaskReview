using Tyuiu.SimonovMA.Sprint5.TaskReview.V2.Lib;

namespace Tyuiu.SimonovMA.Sprint5.TaskReview.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*******************************************");
            Console.WriteLine("* Дано:                                   *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("* Файл по пути:                           *");
            Console.WriteLine("* C:/DataSprint5/InPutDataFileTask7V2.txt *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("* Ответ:                                  *");
            Console.WriteLine("*******************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V2.txt");

            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("Файл по пути: " + res);
            Console.WriteLine("Создан.");
            Console.ReadKey();
        }
    }
}
