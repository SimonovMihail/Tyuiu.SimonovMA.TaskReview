namespace Tyuiu.SimonovMA.Sprint4.TaskReview.V4.Lib
{
    public class DataService
    {
        public int Calculate(string numbers)
        {
            int[,] mtrx = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mtrx[i, j] = int.Parse(numbers.Substring(i * 4 + j, 1));
                }
            }

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mtrx[i, j] % 2 != 0)
                    {
                        sum = sum + mtrx[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
