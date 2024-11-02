using YP_1;

class Program
{
    static void Main(string[] args) // основная программа
    {
        Cat murzik = new Cat("Мурзик");
        Cat barsik = new Cat("Барсик");
        Cat rizhic = new Cat("Рыжик");

        murzik.Meow();//мяукаем(одном котом)
        barsik.Meow();//мяукаем(другим котом)

        Console.WriteLine();

        barsik.Name = "Барсичечка";//правильный ввод, присваиваем полю новое имя через set
        barsik.Meow();

        Console.WriteLine();

        barsik.Name = "1234";//НЕправильный ввод, присваиваем полю новое имя через set
        barsik.Meow();

        Console.WriteLine();

        Console.WriteLine("Вес Рыжика:");
        var catWei = Console.ReadLine();//ввод потенциального веса кота

        if (double.TryParse(catWei.ToString(), out double bb)) //проверка на ввод
        {
            if (bb > 0) //вес не может быть меньше 0
            {
                rizhic.Weight = bb;//присваивание коту веса
                rizhic.GetWei();//вывод
            }
            else { Console.WriteLine($"{catWei} - неправильный вес!!!"); }
        }
        else { Console.WriteLine($"{catWei} - неправильный вес!!!"); }
    }
}