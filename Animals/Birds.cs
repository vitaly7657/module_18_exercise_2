using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_18_exercise_2
{
    class Birds : IAnimal //реализация интерфейса
    {
        public string TypeAnimal { get; set; }
        public string Genus { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public Birds(string TypeAnimal, string Genus, string Name, string Breed, int Age)
        {
            this.TypeAnimal = TypeAnimal;
            this.Genus = Genus;
            this.Name = Name;
            this.Breed = Breed;
            this.Age = Age;
        }
        public override string ToString() //перезапить ToString для вывода данных
        {
            return $"Тип: {this.TypeAnimal}, род: {this.Genus}, кличка: {this.Name}, порода: {this.Breed}, возраст: {this.Age} лет";
        }
    }
}
