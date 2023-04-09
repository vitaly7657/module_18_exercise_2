using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_18_exercise_2
{
    interface IAnimal
    {
        string TypeAnimal { get; set; } //тип       
        string Genus { get; set; } //род
        string Name { get; set; } //кличка
        string Breed { get; set; } //порода
        int Age { get; set; } //возраст
    }
}
