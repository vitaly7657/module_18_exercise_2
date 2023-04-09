using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_18_exercise_2.SaveFormats
{
    internal class SaveToTxt : IAnimalSave
    {
        private string fileName;
        public SaveToTxt(string fileName)
        {
            this.fileName = fileName;
        }
        public void SaveAnimals(List<IAnimal> Animal)
        {
            using (StreamWriter sw = new StreamWriter($"{fileName}.txt",false, System.Text.Encoding.GetEncoding("Windows-1251")))
            {
                foreach (IAnimal s in Animal)
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}
