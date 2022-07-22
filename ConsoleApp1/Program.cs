using ConsoleApp1.Models;
using ConsoleApp1.Exceptions;
using System;
namespace ConsoleApp1
{
    public enum RecipeName { espresso, filtered, cappuccino }
    class Program
    {
        static void Main(string[] args)
        {

            CoffeeMachine coffeeMachine=new CoffeeMachine();
            Console.WriteLine($"Текущее количество единиц ингридиентов в машине:\n" +
                $"{coffeeMachine.GetBeansLevel()} зёрен кофе\n" +
                $"{coffeeMachine.GetMilkLevel()} молока\n"
                +$"{coffeeMachine.GetWaterLevel()} воды\n");
            string selector;
            Console.WriteLine("Будете загружать ингриенты? 1-Да, другие символы нет-Нет.");
            selector = Console.ReadLine();
            if (selector == "1")
            {
                int beans=0, water=0, milk=0;
                try
                {
                    Console.WriteLine("Введите количество зёрен кофе");
                    beans = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество молока");
                    milk = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество воды");
                    water = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка формата входных данных");
                    Console.ReadKey();
                    return;
                }
                try
                {
                    coffeeMachine.LoadBeans(beans);
                    coffeeMachine.LoadMilk(milk);
                    coffeeMachine.LoadWater(water);
                }
                catch(NotEnoughValueException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    return;
                }
            }
            try
            {
                Console.WriteLine("Какое кофе будете: 1.Эспрессо, 2.Фильтрованный, 3.Капучино. Введите соответсвующую цифру");
                selector = Console.ReadLine();
                if (selector == "1")
                {
                    Coffe coffe = coffeeMachine.Brew(RecipeName.espresso);
                }
                else if (selector == "2")
                {
                    Coffe coffe = coffeeMachine.Brew(RecipeName.filtered);
                }
                else if (selector == "3")
                {
                    Coffe coffe = coffeeMachine.Brew(RecipeName.cappuccino);
                }
                else
                {
                    return;
                }
                Console.WriteLine("Кофе готов");
                Console.ReadKey();
            }
            catch(NotEnoughValueException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
        }
    }
}
