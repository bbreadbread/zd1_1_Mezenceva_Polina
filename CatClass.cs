using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1
{
    class Cat
    {
        private string name; //создаем поле имя
        private double weight; //создаем поле вес

        public string Name // свойство
        {
            // получение значения - просто возврат name
            get { return name; }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        public double Weight // свойство
        {
            // получение значения - просто возврат weight
            get { return weight; }
            // установка значения - используем проверку
            set
            {
                weight = value;
            }
        }

        public Cat(string CatName) //добавляем констуктор
        {
            Name = CatName;
        }

        public void Meow() // АААААА Я В ТАЗИКЕ ЖЕСТЬ МЯЯЯЯУ!!!!
        {
            Console.WriteLine($"{name}: АААААА Я В ТАЗИКЕ ЖЕСТЬ МЯЯЯЯУ!!!!");
        }
        public void GetWei() // получаем вес
        {
            Console.WriteLine($"Вес кота {name}а: {weight}");
        }
    }
}
