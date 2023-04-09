using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_18_exercise_2
{
    internal class AnimalFactory
    {
        public static IAnimal GetAnimal(string TypeAnimals, string TypeAnimal, string Genus, string Name, string Breed, int Age) //метод добавления животного с проверкой
        {
            switch (TypeAnimals) //проверка типа животного
            {
                case "млекопитающие": return new Mammals(TypeAnimal.ToLower(), Genus, Name, Breed, Age);
                case "земноводные": return new Amphibians(TypeAnimal.ToLower(), Genus, Name, Breed, Age);
                case "птицы": return new Birds(TypeAnimal.ToLower(), Genus, Name, Breed, Age);

                default: return new UnknownAnimal(TypeAnimal.ToLower(), Genus, Name, Breed, Age); //запись неизвестного типа
            }
        }
    }
}
