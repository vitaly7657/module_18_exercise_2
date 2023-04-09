using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_18_exercise_2
{
    internal class Repository
    {
        public List<IAnimal> animalList; //задание списка животных
        public Repository()
        {
            animalList = new List<IAnimal>(); //при объявление репозитория поздаётся новый пустой список
            animalList.Add(new Mammals("млекопитающие", "Кошки", "Барсик", "Сиамская", 3));
            animalList.Add(new Birds("птицы", "Голуби", "Нещебет", "Английский Каррьер", 4));
            animalList.Add(new Amphibians("земноводные", "Тритоны", "Уголёк", "Альпийский", 2));
        }
        public void Add(IAnimal Animal) //метод добавление в список животных
        {
            animalList.Add(Animal);
        }
        public static Repository CreateRepository() //создание репозитория
        {
            return new Repository();
        }
    }
}
