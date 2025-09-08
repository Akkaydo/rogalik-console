using System;

class Program
{
    static void Main()
    {
        foreach (char bukva in "Вы просыпаетесь в комнате... \nВведите имя персонажа:")
        {
            Console.Write(bukva);
            Thread.Sleep(50);
        }
        Console.WriteLine();

        string name = Console.ReadLine();

        bool artifact1 = false;
        bool artifact2 = false;
        bool artifact3 = false;
        bool chestOpened = false;
        bool doorOpened = false;

        while (!doorOpened)
        {
            Console.WriteLine($"\n{name}, осмотритесь вокруг. Доступные действия:");
            Console.WriteLine("a) Открыть дверь");
            Console.WriteLine("b) Заглянуть под кровать");
            Console.WriteLine("c) Открыть ящик в углу комнаты");
            Console.WriteLine("d) Открыть вентиляцию");
            Console.WriteLine("e) Взглянуть на тумбочку");
            Console.WriteLine("f) Взглянуть на статую рядом с дверью");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ваш выбор:");
            Console.ResetColor();
           
            string choice = Console.ReadLine();
            Console.Clear();

            Thread.Sleep(700);

            switch (choice)
            {
                case "a":
                    if (chestOpened)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вы используете ключ и открываете дверь. Поздравляем, вы выбрались!");
                        Console.ResetColor();
                        doorOpened = true;
                    }
                    else
                    {
                        Console.WriteLine("Дверь заперта. Нужен ключ.");
                    }
                    break;

                case "b":
                    if (!artifact1)
                    {
                        Console.WriteLine("Под кроватью найден первый артефакт!");
                        artifact1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Под кроватью больше ничего нет.");
                    }
                    break;

                case "c":
                    if (!chestOpened)
                    {
                        if (artifact1 && artifact2 && artifact3)
                        {
                            Console.WriteLine("Статуя активирована артефактами. В ящике найден ключ!");
                            chestOpened = true;
                        }
                        else
                        {
                            Console.WriteLine("Ящик заперт. Похоже, нужно активировать статую.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ящик уже открыт.");
                    }
                    break;

                case "d":
                    if (!artifact2)
                    {
                        Console.WriteLine("В вентиляции найден второй артефакт!");
                        artifact2 = true;
                    }
                    else
                    {
                        Console.WriteLine("В вентиляции пусто.");
                    }
                    break;

                case "e":
                    if (!artifact3)
                    {
                        Console.WriteLine("На тумбочке найден третий артефакт!");
                        artifact3 = true;
                    }
                    else
                    {
                        Console.WriteLine("На тумбочке больше ничего нет.");
                    }
                    break;

                case "f":
                    if (artifact1 && artifact2 && artifact3)
                    {
                        Console.WriteLine("Вы активировали статую с помощью трех артефактов!");
                    }
                    else
                    {
                        Console.WriteLine("Статуя неподвижна. Похоже, нужны артефакты.");
                    }
                    break;

                default:
                    Console.WriteLine("Неизвестная команда. Попробуйте снова.");
                    break;
            }
        }
    }
}