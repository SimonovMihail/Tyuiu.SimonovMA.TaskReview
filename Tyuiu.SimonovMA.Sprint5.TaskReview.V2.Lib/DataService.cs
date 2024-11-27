using System.Text.RegularExpressions;

namespace Tyuiu.SimonovMA.Sprint5.TaskReview.V2.Lib
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            string output_path = Path.Combine("C:", "DataSprint5", "OutPutDataFileTask7V2.txt");

            FileInfo fileInfo = new FileInfo(output_path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(output_path);
            }

            string updated_content = "";

            foreach(char baby in content)
            {
                if ("0123456789".Contains(baby))
                {
                    updated_content = updated_content + "#";
                }
                else
                {
                    updated_content = updated_content + baby;
                }
            }

            File.WriteAllText(output_path, updated_content);

            return output_path;
        }
    }
}
