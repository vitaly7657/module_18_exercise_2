using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_18_exercise_2.SaveFormats
{
    internal class SaveToCsv : IAnimalSave
    {
        private string fileName;
        public SaveToCsv(string fileName)
        {
            this.fileName = fileName;
        }
        public void SaveAnimals(List<IAnimal> Animal)
        {
            using (StreamWriter sw = new StreamWriter($"{fileName}.csv", false, System.Text.Encoding.GetEncoding("Windows-1251")))
            {
                foreach (IAnimal s in Animal)
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}
