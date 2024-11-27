using Tyuiu.SimonovMA.Sprint4.TaskReview.V4.Lib;

namespace Tyuiu.SimonovMA.Sprint4.TaskReview.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*********************************");
            Console.WriteLine("* Дано:                         *");
            Console.WriteLine("*********************************");
            Console.WriteLine("* Строка 382976421897           *");
            Console.WriteLine("*********************************");
            Console.WriteLine("* Ответ:                        *");
            Console.WriteLine("*********************************");
            string numbers = "382976421897";
            Console.WriteLine(ds.Calculate(numbers));
            Console.ReadKey();
        }
    }
}
